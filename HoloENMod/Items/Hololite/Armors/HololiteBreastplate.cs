using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HoloENMod.Tiles;

namespace HoloENMod.Items.Hololite.Armors
{
	[AutoloadEquip(EquipType.Body)]
	public class HololiteBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Hololite Breastplate");
			Tooltip.SetDefault("Made with the essence of " +
				"\nhopes and dreams!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 9;
		}

		public override void UpdateEquip(Player player)
		{

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