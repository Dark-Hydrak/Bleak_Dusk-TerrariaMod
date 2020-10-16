using System;
using Terraria;
using Terraria.ModLoader;

namespace BleakDusk.NPCs
{
    public class NPCsGlobal : GlobalNPC
    {
        public bool plagueBlight = false;

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (plagueBlight == true)
            {
                Random random = new Random();
                damage = random.Next(1, 3);
            }
        }

    }
}