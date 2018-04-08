using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Double[,] Tab = new Double[200, 2];
        public Double[] Tab1 = new Double[50];
        public Decimal vr1, vr2;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.T4' table. You can move, or remove it, as needed.
            this.t4TableAdapter.Fill(this.database1DataSet2.T4);
            // TODO: This line of code loads data into the 'database1DataSet1.T3' table. You can move, or remove it, as needed.
            this.t3TableAdapter.Fill(this.database1DataSet1.T3);
            // TODO: This line of code loads data into the 'database1DataSet.T2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.database1DataSet.T2);
            // TODO: This line of code loads data into the 'database.T1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.database.T1);

        }
        public void tri(Double[] tab)
        {
            Double tmp;
            for (int j = 0; j < tab.Length - 1; j++)
            {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] < tab[i + 1])
                    {
                        tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
            }

        }
        public Decimal max(Decimal[] tab)
        {
            Decimal max = tab[0];
            for (int i = 1; i < tab.Length; i++)
                if (max < tab[i])
                    max = tab[i];
            return max;
        }
        public int maxi(Decimal[] tab)
        {
            int d = 0;
            Decimal max = tab[0];
            for (int i = 1; i < tab.Length; i++)
                if (max < tab[i])
                {
                    max = tab[i];
                    d = i;
                }

            return d;
        }
        public Decimal min(Decimal[] tab)
        {
            Decimal min = tab[0];
            for (int i = 1; i < tab.Length; i++)
                if (min > tab[i])
                    min = tab[i];
            return min;
        }
        public Boolean Test()
        {
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                Decimal a0 = Decimal.Parse(DV4.Rows[0].Cells["ai"].Value.ToString());
                if (a0 - Decimal.Parse(DV4.Rows[i].Cells["ai"].Value.ToString()) != 0)
                {
                    return false;
                }



            }
            return true;

        }
        public Decimal somT(Decimal[] tab)
        {
            Decimal som=0;
        for(int i=0;i<tab.Length;i++)
        {
                som += tab[i];
            }
            return som;
        }
        public Decimal PGCD(Decimal a, Decimal b)
        {
            Decimal temp = a % b;
            if (temp == 0)
                return b;
            return PGCD(b, temp);
        }
        public Decimal Total1(String a)
        {
            Decimal sum = 0;
            for (int i = 0; i < DV1.Rows.Count - 1; i++)
            {
                sum += Decimal.Parse(DV1.Rows[i].Cells[a].Value.ToString());
            }
            return Math.Round(sum, 2);
        }
        public Decimal Total2(String a)
        {
            Decimal sum = 0;
            for (int i = 0; i < DV2.Rows.Count - 1; i++)
            {
                sum += Decimal.Parse(DV2.Rows[i].Cells[a].Value.ToString());
            }
            return Math.Round(sum, 2);
        }
        public Decimal Total3(String a)
        {
            Decimal sum = 0;
            for (int i = 0; i < DV3.Rows.Count - 1; i++)
            {
                sum += Decimal.Parse(DV3.Rows[i].Cells[a].Value.ToString());
            }
            return Math.Round(sum, 2);
        }
        public Decimal Total4(String a)
        {
            Decimal sum = 0;
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                sum += Decimal.Parse(DV4.Rows[i].Cells[a].Value.ToString());
            }
            return Math.Round(sum, 2);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            DV1.Visible = true;
            DV2.Visible = false;
            DV3.Visible = false;
            DV4.Visible = false;
            bb1.Visible = true;
            bb2.Visible = false;
            bb3.Visible = false;
            bb4.Visible = false;
            moy1.Visible = false;
            mod1.Visible = false;
            med1.Visible = false;
            var1.Visible = false;
            eca1.Visible = false;

            moy2.Visible = false;
            mod2.Visible = false;
            med2.Visible = false;
            var2.Visible = false;
            eca2.Visible = false;

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bb1.Visible = false;
            bb2.Visible = true;
            bb3.Visible = false;
            bb4.Visible = false;
            DV1.Visible = false;
            DV2.Visible = true;
            DV3.Visible = false;
            DV4.Visible = false;
            chart2.Visible = true;
            chart1.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            moy1.Visible = false;
            mod1.Visible = false;
            med1.Visible = false;
            var1.Visible = false;
            eca1.Visible = false;

            moy2.Visible = false;
            mod2.Visible = false;
            med2.Visible = false;
            var2.Visible = false;
            eca2.Visible = false;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            chart2.Visible = false;
            chart1.Visible = false;
            chart3.Visible = true;
            chart4.Visible = false;
            bb1.Visible = false;
            bb2.Visible = false;
            bb3.Visible = true;
            bb4.Visible = false;
            DV1.Visible = false;
            DV2.Visible = false;
            DV3.Visible = true;
            DV4.Visible = false;
            moy1.Visible = true;
            mod1.Visible = true;
            med1.Visible = true;
            var1.Visible = true;
            eca1.Visible = true;

            moy2.Visible = false;
            mod2.Visible = false;
            med2.Visible = false;
            var2.Visible = false;
            eca2.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bb1.Visible = false;
            bb2.Visible = false;
            bb3.Visible = false;
            bb4.Visible = true;
            DV1.Visible = false;
            DV2.Visible = false;
            DV3.Visible = false;
            DV4.Visible = true;
            chart2.Visible = false;
            chart1.Visible = false;
            chart3.Visible = false;
            chart4.Visible = true;
            moy1.Visible = false;
            mod1.Visible = false;
            med1.Visible = false;
            var1.Visible = false;
            eca1.Visible = false;

            moy2.Visible = true;
            mod2.Visible = true;
            med2.Visible = true;
            var2.Visible = true;
            eca2.Visible = true;
        }

        private void bb1_Click(object sender, EventArgs e)
        {
            int t = (int)Total1("ni1");
            chart2.Series["B"].Points.Clear();

            Decimal[] tab = new Decimal[DV1.Rows.Count - 1];
            DV1.Rows[DV1.Rows.Count - 1].Cells["ni1"].Value = t;
            for (int i = 0; i < DV1.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    DV1.Rows[i].Cells["fi1"].Value = Math.Round((Decimal.Parse(DV1.Rows[i].Cells["ni1"].Value.ToString()) / t), 2);
                    DV1.Rows[i].Cells["fic1"].Value = Math.Round((Decimal.Parse(DV1.Rows[i].Cells["fi1"].Value.ToString())), 2);
                }
                else
                {
                    DV1.Rows[i].Cells["fi1"].Value = Math.Round((Decimal.Parse(DV1.Rows[i].Cells["ni1"].Value.ToString()) / t), 2);
                    DV1.Rows[i].Cells["fic1"].Value = Math.Round((Decimal.Parse(DV1.Rows[i].Cells["fi1"].Value.ToString())) + (Decimal.Parse(DV1.Rows[i - 1].Cells["fi1"].Value.ToString())), 2);
                }
                DV1.Rows[i].Cells["an1"].Value = Math.Round((Decimal.Parse(DV1.Rows[i].Cells["fi1"].Value.ToString()) * 360), 2);
                chart1.Series["A"].Points.AddXY(DV1.Rows[i].Cells["mi1"].Value.ToString(), Int16.Parse(DV1.Rows[i].Cells["ni1"].Value.ToString()));

            }

        }

        private void bb2_Click(object sender, EventArgs e)
        {
            int o = (int)Total2("ni2");
            chart2.Series["B"].Points.Clear();


            Decimal[] tab = new Decimal[DV2.Rows.Count - 1];
            DV2.Rows[DV2.Rows.Count - 1].Cells["ni2"].Value = o;
            for (int i = 0; i < DV2.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    DV2.Rows[i].Cells["fi2"].Value = Math.Round((Decimal.Parse(DV2.Rows[i].Cells["ni2"].Value.ToString()) / o), 2);
                    DV2.Rows[i].Cells["fic2"].Value = Math.Round((Decimal.Parse(DV2.Rows[i].Cells["fi2"].Value.ToString())), 2);
                }
                else
                {
                    DV2.Rows[i].Cells["fi2"].Value = Math.Round((Decimal.Parse(DV2.Rows[i].Cells["ni2"].Value.ToString()) / o), 2);
                    DV2.Rows[i].Cells["fic2"].Value = Math.Round((Decimal.Parse(DV2.Rows[i].Cells["fi2"].Value.ToString())) + (Decimal.Parse(DV2.Rows[i - 1].Cells["fi2"].Value.ToString())), 2);
                }
                chart2.Series["B"].Points.AddXY(DV2.Rows[i].Cells["mi2"].Value.ToString(), Int16.Parse(DV2.Rows[i].Cells["ni2"].Value.ToString()));

            }
        }

        private void DV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bb3_Click(object sender, EventArgs e)
        {
            int o = (int)Total3("ni3");
            chart3.Series["C"].Points.Clear();

            Decimal[] tab = new Decimal[DV3.Rows.Count - 1];
            DV3.Rows[DV3.Rows.Count - 1].Cells["ni3"].Value = o;
            for (int i = 0; i < DV3.Rows.Count - 1; i++)
            {
                DV3.Rows[i].Cells["mini3"].Value = Math.Round((Decimal.Parse(DV3.Rows[i].Cells["mi3"].Value.ToString())) * (Decimal.Parse(DV3.Rows[i].Cells["ni3"].Value.ToString())), 2);
                if (i == 0)
                {
                    DV3.Rows[i].Cells["fi3"].Value = Math.Round((Decimal.Parse(DV3.Rows[i].Cells["ni3"].Value.ToString()) / o), 2);
                    DV3.Rows[i].Cells["fic3"].Value = Math.Round((Decimal.Parse(DV3.Rows[i].Cells["fi3"].Value.ToString())), 2);
                }
                else
                {
                    DV3.Rows[i].Cells["fi3"].Value = Math.Round((Decimal.Parse(DV3.Rows[i].Cells["ni3"].Value.ToString()) / o), 2);
                    DV3.Rows[i].Cells["fic3"].Value = Math.Round((Decimal.Parse(DV3.Rows[i].Cells["fi3"].Value.ToString())) + (Decimal.Parse(DV3.Rows[i - 1].Cells["fi3"].Value.ToString())), 2);
                }
                chart3.Series["C"]["PixelPointWidth"] = "4";
                chart3.Series["C"].Points.AddXY(DV3.Rows[i].Cells["mi3"].Value.ToString(), Int16.Parse(DV3.Rows[i].Cells["ni3"].Value.ToString()));

            }
        }

        private void bb4_Click(object sender, EventArgs e)
        {
            int o = (int)Total4("ni4");

            Decimal[] tab = new Decimal[DV4.Rows.Count - 1];
            DV4.Rows[DV4.Rows.Count - 1].Cells["ni4"].Value = o;
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    DV4.Rows[i].Cells["fi4"].Value = Math.Round((Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString()) / o) * 100, 2);
                    DV4.Rows[i].Cells["fic4"].Value = Math.Round((Decimal.Parse(DV4.Rows[i].Cells["fi4"].Value.ToString())), 2);
                }
                else
                {
                    DV4.Rows[i].Cells["fi4"].Value = Math.Round((Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString()) / o) * 100, 2);
                    DV4.Rows[i].Cells["fic4"].Value = Math.Round((Decimal.Parse(DV4.Rows[i].Cells["fi4"].Value.ToString())) + (Decimal.Parse(DV4.Rows[i - 1].Cells["fi4"].Value.ToString())), 2);
                }
                // DV4.Rows[i].Cells["cini"].Value = Math.Round((Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString()) * Decimal.Parse(DV4.Rows[i].Cells["ci4"].Value.ToString())));
                chart4.Series["D"]["PixelPointWidth"] = "30";

                chart4.Series["D"].Points.AddXY(DV4.Rows[i].Cells["xi"].Value.ToString(), Int16.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString()));
                Tab[i, 0] = Double.Parse(DV4.Rows[i].Cells["xi"].Value.ToString());
                Tab[i, 1] = Double.Parse(DV4.Rows[i].Cells["xi1"].Value.ToString());
                DV4.Rows[i].Cells["ai"].Value = Tab[i, 1] - Tab[i, 0];
                DV4.Rows[i].Cells["ci"].Value = (Tab[i, 1] - Tab[i, 0]) / 2;
                DV4.Rows[i].Cells["cini"].Value = (Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString())) * (Decimal.Parse(DV4.Rows[i].Cells["ci"].Value.ToString()));
            }
        }

        private void DV4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            decimal m = Total3("mini3");
            int x = DV3.Rows.Count - 1;
            decimal moyenne;

            moyenne = m / x;
            //MessageBox.Show(DV1.Rows[u].Cells["mi1"].Value.ToString());
            //if (parite1() == true) { y = (int)x / 2; }
            // else if (parite1() == false) { y = (int)(x +1 )/ 2; }
            // Medianne = DV1.Rows[y].Cells["mi1"].Value.ToString();
            MessageBox.Show(moyenne.ToString());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            decimal m = Total4("cini");
            int x = DV4.Rows.Count - 1;
            decimal moyenne;

            moyenne = m / x;
            //MessageBox.Show(DV1.Rows[u].Cells["mi1"].Value.ToString());
            //if (parite1() == true) { y = (int)x / 2; }
            // else if (parite1() == false) { y = (int)(x +1 )/ 2; }
            // Medianne = DV1.Rows[y].Cells["mi1"].Value.ToString();
            MessageBox.Show(moyenne.ToString());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int a, q;
            Double medianne;
            for (int i = 0; i < DV3.Rows.Count - 1; i++)
            {
                Tab1[i] = Double.Parse(DV3.Rows[i].Cells["mi3"].Value.ToString());

            }
            q = DV3.Rows.Count - 1;

            tri(Tab1);
            a = q / 2;
            if (q % 2 != 0)
            {
                medianne = Tab1[a];
            }
            else { medianne = (Tab1[a] + Tab1[a + 1]) / 2; }

            MessageBox.Show(medianne.ToString());

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Decimal[] tab2 = new decimal[20];
            Decimal medi, N = 0, rang = Total4("ni4");
            Decimal mi = 0, mii = 0;
            Decimal r;
            r = rang / 2;
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    tab2[i] = Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString());
                }
                else
                {
                    tab2[i] = tab2[i - 1] + Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString());

                }

            }
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                if (r >= tab2[i])
                {
                    mi = Decimal.Parse(DV4.Rows[i].Cells["xi"].Value.ToString());
                    mii = Decimal.Parse(DV4.Rows[i].Cells["xi1"].Value.ToString());
                    if (i == 0) { N = tab2[i]; }
                    else
                    {
                        N = tab2[i - 1];
                    }
                    break;
                }
            }
            medi = mi + (mii - mi) * ((r - N) / (rang - N));
            MessageBox.Show(medi.ToString());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Decimal[] Taba = new Decimal[DV4.Rows.Count - 1];
            Decimal[] Tabai0 = new Decimal[DV4.Rows.Count - 1];
            Decimal[] Tabaf = new Decimal[DV4.Rows.Count - 1];

            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                Taba[i] = Decimal.Parse(DV4.Rows[i].Cells["ai"].Value.ToString()); ;
            }
            Decimal pd = PGCD(max(Taba), min(Taba));
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                Tabai0[i] = Decimal.Parse(DV4.Rows[i].Cells["ai"].Value.ToString()) / pd;
            }
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                Tabaf[i] = Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString()) / Tabai0[i];
            }


            if (!Test())
            {
                // MessageBox.Show(Test().ToString());

            }
            else
            {
                //MessageBox.Show(Test().ToString());

            }


            Decimal zi = Decimal.Parse(DV4.Rows[maxi(Tabaf)].Cells["xi"].Value.ToString());
            Decimal z = max(Tabaf);
            Decimal zz = Tabaf[maxi(Tabaf) - 1];
            Decimal zx = Tabaf[maxi(Tabaf) + 1];
            Decimal a = Decimal.Parse(DV4.Rows[maxi(Tabaf)].Cells["ai"].Value.ToString());
            Decimal mode = zi + ((z - zz) / ((z - zz) + (z - zx))) * a;
            MessageBox.Show(mode.ToString());


        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            int d;
            Decimal[] Tabaa = new Decimal[DV3.Rows.Count - 1];
            for (int i = 0; i < DV3.Rows.Count - 1; i++)
            {
                Tabaa[i] = Decimal.Parse(DV3.Rows[i].Cells["ni3"].Value.ToString()); ;
            }
            d = maxi(Tabaa);
            Decimal mode = Decimal.Parse(DV3.Rows[maxi(Tabaa)].Cells["mi3"].Value.ToString());
            MessageBox.Show(mode.ToString());

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Double eq1 = Math.Sqrt((Double)vr1);
            MessageBox.Show(eq1.ToString());

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
           
           Decimal som,vr,xbar = Total4("cini") / (Total4("ni4"));
            Decimal[] Tabaa = new Decimal[DV4.Rows.Count - 1];
            for (int i = 0; i < DV4.Rows.Count - 1; i++)
            {
                Tabaa[i] = (Decimal.Parse(DV4.Rows[i].Cells["ni4"].Value.ToString())*((Decimal.Parse(DV4.Rows[i].Cells["ci"].Value.ToString())-xbar)* (Decimal.Parse(DV4.Rows[i].Cells["ci"].Value.ToString()) - xbar)));
            }
            vr = somT(Tabaa) / Total4("ni4");
            vr2 = vr;
            MessageBox.Show(vr.ToString());


        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Double eq2 = Math.Sqrt((Double)vr2);
            MessageBox.Show(eq2.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Decimal vr,somt, xbar = Total3("mi3")/ DV3.Rows.Count - 1;
            Decimal[] taba= new Decimal[DV3.Rows.Count - 1];
            for (int i = 0; i < DV3.Rows.Count - 1; i++)
            {
                taba[i] = (Decimal.Parse(DV3.Rows[i].Cells["mi3"].Value.ToString()) - xbar)* (Decimal.Parse(DV3.Rows[i].Cells["mi3"].Value.ToString()) - xbar);
            }
            somt = somT(taba);
            vr = somt / DV3.Rows.Count - 1;
            vr1 = vr;
            MessageBox.Show(vr.ToString());


        }
    }
}
