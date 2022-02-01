using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HoloENMod.Items.Bosses.Reaper
{
    public class Ricky : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(16, 16);

            item.melee = true;
            item.damage = 37;
            item.knockBack = 3f;

            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.autoReuse = true;
            item.useTurn = true;
            item.value = Item.buyPrice(silver: 10);
            item.rare = ItemRarityID.Blue;

            item.shoot = ModContent.ProjectileType<Projectiles.SmallSlash>();
            item.shootSpeed = 5f;
        }
    }

}
