using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using HoloENMod.Tiles;


namespace HoloENMod.Items.Hololite.Armors
{
	[AutoloadEquip(EquipType.Head)]
	public class HololiteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hololite Helmet");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<HololiteBreastplate>() && legs.type == ModContent.ItemType<HololiteLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+10% all damage, +5 max hp";
			player.allDamage += 0.1f;
			player.statLifeMax2 += 5;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<HololiteBar>(), 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
