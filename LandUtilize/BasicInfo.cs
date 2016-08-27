using ESRI.ArcGIS.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandUtilize
{
   public class BasicInfo:MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;

        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;

        public BasicInfo()
        {
              string str = @"..\Data\Image\LandUtilize\2.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;}

        #region ICommand 成员

        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "基本状况"; }
        }

        public string Category
        {
            get { return "LandMenu"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "基本状况"; }
        }

        public string Name
        {
            get { return "BasicInfo"; }
        }

        public void OnClick()
        {
            cmd.OnClick();
        }

        public void OnCreate(MyPluginEngine.IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                cmd = new ControlsOpenDocCommandClass();
               
                cmd.OnCreate(this.hk.PageLayoutControl);
            }
        }

        public string Tooltip
        {
            get { return "基本状况"; }
        }

        #endregion
    }
    }

