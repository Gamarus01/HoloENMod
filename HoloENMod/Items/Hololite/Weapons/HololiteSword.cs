using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HoloENMod.Items.Hololite.Weapons
{
    public class HololiteSword : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(16, 16);

            item.melee = true;
            item.damage = 25;
            item.knockBack = 3f;

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.autoReuse = true;
            item.useTurn = true;
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
