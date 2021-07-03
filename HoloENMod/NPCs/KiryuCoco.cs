using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;


namespace HoloENMod.NPCs
{
	[AutoloadHead]
    public class KiryuCoco : ModNPC
    {

        public override string Texture {
			get { return "HoloENMod/NPCs/KiryuCoco"; }
		}

		public override string[] AltTextures
		{ 
			get { return new[] { "HoloENMod/NPCs/KiryuCoco_Alt_1" }; }
		}

        public override bool Autoload(ref string name)
        {
			name = "Based Dragon";
			return mod.Properties.Autoload;
        }

		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = 23;
			NPCID.Sets.ExtraFramesCount[npc.type] = 7;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackTime[npc.type] = 0;
			NPCID.Sets.AttackType[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 230;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}
		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 44;
			npc.height = 58;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
				Player player = Main.player[k];
				if (!player.active)
                {
					continue;
                }

				foreach (Item item in player.inventory)
                {
					if (item.type == mod.ItemType("HololiteBar"))
                    {
						return true;
                    }
                }
            }

			return false;
        }

        public override string TownNPCName()
        {
			return "Coco";
        }

		public override string GetChat()
		{
			if (Main.dayTime && Main.time < 25000)
			{
				return "Good morning motherfuckers";
			}
			else if (!Main.dayTime)
			{
				return "Come get some Asacoco!";
			}
			else
				return "Have you seen my wife? She's short , cute and strong as a gorilla";

		}

        
        public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
			if (firstButton)
			{
				shop = true;
			}
		}

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Consumables.Asacoco>());
			nextSlot++;
		}
		

    }
}
