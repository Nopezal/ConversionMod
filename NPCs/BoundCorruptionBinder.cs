/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

using ConversionMod;
using ConversionMod.API;
using ConversionMod.NPCs;

namespace ConversionMod.NPCs
{
    public class BoundCorruptionBinder : MNPC
    {
        public override bool CanSpawn(int x, int y, int type, Player spawnedOn)
        {
            Stopwatch sw = new Stopwatch();
            if (!this.npc.active && !MNPC.coBinderActive && Main.hardMode)
            {
                sw.Start();
                return (sw.ElapsedTicks == Main.rand.Next(500, 2000) && ConversibleBiome.biomes["Vanilla:Corruption"].Biome.Check(Main.player[Main.myPlayer]));
            }
            else return false;
        }


        public override void OnSpawn()
        {
            Main.NewText("You feel a chilling screech from deep in the corruption...", Color.Purple);
        }
    }
}
*/