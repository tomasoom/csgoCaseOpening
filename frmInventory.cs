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
    public partial class frmInventory : Form
    {
        public List<Chroma2> drops;
        public List<Knifes> facas;

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            frmCaseOpening frm = new frmCaseOpening();
            frm.drops = this.drops;
            frm.facas = this.facas;

            foreach (var drop in drops)
            {
                var row = new string[] { drop.Arma, drop.Colorr, drop.Estado, drop.Desgaste.ToString(), drop.StatTrak.ToString() };
                var lvi = new ListViewItem(row);

                lvi.Tag = drop;

                lvInventory.Items.Add(lvi);
            }
        }

        private void btnKnifes_Click(object sender, EventArgs e)
        {
            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmKnifes))
                {
                    fr.Activate();
                    return;
                }
            frmKnifes frm = new frmKnifes();
            frm.facas = this.facas;

            frm.Show(this);
        }

        private void lvInventory_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lvInventory_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lvInventory_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
