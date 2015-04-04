/*using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

using Terraria;
using TAPI;

using ConversionMod;
using ConversionMod.NPCs;
using ConversionMod.API;

namespace ConversionMod
{
    public class MNPC : ModNPC
    {
        public static bool coBinderActive;
        public static bool haBinderActive;
        public static bool juBinderActive;
        public static bool crBinderActive;

        public  virtual void AssignQuest(ConversionQuest quest)
        {
            int r = Main.rand.Next(0, 4);
            int count = Main.rand.Next(5, 20); //count to kill
            int acces; //variable for storing all kinds of things.
            if (quest == new KillQuest())
            {
                acces = Main.rand.Next(1, 378);
                if (this.Equals(new CorruptionBinder()))
                {
                    switch (r)
                    {
                        case 0:
                            Main.npcChatText = "We recently got some new enemies at hands.  Go show them who's boss. Kill " + count + NPCDef.byType[acces].name + "s.";
                            break;
                            
                        case 1:
                            Main.npcChatText = "Those hallowed chumps think they can take down the Corruption. not on my watch though. To teach them a lesson, kill " + count + NPCDef.byType[acces].name + "s.";
                            break;

                        case 2:
                            Main.npcChatText = "Just frenzy " + count + NPCDef.byType[acces].name + "s up. There's no reason, I just don't like " + NPCDef.byType[acces].name + "s.";
                            break;

                        case 3:
                            Main.npcChatText = "";
                            break;

                        case 4:
                            Main.npcChatText = "";
                            break;
                    }
                    if(NPCDef.byType[acces].CheckActive())


                }
            }
        }
    }
}
*/