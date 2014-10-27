using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using TAPI;

namespace ConversionMod.UI
{
    public class OrbLayer : InterfaceLayer
    {
        readonly static string
            TEXTURE_NAME = "Images/ChargingOrb";

        ModBase modBase;

        internal static Color orbColour = new Color(255, 255, 255, 0);

        public OrbLayer(ModBase @base)
            : base("ConversionMod:OrbLayer")
        {
            modBase = @base;
        }

        protected override void OnDraw(SpriteBatch sb)
        {
            sb.End();
            sb.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.PointClamp, null, null);

            sb.Draw(modBase.textures[TEXTURE_NAME], Main.localPlayer.position - new Vector2(0f, 200f) - Main.screenPosition, orbColour);
        }
    }
}
