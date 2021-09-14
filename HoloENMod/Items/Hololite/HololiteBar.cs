using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace HoloENMod.Items.Hololite
{
    public class HololiteBar : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;

            item.maxStack = 999;
            item.value = Item.buyPrice(silver: 5);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;

            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;

            item.createTile = ModContent.TileType<Tiles.HololiteBar>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<HololiteOre>(), 4);
            recipe.AddIngredient(ModContent.ItemType<Materials.MythicalShard>(), 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}