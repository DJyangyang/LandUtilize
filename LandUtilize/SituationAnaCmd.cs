using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandUtilize
{
    class SituationAnaCmd : ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;
        private ICommand cmd = null;
        SituationAna pSituationAna;
        public SituationAnaCmd()
        {
            string str = @"..\Data\Image\LandUtilize\1.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;

        }
        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "情景分析"; }
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
            get { return "情景分析"; }
        }

        public string Name
        {
            get { return "SituationAnaCmd"; }
        }

        public void OnClick()
        {
            System.Windows.Forms.MessageBox.Show("模块正在开发中！");
            //pSituationAna = new SituationAna();
            //pSituationAna.ShowDialog();
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pSituationAna = new SituationAna();
                pSituationAna.Visible=false;
            }
        }

        public string Tooltip
        {
            get { return "情景分析"; }
        }
    }
}