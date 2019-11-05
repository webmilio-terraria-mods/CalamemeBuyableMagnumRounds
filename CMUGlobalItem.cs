using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (CMUGlobalNPC.armsDealerAmmo.Values.Contains(item.type))
                item.maxStack = 999;
        }
    }
}