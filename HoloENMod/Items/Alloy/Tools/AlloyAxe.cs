using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HoloENMod.Items.Alloy.Tools
{
    public class AlloyAxe : ModItem
    {
        public override void SetDefaults()
        {
            //Hitbox size
            item.width = 32;
            item.height = 32;
            //Stack and value
            item.value = Item.buyPrice(silver: 5);
            item.rare = ItemRarityID.Blue;
            //Usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;
            //Axe properties
            item.axe = 200;
            //Weapon properties
            item.melee = true;
            item.damage = 10;
            item.knockBack = 1.4f;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ModContent.ItemType<AlloyBar>(), 12);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
