using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGOCaseOpening
{
    public partial class frmKnifes : Form
    {
        public List<Knifes> facas;
        public frmKnifes()
        {
            InitializeComponent();
        }

        private void frmKnifes_Load(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            frm.facas = this.facas;
            

            foreach (var faca in facas)
            {
                var row = new string[] { faca.Arma, faca.Colorr, faca.Estado, faca.Desgaste.ToString(), faca.StatTrak.ToString() };
                var lvi = new ListViewItem(row);

                lvi.Tag = faca;

                lvInventory.Items.Add(lvi);
            }
        }
    }
}
