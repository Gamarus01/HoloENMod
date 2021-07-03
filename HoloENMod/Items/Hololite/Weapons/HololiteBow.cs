using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HoloENMod.Items.Hololite.Weapons
{
    public class HololiteBow : ModItem
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

            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 8.75f;
            item.useAmmo = AmmoID.Arrow;
            item.autoReuse = true;

            item.value = Item.buyPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ModContent.ItemType<HololiteBar>(), 12);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
