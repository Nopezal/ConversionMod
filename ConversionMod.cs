using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using TAPI;
using ConversionMod.API;

namespace ConversionMod
{
    public sealed class ConversionMod : ModBase
    {
        public override void OnLoad  ()
        {
            base.OnLoad();

            ConversibleBiome.LoadVanilla();
        }
        public override void OnUnload()
        {
            base.OnUnload();

            ConversibleBiome.biomes.Clear();
        }
    }
}
