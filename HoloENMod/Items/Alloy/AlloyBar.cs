using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace HoloENMod.Items.Alloy
{
    public class AlloyBar : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;

            item.maxStack = 999;
            item.value = Item.buyPrice(silver: 5);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;
 
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Hololite.HololiteBar>(), 2);
            recipe.AddIngredient(ModContent.ItemType<SCFragment>(), 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }


    }
}