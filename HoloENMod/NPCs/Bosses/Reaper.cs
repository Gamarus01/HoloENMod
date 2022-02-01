using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace HoloENMod.NPCs.Bosses
{
    [AutoloadBossHead]
    public class Reaper : ModNPC
    {
        private int ai;
        private bool rand = true;
        private bool slashmade = false;
        private Vector2 beta  = Vector2.UnitY;
        
        private int frame = 0;
        private float attackCool
        {
            get => npc.ai[1];
            set => npc.ai[1] = value;
        }

        private int contadorDash = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reaper");
            Main.npcFrameCount[npc.type] = 5;
        }

        public override void SetDefaults()
        {
            npc.width = 100;
            npc.height = 200;
            npc.boss = true;
            npc.aiStyle = -1;
            npc.npcSlots = 10f;

            npc.lifeMax = 6000;
            npc.damage = 30;
            npc.defense = 20;
            npc.knockBackResist = 0f;

            npc.value = Item.buyPrice(gold: 1);

            npc.lavaImmune = true;
            npc.noTileCollide = true;
            npc.noGravity = true;

            music = MusicID.Boss2;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
            npc.damage = (int)(npc.damage * 1.3f);
        }

        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                
                Item.NewItem(npc.position, ModContent.ItemType<Items.Bosses.Reaper.ReaperBag>());
            }
            else 
            {
                if (Main.rand.NextBool())
                    Item.NewItem(npc.position, ModContent.ItemType<Items.Bosses.Reaper.ReaperShotgun>());
                else Item.NewItem(npc.position, ModContent.ItemType<Items.Bosses.Reaper.Ricky>());
            }

        }
        private void LookToPlayer()
        {
            Vector2 look = Main.player[npc.target].Center - npc.Center;
            LookInDirection(look);
        }

        private void LookInDirection(Vector2 look)
        {
            float angle = 0.5f * (float)Math.PI;
            if (look.X != 0f)
            {
                angle = (float)Math.Atan(look.Y / look.X);
            }
            else if (look.Y < 0f)
            {
                angle += (float)Math.PI;
            }
            if (look.X < 0f)
            {
                angle += (float)Math.PI;
            }
            npc.rotation = angle;
        }
        public override void AI()
        {
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;

            npc.rotation = 0.0f;
            npc.netAlways = true;
            npc.TargetClosest(true);

            if (npc.life > npc.lifeMax) npc.life = npc.lifeMax;

            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active) 
            {     
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.2f;
                if (npc.timeLeft > 20)
                {
                    npc.timeLeft = 20;
                    return;
                }
            }

            ai++;
            npc.ai[0] = (float)ai * 1f;
            int distance = (int)Vector2.Distance(target, npc.Center);


            if ((double)npc.ai[0] < 250)
            {
                frame = 0;
                npc.velocity = (player.Center - npc.Center + beta * -200) / 100f;
                npc.netUpdate = true;
            }
            if (rand)
            {
                //Slash
                if ((double)npc.ai[0] > 250 && (double)npc.ai[0] < 280)
                {
                    frame = 1;
                    npc.velocity = (player.Center - npc.Center + beta * -150) / 10f;
                   
                }
                if ((double)npc.ai[0] > 280 && (double)npc.ai[0] < 303)
                {
                    frame = 2;
                    npc.velocity = Vector2.Zero;
                }
                if ((double)npc.ai[0] > 303)
                {
                    frame = 3;
                    // beta.X = beta.X * (-1);
                    if (!slashmade)
                    {
                        slashmade = true;
                        Projectile.NewProjectile(npc.Center.X, npc.Center.Y + 130f, 0, 0, ModContent.ProjectileType<Projectiles.Bosses.BigSlash>(), 30, 3f, Main.myPlayer, 600f);
                    }

                }
            }
            else if (!rand && (double)npc.ai[0] > 250)
            {
                //Dash
                attackCool -= 1f;
                if (attackCool <= 1f)
                    {
                        frame = 4;
                        ++contadorDash;
                        attackCool = 80f;
                        npc.TargetClosest(false);
                        LookToPlayer();
                        float speed = (12.5f - 1.5f * (float)npc.life / (float)npc.lifeMax) + 1.0f*contadorDash;
                        npc.velocity = speed * new Vector2((float)Math.Cos(npc.rotation), (float)Math.Sin(npc.rotation));
                        npc.netUpdate = true;
                    }
                    else
                    {
                    //LookInDirection(npc.velocity);
                        npc.velocity *= 0.995f;
                    }               
            }

            

            if (rand && (double)npc.ai[0] > 315 || !rand && contadorDash > 4) 
            {
                 slashmade = false;
                 contadorDash = 0;
                 ai = 0;
                 rand = Main.rand.NextBool();
            }
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frame.Y = frame * frameHeight;
        }
    }
}
