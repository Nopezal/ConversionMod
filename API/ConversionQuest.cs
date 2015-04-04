/*using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;
using ConversionMod;

namespace ConversionMod.API
{
    public abstract class ConversionQuest
    {
        public static Dictionary<string, ConversionQuest> quests = new Dictionary<string, ConversionQuest>();
        public static Dictionary<string, MNPC> questGivers = new Dictionary<string, NPC>();
        public static ConversionQuest quest;

        
        public static uint Prestige
        {
            get;
            set;
        }

        readonly static int PRESTIGE_MAX = 512;

        public void Update()
        {
            for (int i = 0; i < questGivers.Count; i++)
            {
                questGivers.
            }
        }

        public ConversionQuest AssignQuestTo(Player p)
        {
            
            return quest;
        }
        public static void AddQuestToGame(ModBase @base, string internalName, ConversionQuest quest)
        {
            quests.Add(@base.mod.InternalName, quest);
        }

        public static void AddQuestGiverToGame(ModBase @base, string internalName, NPC npc)
        {
            questGivers.Add(@base.mod.InternalName + ":" + internalName, npc);
        }

        public static MNPC Get(string internalName)
        {
            return questGivers[internalName];
        }

        public static ConversionQuest Get(string internalName)
        {
            return quests[internalName];
        }

        public void LoadQuestsConversion()
        {
            quests.Add("KillQuest", new KillQuest());
            quests.Add("BossQuest", new BossQuest());
            quests.Add("FetchQuest", new FetchQuest());
            quests.Add("ConsumeQuest", new ConsumeQuest());

            questGivers.Add("Abomination", );
        }
    }

    public class KillQuest : ConversionQuest
    {
        internal KillQuest()
        {
            Prestige = 20;
        }
    }
    public class BossQuest : ConversionQuest
    {
        internal BossQuest()
        {
            Prestige = 50;
        }
    }
    public class FetchQuest : ConversionQuest
    {
        internal FetchQuest()
        {
            Prestige = 25;
        }
    }
    public class ConsumeQuest : ConversionQuest
    {

    }
}
*/