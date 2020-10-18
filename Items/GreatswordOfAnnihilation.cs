using BleakDusk.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BleakDusk.Items
{
    class GreatswordOfAnnihilation : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("[c/BBAA00:Blast: ]200\nA [c/BBAA00:highly-volatile] blade to hunt monsters with!");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.rare = ItemRarityID.Expert;
            item.useAnimation = 20;
            item.useTime = 5;
            item.crit = 0;
            item.knockBack = 4;
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {

            target.GetGlobalNPC<NPCsGlobal>().blastBlight += 200;

        }

    }
}
