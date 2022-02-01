using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace HoloENMod.Projectiles
{
	public class SmallSlash : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Small Slash");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 20;
			projectile.timeLeft = 90;
			projectile.aiStyle = -1;
			aiType = ProjectileID.IceSickle;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.ignoreWater = true;


		}

		public override void AI()
        {
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f); // projectile faces sprite right
			projectile.spriteDirection = projectile.direction;
			projectile.velocity = projectile.velocity * 0.995f;
			drawOriginOffsetY = 10;
			drawOffsetX = -5;
		}
	}
}


