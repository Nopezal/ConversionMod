using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;
using ConversionMod.UI;

namespace ConversionMod
{
    class ModPlayer : TAPI.ModPlayer
    {
        static int a = 0, r = 0, b = 0, g = 0, extraTimer = 0;
        static bool changedBiome = false;

        public static void CheckBiome(string biomeName, Color customColour)
        {
            if (Biome.Biomes[biomeName].Check(Main.localPlayer))
            {

            }
        }
        public override void MidUpdate()
        {
            OrbLayer.orbColour = new Color(r, g, b, a);

            // WARNING! REALLY MESSY AND WEIRD CODE AHEAD! FULL OF MATHS WICH PROBABLY COULD HAVE BEEN DONE MORE EFFICIENTLY!
            // WARNING!
            // Okay, you've been warned enough.

            // try not to hardcode this | Yeah I'm sorry
            //       -Poro              |     -Nopel
            bool oldChangedBiome = changedBiome;
            if (!Biome.Biomes["Forest"].Check(Main.localPlayer))
            {
                if (++extraTimer == 60)
                {
                    if (Biome.Biomes["Corruption"].Check(Main.localPlayer))
                    {
                        changedBiome = true;
                        if (a < 255)
                            a++;
                        else if (r < 255 && b < 255 && a == 255)
                        {
                            r++;
                            b++;
                            extraTimer++;
                        }
                    }
                    else if (Biome.Biomes["Hallow"].Check(Main.localPlayer))
                    {
                        changedBiome = true;
                        if (a < 255)
                            a++;
                        else if (r < 173 && g < 216 && b < 230 && a == 255)
                        {
                            r++;
                            b++;
                        }
                    }
                    else if (Biome.Biomes["Crimson"].Check(Main.localPlayer))
                    {
                        changedBiome = true;
                        if (a < 255)
                            a++;
                        else if (r < 220 && g < 60 && b < 20 && a == 255)
                        {
                            r++;
                            b++;
                        }
                    }
                    else if (Biome.Biomes["Jungle"].Check(Main.localPlayer))
                    {
                        changedBiome = true;
                        if (a < 255)
                            a++;
                        else if (g < 100 && a == 255)
                        {
                            r++;
                            b++;
                        }
                    }
                    else
                        changedBiome ^= oldChangedBiome;

                    extraTimer = 0;
                }
            }
        }
    }
}
