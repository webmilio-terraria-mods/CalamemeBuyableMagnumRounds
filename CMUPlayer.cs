using System.Collections.Generic;
using System.Linq;
using CalamityMod;
using CalamityMod.CalPlayer;
using CalamityMod.Items;
using CalamityMod.Items.Weapons.Typeless.FiniteUse;
using Terraria;
using Terraria.ModLoader;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUPlayer : ModPlayer
    {
        private IReadOnlyList<int> _itemsToEatTheAssOf;


        public override void PreUpdateMovement()
        {
            if (_itemsToEatTheAssOf == null)
                _itemsToEatTheAssOf = new List<int>() 
                {
                    ModContent.ItemType<Magnum>(), ModContent.ItemType<LightningHawk>(), ModContent.ItemType<ElephantKiller>(),
                    ModContent.ItemType<Bazooka>(), 
                    ModContent.ItemType<Hydra>()
                }.AsReadOnly();


            if (!CalamityPlayer.areThereAnyDamnBosses)
                return;

            for (int index = 0; index < player.inventory.Length; ++index)
            {
                Item item = player.inventory[index];

                if (_itemsToEatTheAssOf.Contains(item.type))
                    item.GetGlobalItem<CalamityGlobalItem>().timesUsed = 0;
            }
        }
    }
}