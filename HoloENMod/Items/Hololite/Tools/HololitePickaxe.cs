using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HoloENMod.Items.Hololite.Tools
{
    public class HololitePickaxe : ModItem
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
            //Pickaxe properties
            item.pick = 75;
            //Weapon properties
            item.melee = true;
            item.damage = 10;
            item.knockBack = 1.4f;
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
