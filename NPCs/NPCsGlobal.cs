using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BleakDusk.NPCs
{
    public class NPCsGlobal : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        Random random = new Random();

        public bool plagueBlight = false;
        public int plagueDamage = 0;

        public int blastBlight = 0;
        public int blastCounts = 0;

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (plagueBlight)
            {
                damage += random.Next(plagueDamage, plagueDamage+2);
                npc.lifeRegen -= damage;
            }
            else if (plagueBlight == false && plagueDamage > 0)
            {
                plagueDamage = 0;
            }

            if (blastBlight > (npc.lifeMax * 0.05) * (1 + Math.Pow(blastCounts, blastCounts)))
            {
                blastBlight -= (int)Math.Floor(npc.lifeMax * 0.05)*blastCounts;
                damage += (int)Math.Floor(npc.lifeMax * 0.1);
                npc.life -= damage;
                blastCounts++;
                npc.HitEffect(0, damage);
                CombatText.NewText(npc.Hitbox, Color.Orange, damage, true, true);
                Main.PlaySound(SoundID.Item62, npc.position);
            }
            npc.CheckActive();
            npc.checkDead();
        }

    }
}