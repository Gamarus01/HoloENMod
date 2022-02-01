using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace HoloENMod.Items.Bosses.Reaper
{
    public class ReaperBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Cyan;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();

            
            if (Main.rand.NextBool())
                player.QuickSpawnItem(ModContent.ItemType<Bosses.Reaper.ReaperShotgun>());
            else player.QuickSpawnItem(ModContent.ItemType<Bosses.Reaper.Ricky>());

        }

        public override int BossBagNPC => ModContent.NPCType<NPCs.Bosses.Reaper>(); 

    }
}

