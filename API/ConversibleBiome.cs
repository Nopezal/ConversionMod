using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;

namespace ConversionMod.API
{
    public abstract class ConversibleBiome
    {
        internal static Dictionary<string, ConversibleBiome> biomes = new Dictionary<string, ConversibleBiome>();

        public Biome Biome
        {
            get;
            set;
        }
        public Color Colour
        {
            get;
            set;
        }

        public static void AddToGame(ModBase @base, string internalName, ConversibleBiome biome)
        {
            biomes.Add(@base.mod.InternalName + ":" + internalName, biome);
        }
        public static ConversibleBiome Get(string internalName)
        {
            return biomes[internalName];
        }

        internal static void LoadVanilla()
        {
            biomes.Add("Vanilla:Corruption", new Corruption());
            biomes.Add("Vanilla:Crimson"   , new Crimson   ());
            biomes.Add("Vanilla:Hallow"    , new Hallow    ());
            biomes.Add("Vanilla:Jungle"    , new Jungle    ());
        }
    }

    class Corruption : ConversibleBiome
    {
        internal Corruption()
        {
            Biome  = Biome.Biomes["Corruption"];
            Colour = Color.Purple;
        }
    }
    class Crimson : ConversibleBiome
    {
        internal Crimson()
        {
            Biome  = Biome.Biomes["Crimson"];
            Colour = Color.Crimson;
        }
    }
    class Hallow : ConversibleBiome
    {
        internal Hallow()
        {
            Biome  = Biome.Biomes["Hallow"];
            Colour = Color.SkyBlue;
        }
    }
    class Jungle : ConversibleBiome
    {
        internal Jungle()
        {
            Biome  = Biome.Biomes["Jungle"];
            Colour = Color.LawnGreen;
        }
    }
}
