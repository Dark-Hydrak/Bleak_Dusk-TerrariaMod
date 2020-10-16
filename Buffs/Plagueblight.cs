using BleakDusk.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace BleakDusk.Buffs
{
    public class Plagueblight : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Plagueblight");
            Description.SetDefault("You are inflicted with a very, very potent [c/00BB00:plague].");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<NPCsGlobal>().plagueBlight = true;
        }

    }
}