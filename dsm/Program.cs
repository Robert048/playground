using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


//spam

namespace dsm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PlayGround());
        }
    }

    public class MySR : ToolStripSystemRenderer
    {
        public MySR() 
        {
 
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.Name == "toolStrip1")
            {
                base.OnRenderToolStripBorder(e);
            }
        }
    }
}
