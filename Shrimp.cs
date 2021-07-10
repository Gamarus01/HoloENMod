using HoloENMod.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.NPCs
{
    public class Shrimp : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shrimp");

            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }

        public override void SetDefaults()
        {
            npc.width = 54;
            npc.height = 34;

            npc.lifeMax = 250;

            npc.damage = 13;
            npc.defense = 12;

            npc.value = 8f;
            npc.knockBackResist = 0.9f;
            npc.aiStyle = 3;

            aiType = NPCID.Zombie;

            animationType = NPCID.Zombie;

             
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {

            return SpawnCondition.OverworldNightMonster.Chance * 0.4f;
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(2) == 1)
            {
                Item.NewItem(npc.position, ModContent.ItemType<Items.Materials.MythicalShard>());
            }

        }

    }
}
