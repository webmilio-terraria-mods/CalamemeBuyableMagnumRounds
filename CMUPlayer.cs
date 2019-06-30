using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Weapons.FiniteUse;
using Terraria;
using Terraria.ModLoader;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUPlayer : ModPlayer
    {
        public override void PreUpdateMovement()
        {
            if (!CalamityPlayer.areThereAnyDamnBosses)
                return;

            for (int index = 0; index < 58; ++index)
            {
                if (player.inventory[index].type == CMUMod.Calameme.ItemType<Magnum>() || player.inventory[index].type == CMUMod.Calameme.ItemType<LightningHawk>() || player.inventory[index].type == CMUMod.Calameme.ItemType<ElephantKiller>())
                    player.inventory[index].GetGlobalItem<CalamityGlobalItem>(CMUMod.Calameme).timesUsed = 0;
            }
        }
    }
}