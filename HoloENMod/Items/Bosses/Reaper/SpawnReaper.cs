using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HoloENMod.NPCs.Bosses;


namespace HoloENMod.Items.Bosses.Reaper
{
	public class SpawnReaper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dad's wine");
			Tooltip.SetDefault("A present from deth sensei, don't open it or dad will get mad");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = ItemRarityID.Cyan;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return !NPC.AnyNPCs(ModContent.NPCType<NPCs.Bosses.Reaper>());
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.Bosses.Reaper>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
 
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<Items.Hololite.HololiteBar>(), 20);
			r.AddIngredient(ModContent.ItemType<Items.Materials.MythicalShard>(), 10);
			r.AddTile(TileID.Anvils);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}


