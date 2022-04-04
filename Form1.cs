using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;

namespace CSGOCaseOpening
{
    
    public partial class frmCaseOpening : Form
    {
        public Random randomArma = new Random();
        public Random randomStatTrak = new Random();
        public Random randomEstado = new Random();
        public Random randomFloat = new Random();

        public List<Chroma2> drops = new List<Chroma2>();
        public List<Knifes> facas = new List<Knifes>();

        public int blueCounter = 0;
        public int purpleCounter = 0;
        public int pinkCounter = 0;
        public int redCounter = 0;
        public int knifeCounter = 0;
        public int statTrakCounter = 0;
        public string cor;

        public int sessionOpenedCases = 0;
        public double precoCompra;
        public double dinheiroGasto;

        int i = 0;
        int nArma = 0;


        public frmCaseOpening()
        {
            InitializeComponent();
        }

        private bool CheckarStatTrak()
        {
            int b;
            bool flagStatStrak;


            b = randomStatTrak.Next(1, 11);
            if (b == 1)
            {
                flagStatStrak = true;
                chkStatTrak.Checked = true;
                statTrakCounter++;
                txtStatTrak.Text = statTrakCounter.ToString();


            }

            else
            {
                flagStatStrak = false;
                chkStatTrak.Checked = false;
            }

            return flagStatStrak;
        }

        private string CheckarEstado(double desgaste)
        {
            string s;
            if (desgaste >= 0.44)
            {
                s = "Battle-Scarred";
                txtEstado.Text = s;
            }
            else if (desgaste < 0.44 && desgaste >= 0.37)
            {
                s = "Well Worn";
                txtEstado.Text = s;
            }
            else if (desgaste < 0.37 && desgaste >= 0.15)
            {
                s = "Field Tested";
                txtEstado.Text = s;
            }
            else if (desgaste < 0.15 && desgaste >= 0.07)
            {
                s = "Minimal Wear";
                txtEstado.Text = s;
            }
            else
            {
                s = "Factory New";
                txtEstado.Text = s;
            }
            return s;
        }


        private string CheckarEstado2()
        {

        
            
            int c;
            string s;
            int d = randomEstado.Next(1, 6);
            if (d == 1)
            {
                s = "Battle Scarred";
                txtEstado.Text = s;
            }
            else if (d == 2)
            {
                s = "Well Worn";
                txtEstado.Text = s;
            }
            else if (d == 3)
            {
                s = "Field Tested";
                txtEstado.Text = s;
            }
            else if (d == 4)
            {
                s = "Minimal Wear";
                txtEstado.Text = s;
            }
            else
            {
                s = "Factory New";
                txtEstado.Text = s;
            }

            txtEstado.Text = s;

            return s;
            
        }

        private double CheckarFloat()
        {
            double k;
            Random desgaste = new Random();
            k = desgaste.NextDouble();
            txtFloat.Text = k.ToString();
            return k;
        }


        private double CheckarFloat2(string str)
        {
               double k;
               float k1;
            

               if (str == "Battle Scarred")
               {
                   //return random.NextDouble() * (maximum - minimum) + minimum;
                   k = randomFloat.NextDouble() * (1.00 - 0.44) + 0.44;
                   //txtFloat.Text = k.ToString();

               }
               else if (str == "Well Worn")
               {
                   //return random.NextDouble() * (maximum - minimum) + minimum;
                   k = randomFloat.NextDouble() * (0.44 - 0.37) + 0.37;


               }
               else if (str == "Field Tested")
               {
                   //return random.NextDouble() * (maximum - minimum) + minimum;
                   k = randomFloat.NextDouble() * (0.37 - 0.15) + 0.15;


               }
               else if (str == "Minimal Wear")
               {
                   //return random.NextDouble() * (maximum - minimum) + minimum;
                   k = randomFloat.NextDouble() * (0.15 - 0.07) + 0.07;


               }
               else
               {
                   //return random.NextDouble() * (maximum - minimum) + minimum;
                   k = randomFloat.NextDouble() * (0.07 - 0) + 0;


               }
               txtFloat.Text = k.ToString();
               return k;
               
        }
        

