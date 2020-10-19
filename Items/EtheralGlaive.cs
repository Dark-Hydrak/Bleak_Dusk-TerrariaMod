using BleakDusk.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BleakDusk.Items
{
    class EtheralGlaive : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Made from the remains of a [c/66FFFF:frost wyvern]...");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 20;
            item.crit = 0;
            item.knockBack = 5;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useAnimation = 300;
            item.useTime = 10;
            item.shoot = mod.ProjectileType("EtheralDagger");
        }
    }
}
