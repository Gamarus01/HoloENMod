using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.Projectiles
{
	public class HololiteBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hololite Bolt");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 9;
			projectile.friendly = true;
			projectile.magic = true;
		}

		// Additional hooks/methods here.
	}
}


