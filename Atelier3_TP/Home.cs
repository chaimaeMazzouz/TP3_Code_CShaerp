using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier3_TP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void passagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* if (this.ActiveMdiChild != null)
             {
                 this.ActiveMdiChild.Close();
                 Passager fr = new Passager();
                 fr.MdiParent = this;
                 fr.Show();
             }*/
            Passager fr = new Passager();
            fr.MdiParent = this;
            fr.Show();
        }

        private void piloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* if (this.ActiveMdiChild != null)
             {
                 this.ActiveMdiChild.Close();
                 Pilote fr = new Pilote();
                 fr.MdiParent = this;
                 fr.Show();
             }
            */
            Pilote fr = new Pilote();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
