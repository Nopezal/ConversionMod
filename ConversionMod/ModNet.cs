using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Terraria;
using TAPI;

namespace ConversionMod
{
    class ModNet : TAPI.ModNet
    {
        public override void NetReceive(BinBuffer bb, int messageID)
        {
            base.NetReceive(bb, messageID);
        }
    }
}
