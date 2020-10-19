using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace BleakDusk.Projectiles
{
    class EtheralDagger : ModProjectile
    {
        Vector2 initialPosition = new Vector2();
        bool setPosition = false;
        float direction = 0;
        // Tweaks
        float directionIncrement = 5;
        float rangeIncrement = 2f;
        float range = 128;
        float maxRange = 128;

        public override void SetDefaults()
        {
            projectile.damage = 1;
            projectile.penetrate = -1;
            projectile.minion = true;
            projectile.melee = true;
            projectile.timeLeft = 300;
            projectile.friendly = true;
        }

        public override void AI()
        {
            if (setPosition == false) { initialPosition = projectile.position; setPosition = true; }
            projectile.position = initialPosition + new Vector2((float) Math.Cos(direction) * range, (float) Math.Sin(direction) * range);
            projectile.rotation = direction;
            direction+=(float) (Math.PI/180f) * directionIncrement;
            if (Math.Abs(direction) > Math.PI*2) 
            { 
                direction = 0;
                rangeIncrement *= -1;
                directionIncrement *= -1;
            }
            // range += rangeIncrement;
            /*if (Math.Abs(range) > maxRange)
            {

            }*/
        }

    }
}
