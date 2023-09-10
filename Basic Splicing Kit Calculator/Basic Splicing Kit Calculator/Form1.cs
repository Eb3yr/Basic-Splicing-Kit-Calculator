using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Splicing_Kit_Calculator
{

    public partial class Form1 : Form
    {
        double profit;
        int noBought;
        public Form1()
        {
            InitializeComponent();
            noBought = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NoPacksBought_TextChanged(object sender, EventArgs e)
        {
            try
            {
                noBought = int.Parse(NoPacksBought.Text);
            }
            catch (Exception)
            {
                //Stop doing a bad
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                profit = 0;
                RockSell.Text = (noBought * 10 / double.Parse(RockPrice.Text)).ToString();
                WoodSell.Text = (noBought * 1.25 / int.Parse(WoodPrice.Text)).ToString();
                GrassSell.Text = (noBought * 1.25 / int.Parse(GrassPrice.Text)).ToString();
                DoorSell.Text = (noBought * 1.25 / int.Parse(DoorPrice.Text)).ToString();
                SignSell.Text = (noBought * 1.25 / int.Parse(SignPrice.Text)).ToString();
                GlassSell.Text = (noBought * 1.25 / int.Parse(GlassPrice.Text)).ToString();
                CaveSell.Text = (noBought * 1.25 / int.Parse(CavePrice.Text)).ToString();
                MagmaSell.Text = (noBought * 1.25 / int.Parse(MagmaPrice.Text)).ToString();
                MartianSell.Text = (noBought * 1.25 / int.Parse(MartianPrice.Text)).ToString();

                RockNum.Text = (noBought * 10).ToString();
                WoodNum.Text = (noBought * 1.25).ToString();
                GrassNum.Text = (noBought * 1.25).ToString();
                DoorNum.Text = (noBought * 1.25).ToString();
                SignNum.Text = (noBought * 1.25).ToString();
                GlassNum.Text = (noBought * 1.25).ToString();
                CaveNum.Text = (noBought * 1.25).ToString();
                MagmaNum.Text = (noBought * 1.25).ToString();
                MartianNum.Text = (noBought * 1.25).ToString();

                GemsSpent.Text = "Gems Spent: " + (noBought * int.Parse(PackPrice.Text));

                profit += double.Parse(RockSell.Text);
                profit += double.Parse(WoodSell.Text);
                profit += double.Parse(GrassSell.Text);
                profit += double.Parse(DoorSell.Text);
                profit += double.Parse(SignSell.Text);
                profit += double.Parse(GlassSell.Text);
                profit += double.Parse(CaveSell.Text);
                profit += double.Parse(MagmaSell.Text);
                profit += double.Parse(MartianSell.Text);

                Profit.Text = "Profit: " + profit + " WLs";
                GemsPerWL.Text = "Gems Per WL: " + (noBought * int.Parse(PackPrice.Text) / profit);
            }
            catch (Exception)
            {
                //Stop doing a bad
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
