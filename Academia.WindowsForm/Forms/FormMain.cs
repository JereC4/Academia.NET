using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.WindowsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            using (var login = new FormLogin())
            {
                if (login.ShowDialog(this) != DialogResult.OK)
                {
                    this.Close(); 
                }
            }
        }

    }
}
