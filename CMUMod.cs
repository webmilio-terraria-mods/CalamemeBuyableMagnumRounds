using Terraria.ModLoader;
using CalamityMod = CalamityMod.CalamityMod;

namespace CalamemeMagnumUnleashed
{
    public sealed class CMUMod : Mod
    {
        public override void Load()
        {
            Calameme = ModLoader.GetMod(nameof(global::CalamityMod.CalamityMod)) as global::CalamityMod.CalamityMod;
        }

        public override void Unload()
        {
            Calameme = null;
        }

        public static global::CalamityMod.CalamityMod Calameme { get; private set; }
    }
}