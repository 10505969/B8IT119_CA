using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8IT119_CA
{
    public class CustomMenuStrip : System.Windows.Forms.MenuStrip
    {
        private System.Windows.Forms.ToolStripMenuItem ExitOption;

        public void InitializeComponent()
        {
            this.ExitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // ExitOption
            // 
            this.ExitOption.Name = "ExitOption";
            this.ExitOption.Size = new System.Drawing.Size(38, 20);
            this.ExitOption.Text = "Exit";
            // 
            // CustomMenuStrip
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitOption});
            this.ResumeLayout(false);

        }
        public CustomMenuStrip()
        {
            InitializeComponent();
        }
    }
}
