/*using System;
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

        public override void Save(BinBuffer bb)
        {
            bb.Write(ConversionQuest.Prestige);
            bb.Write(OrbLayer.orbColour);
        }

        public override void Load(BinBuffer bb)
        {
            bb.ReadInt();
            bb.ReadColor();
        }

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
                if (cb.Biome.Check(player) )
                {
                    current = cb;
                    break;
                }

            if (old != current)
            {
                if (current != null)
                {
                    if (OrbLayer.orbColour.A < 255 && OrbLayer.orbColour.A < ConversionQuest.Prestige)
                    {
                        int particlesSpawned = 0;
                        for (int i = particlesSpawned; i <= ConversionQuest.Prestige; i++)
                        {
                            particlesSpawned = ConversionQuest.Prestige;
                        }
                        byte a = OrbLayer.orbColour.A;
                        OrbLayer.orbColour = Color.Lerp(old == null ? Color.White : old.Colour, current.Colour, 1f / 255f);
                        OrbLayer.orbColour.A = ++a;
                    }
                    else
                        old = current;
                }
                else
                {
                    OrbLayer.orbColour.A--;

                    if (OrbLayer.orbColour.A == 0)
                        OrbLayer.orbColour = new Color(255, 255, 255, 0);
                }
            }
        }
    }
}
*/