        private string DropArma()
        {

            int blue = 2326;
            int purple = 608;
            int pink = 118;
            int red = 33;
            int yellow = 12;


            int openedCases = (blue + purple + pink + red + yellow);






            int maximo = openedCases + 1;
            int g;


            int drops;


            Random blueGun = new Random();
            Random purpleGun = new Random();
            Random pinkGun = new Random();
            Random redGun = new Random();
            Random yellowGun = new Random();


            g = randomArma.Next(1, maximo);
            string gun;


            if (g <= 2326)
            {
                drops = blueGun.Next(1, 7);
                switch (drops)
                {
                    case 1:
                        gun = "Ak-47 | Elite Build";

                        break;
                    case 2:
                        gun = "MP7 | Armor Core";
                        break;
                    case 3:
                        gun = "Desert Eagle | Bronze Deco";
                        break;
                    case 4:
                        gun = "P250 | Valence";
                        break;
                    case 5:
                        gun = "Negev | Man-o'-War";
                        break;
                    case 6:
                        gun = "Sawed Off | Origami";
                        break;
                    default:
                        gun = "N/A";
                        break;


                }

                this.BackColor = Color.Cyan;
                cor = "Blue";
                blueCounter++;
                txtBlueCounter.Text = blueCounter.ToString();
            }

            else if (g > 2326 && g <= 2934)
            {
                drops = purpleGun.Next(1, 5);
                switch (drops)
                {

                    case 1:
                        gun = "AWP | Worm God";
                        break;
                    case 2:
                        gun = "MAG-7 | Heat";
                        break;
                    case 3:
                        gun = "CZ75-Auto | Pole Position";
                        break;
                    case 4:
                        gun = "UMP-45 | Grand Prix";
                        break;
                    default:
                        gun = "N/A";
                        break;
                }

                this.BackColor = Color.Purple;
                cor = "Purple";
                purpleCounter++;
                txtPurpleCounter.Text = purpleCounter.ToString();
            }

            else if (g > 2934 && g <= 3052)
            {
                drops = pinkGun.Next(1, 4);
                switch (drops)
                {

                    case 1:
                        gun = "Five-Seven | Monkey Business";
                        break;
                    case 2:
                        gun = "Galil Ar | Eco";
                        break;
                    case 3:
                        gun = "Famas | Djinn";
                        break;
                    default:
                        gun = "N/A";
                        break;
                }

                this.BackColor = Color.Magenta;
                cor = "Pink";
                pinkCounter++;
                txtPinkCounter.Text = pinkCounter.ToString();
            }

            else if (g > 3052 && g <= 3085)
            {
                drops = redGun.Next(1, 3);
                switch (drops)
                {

                    case 1:
                        gun = "M4A1-S | Hyper Beast";
                        break;
                    case 2:
                        gun = "MAC-10 | Neon Rider";
                        break;
                    default:
                        gun = "N/A";
                        break;
                }

                this.BackColor = Color.Red;
                cor = "Red";
                redCounter++;
                txtRedCounter.Text = redCounter.ToString();
                MessageBox.Show("Good Drop! Continue wasting your money.");
            }

            else if (g > 3085 && g <= maximo)
            {
                drops = yellowGun.Next(1, 31);
                switch (drops)
                {

                    case 1:
                        gun = "Bayonet | Marble Fade";
                        break;
                    case 2:
                        gun = "Bayonet | Doppler";
                        break;
                    case 3:
                        gun = "Bayonet | Tiger Tooth";
                        break;
                    case 4:
                        gun = "Bayonet | Rust Coat";
                        break;
                    case 5:
                        gun = "Bayonet | Damascus Steel";
                        break;
                    case 6:
                        gun = "Bayonet | Ultraviolet";
                        break;
                    case 7:
                        gun = "Flip Knife | Doppler";
                        break;
                    case 8:
                        gun = "Flip Knife | Marble Fade";
                        break;
                    case 9:
                        gun = "Flip Knife | Tiger Tooth";
                        break;
                    case 10:
                        gun = "Flip Knife | Ultraviolet";
                        break;
                    case 11:
                        gun = "Flip Knife | Damascus Steel";
                        break;
                    case 12:
                        gun = "Flip Knife | Rust Coat";
                        break;
                    case 13:
                        gun = "Gut Knife | Doppler";
                        break;
                    case 14:
                        gun = "Gut Knife | Marble Fade";
                        break;
                    case 15:
                        gun = "Gut Knife | Tiger Tooth";
                        break;
                    case 16:
                        gun = "Gut Knife | Ultraviolet";
                        break;
                    case 17:
                        gun = "Gut Knife | Damascus Steel";
                        break;
                    case 18:
                        gun = "Gut Knife | Rust Coat";
                        break;
                    case 19:
                        gun = "Karambit | Marble Fade";
                        break;
                    case 20:
                        gun = "Karambit | Tiger Tooth";
                        break;
                    case 21:
                        gun = "Karambit | Doppler";
                        break;
                    case 22:
                        gun = "Karambit | Damascus Steel";
                        break;
                    case 23:
                        gun = "Karambit | Ultraviolet";
                        break;
                    case 24:
                        gun = "Karambit | Rust Coat";
                        break;
                    case 25:
                        gun = "M9 Bayonet | Marble Fade";
                        break;
                    case 26:
                        gun = "MAC-10 | Neon Rider";
                        break;
                    case 27:
                        gun = "M9 Bayonet | Tiger Tooth";
                        break;
                    case 28:
                        gun = "M9 Bayonet | Doppler";
                        break;
                    case 29:
                        gun = "M9 Bayonet | Rust Coat";
                        break;
                    case 30:
                        gun = "M9 Bayonet | Ultraviolet";
                        break;
                    default:
                        gun = "N/A";
                        break;
                }
                
                this.BackColor = Color.Yellow;
                cor = "Yellow";
                knifeCounter++;
                txtKnifeCounter.Text = knifeCounter.ToString();
                MessageBox.Show("AMAZING DROP! A BRAND NEW KNIFE FOR YA!");
            }
            else
            {
                gun = "N/A";

            }
            txtArma.Text = gun;
            return gun;
        }

