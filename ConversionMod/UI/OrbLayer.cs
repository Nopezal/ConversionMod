using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using TAPI;
using Microsoft.Xna.Framework;
using Terraria;

namespace ConversionMod.UI
{
    public class OrbLayer : InterfaceLayer
    {
        ModBase modBase;

        internal static Color orbColour = Color.White;

        public OrbLayer(ModBase @base)
            : base("ConversionMod:OrbLayer")
        {
            modBase = @base;
        }

        protected override void OnDraw(SpriteBatch sb)
        {
            sb.Draw(modBase.textures["Images/chargingorb"], new Vector2(Main.localPlayer.position.X, Main.localPlayer.position.Y - 200), orbColour);
        }
    }
}
