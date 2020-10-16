using System;
using Terraria;
using Terraria.ModLoader;

namespace BleakDusk.NPCs
{
    public class NPCsGlobal : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        Random random = new Random();
        public bool plagueBlight = false;

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (plagueBlight)
            {
                damage = random.Next(100, 200);
                npc.lifeRegen = 0 - damage;
            }
        }

    }
}