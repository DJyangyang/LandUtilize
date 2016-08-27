using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandUtilize
{
    class LandMenu :IMenuDef
    {
        public string Caption
        {
            get { return "土地利用"; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "LandUtilize.BasicInfo";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "LandUtilize.SituationAnaCmd";
                    itemDef.Group = false;
                    break;
                default:
                    break;
            }
        }

        public long ItemCount
        {
            get { return 2; }
        }

        public string Name
        {
            get { return "LandMenu"; }
        }
    }
}
