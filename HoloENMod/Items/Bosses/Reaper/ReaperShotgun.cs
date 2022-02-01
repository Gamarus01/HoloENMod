using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace HoloENMod.Items.Bosses.Reaper
{
    public class ReaperShotgun : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 28);

            item.ranged = true;
            item.damage = 22;
            item.knockBack = 0.5f;
            item.crit = 10;
            item.noMelee = true;

            item.useTime = 27;
            item.useAnimation = 6;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 8.75f;
            item.useAmmo = AmmoID.Bullet;
            item.autoReuse = true;

            item.value = Item.buyPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, 
            ref int type, ref int damage, ref float knockBack)
        {
            int numProjectiles = 4;
            for (int i = 0; i < numProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
       
    }
}
