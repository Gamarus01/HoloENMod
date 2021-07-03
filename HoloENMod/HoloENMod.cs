using Terraria.ModLoader;

namespace HoloENMod
{
	public class HoloENMod : Mod
	{
		public static HoloENMod Instance;

		public HoloENMod() 
		{
			Instance = this;
		}

        public override void Load()
        {
			if (Instance != this || Instance == null)
				Instance = this;
        }


    }
}