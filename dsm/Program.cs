using System;
using System.Windows.Forms;

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
