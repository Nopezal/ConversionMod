﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using TAPI;
using ConversionMod.API;
using ConversionMod.UI;

namespace ConversionMod
{
    public sealed class MPlayer : ModPlayer
    {
        ConversibleBiome
            current   = null,
            old       = null;

        public override void MidUpdate()
        {
            U_BiomeColour();
        }

        void U_BiomeColour()
        {
            if (Main.dedServ)
                return;

            current = null;
            foreach (var cb in ConversibleBiome.biomes.Values)
                if (cb.Biome.Check(player))
                {
                    current = cb;
                    break;
                }

            if (old != current)
            {
                if (current != null)
                {
                    if (OrbLayer.orbColour.A < 255)
                    {
                        byte a = OrbLayer.orbColour.A;
                        OrbLayer.orbColour = Color.Lerp(old == null ? Color.White : old.Colour, current.Colour, 1f / 255f);
                        OrbLayer.orbColour.A = ++a;
                    }
                    else
                        old = current;
                }
                else if (OrbLayer.orbColour.A > 0)
                {
                    OrbLayer.orbColour.A--;

                    if (OrbLayer.orbColour.A == 0)
                        OrbLayer.orbColour = new Color(255, 255, 255, 0);
                }
            }
        }
    }
}
