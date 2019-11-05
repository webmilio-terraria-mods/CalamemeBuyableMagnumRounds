using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CalamityMod.Items.Ammo.FiniteUse;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUGlobalNPC : GlobalNPC
    {
        internal static IReadOnlyDictionary<Func<bool>, int> armsDealerAmmo = new ReadOnlyDictionary<Func<bool>, int>(new Dictionary<Func<bool>, int>()
        {
            { () => NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || NPC.downedSlimeKing || Main.hardMode, ModContent.ItemType<MagnumRounds>() },
            { () => NPC.downedBoss3 || Main.hardMode, ModContent.ItemType<GrenadeRounds>() },
            { () => NPC.downedMechBossAny, ModContent.ItemType<ExplosiveShells>() }
        });


        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (armsDealerAmmo == null)
                armsDealerAmmo = new ReadOnlyDictionary<Func<bool>, int>(new Dictionary<Func<bool>, int>()
                {
                    { () => NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || NPC.downedSlimeKing || Main.hardMode, ModContent.ItemType<MagnumRounds>() },
                    { () => NPC.downedBoss3 || Main.hardMode, ModContent.ItemType<GrenadeRounds>() },
                    { () => NPC.downedMechBossAny, ModContent.ItemType<ExplosiveShells>() }
                });


            if (type == NPCID.ArmsDealer)
            {
                foreach (KeyValuePair<Func<bool>, int> ammo in armsDealerAmmo)
                {
                    if (!ammo.Key())
                        continue;

                    shop.item[nextSlot].SetDefaults(ammo.Value);
                    nextSlot++;
                }
            }
        }
    }
}