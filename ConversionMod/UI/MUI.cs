using System;
using System.Collections.Generic;
using System.Linq;
using TAPI;

namespace ConversionMod.UI
{
    public class MUI : ModInterface
    {
        public override void ModifyInterfaceLayerList(List<InterfaceLayer> list)
        {
            base.ModifyInterfaceLayerList(list);

            InterfaceLayer.Add(list, new OrbLayer(modBase), InterfaceLayer.LayerBars, true);
        }
    }
}
