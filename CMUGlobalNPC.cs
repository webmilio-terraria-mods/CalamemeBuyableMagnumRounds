using CalamityMod.Items.Weapons.FiniteUse;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUGlobalNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.ArmsDealer)
            {
                if (NPC.downedBoss1 || NPC.downedSlimeKing)
                {
                    shop.item[nextSlot].SetDefaults(CMUMod.Calameme.ItemType<MagnumRounds>());

                    nextSlot++;
                }
            }
        }
    }
}