        private double Gastos()
        {
            double gastos = 0;
            double precoCaixa = 0.08;
            double precoChave = 2.30;

            gastos = (precoCaixa + precoChave);
            return gastos;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            sessionOpenedCases++;
            nArma++;
            txtTotalCases.Text = sessionOpenedCases.ToString();

            Chroma2 novo = new Chroma2();
            novo.Arma = DropArma();
            novo.Colorr = cor;
            novo.Estado = CheckarEstado2();
            novo.Desgaste = CheckarFloat2(novo.Estado);
            
            novo.StatTrak = CheckarStatTrak();



            drops.Add(novo);

            Knifes facass = new Knifes();
            if (novo.Colorr == "Yellow")
            {
                
                facass.Arma = txtArma.Text;
                facass.Colorr = "Yellow";
                facass.Desgaste = Convert.ToDouble(txtFloat.Text);
                facass.Estado = txtEstado.Text;
                facass.StatTrak = CheckarStatTrak();
                facas.Add(facass);
        }
            


        precoCompra = Gastos();

            dinheiroGasto = dinheiroGasto + precoCompra;

            txtGastos.Text = dinheiroGasto.ToString();
         


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog(this) == DialogResult.OK)
            {
                string filename = sfdExport.FileName;
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                StreamWriter sw = new StreamWriter(filename);
                XmlSerializer s = new XmlSerializer(drops.GetType());
                s.Serialize(sw, drops);
                sw.Close();
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmInventory))
                {
                    fr.Activate();
                    return;
                }
            frmInventory frm = new frmInventory();
            frm.drops = this.drops;
            frm.facas = this.facas;
            
            frm.Show(this);
        }
    }
}