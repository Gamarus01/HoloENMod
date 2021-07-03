using HoloENMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.Items.Alloy.Armors
{
	[AutoloadEquip(EquipType.Body)]
	public class AlloyBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Alloy Breastplate");
			Tooltip.SetDefault("This is a modded body armor."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 69;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
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