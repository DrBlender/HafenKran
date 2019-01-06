using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsKranPerfekt
{
    public partial class Form1 : Form
    {
        int BC { get; set; }
        int KK { get; set; }
        bool box1 = false;
        public Form1()
        {
            InitializeComponent();
            btnGreifen.Enabled = false;
            btnHackenDOWN.Enabled = false;
            btnHakenDOWNLEFT.Enabled = false;
            btnHakenDOWNRIGHT.Enabled = false;
            btnHakenLEFT.Enabled = false;
            btnHakenRIGHT.Enabled = false;
            btnHakenUP.Enabled = false;
            btnHakenUPLEFT.Enabled = false;
            btnHakenUR.Enabled = false;
            btnLösen.Enabled = false;
            btnMLEFT.Enabled = false;
            btnMRIGHT.Enabled = false;
            btnSLinks.Enabled = false;
            btnSRechts.Enabled = false;
            btnSTOP1.Enabled = false;
            btnSTOP2.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            lblAnzeige.Visible = false;
            lblRader.BackColor = System.Drawing.Color.Transparent;
            lblHaken.BackColor = System.Drawing.Color.Transparent;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGreifen.Enabled = true;
            btnHackenDOWN.Enabled = true;
            btnHakenDOWNLEFT.Enabled = true;
            btnHakenDOWNRIGHT.Enabled = true;
            btnHakenLEFT.Enabled = true;
            btnHakenRIGHT.Enabled = true;
            btnHakenUP.Enabled = true;
            btnHakenUPLEFT.Enabled = true;
            btnHakenUR.Enabled = true;
            btnLösen.Enabled = true;
            btnMLEFT.Enabled = true;
            btnMRIGHT.Enabled = true;
            btnSLinks.Enabled = true;
            btnSRechts.Enabled = false;
            btnSTOP1.Enabled = true;
            btnSTOP2.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnClose.Enabled = false;

            lblAnzeige.Visible = true;//Anzeige
            lblAnzeige.Text = "Motor wurde gestartet";
            int grosse = lblAnzeige.Width / 2;
            lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
            timerAnzeige.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnGreifen.Enabled = false;
            btnHackenDOWN.Enabled = false;
            btnHakenDOWNLEFT.Enabled = false;
            btnHakenDOWNRIGHT.Enabled = false;
            btnHakenLEFT.Enabled = false;
            btnHakenRIGHT.Enabled = false;
            btnHakenUP.Enabled = false;
            btnHakenUPLEFT.Enabled = false;
            btnHakenUR.Enabled = false;
            btnLösen.Enabled = false;
            btnMLEFT.Enabled = false;
            btnMRIGHT.Enabled = false;
            btnSLinks.Enabled = false;
            btnSRechts.Enabled = false;
            btnSTOP1.Enabled = false;
            btnSTOP2.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnClose.Enabled = true;

            lblAnzeige.Visible = true;//Anzeige
            lblAnzeige.Text = "Motor wurde gestoppt";
            int grosse = lblAnzeige.Width / 2;
            lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
            timerAnzeige.Enabled = true;
        }

        private void timerAnzeige_Tick(object sender, EventArgs e)
        {
            lblAnzeige.Visible = false;
            timerAnzeige.Enabled = false;
            lblAnzeige.Location = new Point(218, lblAnzeige.Location.Y);
        }

        private void btnHackenDOWN_Click(object sender, EventArgs e)
        {
            timerHakenRunter.Enabled = true;
            timerHakenRauf.Enabled = false;
            timerHL.Enabled = false;
            timerHR.Enabled = false;
        }

        private void timerHakenRunter_Tick(object sender, EventArgs e) //Haken runter
        {
            if (lblHaken.Location.Y < 546)
            {
                pnlSchnur.Height += 1;
                lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y + 1);
            }

            if (lblHaken.Location.Y == 546)
            {
                timerHakenRunter.Enabled = false;
                lblAnzeige.Text = "Haken Maximal herrausgefahren";
                int grosse = lblAnzeige.Width / 2;
                lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
                lblAnzeige.Visible = true;
                timerAnzeige.Enabled = true;
            }
            if (box1)
            {
                pnlBox1.Location = new Point(pnlBox1.Location.X, pnlBox1.Location.Y + 1);
                lblO1.Location = new Point(lblO1.Location.X, lblO1.Location.Y + 1);
            }

        }

        private void btnSTOP2_Click(object sender, EventArgs e)
        {
            timerHakenRunter.Enabled = false;
            timerHakenRauf.Enabled = false;
            timerHL.Enabled = false;
            timerHR.Enabled = false;
        }

        private void btnHakenUP_Click(object sender, EventArgs e)
        {
            timerHakenRauf.Enabled = true;
            timerHakenRunter.Enabled = false;
            timerHL.Enabled = false;
            timerHR.Enabled = false;
        }

        private void timerHakenRauf_Tick(object sender, EventArgs e) //Haken rauf
        {
            if (pnlSchnur.Height > 5)
            {
                pnlSchnur.Height -= 1;
                lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y - 1);
            }
            if (pnlSchnur.Height == 5)
            {
                timerHakenRauf.Enabled = false;
                lblAnzeige.Text = "Haken Maximal reingefahren";
                int grosse = lblAnzeige.Width / 2;
                lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
                lblAnzeige.Visible = true;
                timerAnzeige.Enabled = true;
            }
            if (box1)
            {
                pnlBox1.Location = new Point(pnlBox1.Location.X, pnlBox1.Location.Y - 1);
                lblO1.Location = new Point(lblO1.Location.X, lblO1.Location.Y - 1);
            }
        }

        private void btnHakenRIGHT_Click(object sender, EventArgs e)
        {
            timerHR.Enabled = true;
            timerHL.Enabled = false;
            timerHakenRauf.Enabled = false;
            timerHakenRunter.Enabled = false;
        }

        private void timerHR_Tick(object sender, EventArgs e) //Haken rechts
        {

            if (pnlArm.Location.X > pnlMast.Location.X) //Arm auf rechter Seite
            {
                if (pnlSchnur.Location.X >= pnlArm.Location.X + 79 && pnlSchnur.Location.X <= pnlArm.Location.X + 211)
                {
                    pnlSchnur.Location = new Point(pnlSchnur.Location.X + 1, pnlSchnur.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);
                }
                else
                {
                    timerHR.Enabled = false;
                }

                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X + 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X + 1, lblO1.Location.Y);
                }
            }

            if (pnlArm.Location.X < pnlMast.Location.X) //Haken auf der Linken Seite
            {
                if (pnlSchnur.Location.X >= pnlArm.Location.X + 12 && pnlSchnur.Location.X <= pnlArm.Location.X + 140)
                {
                    pnlSchnur.Location = new Point(pnlSchnur.Location.X + 1, pnlSchnur.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);
                }
                else
                {
                    timerHR.Enabled = false;
                }
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X + 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X + 1, lblO1.Location.Y);
                }


            }



        }

        private void btnHakenLEFT_Click(object sender, EventArgs e)
        {
            timerHL.Enabled = true;
            timerHakenRunter.Enabled = false;
            timerHakenRauf.Enabled = false;
            timerHR.Enabled = false;
        }

        private void timerHL_Tick(object sender, EventArgs e)//Haken links
        {
            if (pnlArm.Location.X > pnlMast.Location.X) //Arm auf rechter Seite
            {

                if (pnlSchnur.Location.X >= pnlArm.Location.X + 80 && pnlSchnur.Location.X <= pnlArm.Location.X + 212)
                {
                    pnlSchnur.Location = new Point(pnlSchnur.Location.X - 1, pnlSchnur.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);
                }
                else
                {
                    timerHL.Enabled = false;
                }

                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X - 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X - 1, lblO1.Location.Y);
                }
            }

            if (pnlArm.Location.X < pnlMast.Location.X) //Haken auf der Linken Seite
            {
                if (pnlSchnur.Location.X >= pnlArm.Location.X + 13 && pnlSchnur.Location.X <= pnlArm.Location.X + 150)
                {
                    pnlSchnur.Location = new Point(pnlSchnur.Location.X - 1, pnlSchnur.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);
                }
                else
                {
                    timerHL.Enabled = false;
                }

                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X - 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X - 1, lblO1.Location.Y);
                }
            }
        }

        private void btnHakenUR_Click(object sender, EventArgs e) //Haken nach OBEN RECHTS!
        {
            timerHakenRauf.Enabled = true;
            timerHR.Enabled = true;
            timerHakenRunter.Enabled = false;
            timerHL.Enabled = false;
        }

        private void btnHakenDOWNRIGHT_Click(object sender, EventArgs e)
        {
            timerHakenRunter.Enabled = true;
            timerHR.Enabled = true;
            timerHakenRauf.Enabled = false;
            timerHL.Enabled = false;
        }

        private void btnHakenUPLEFT_Click(object sender, EventArgs e)
        {
            timerHakenRauf.Enabled = true;
            timerHL.Enabled = true;
            timerHakenRunter.Enabled = false;
            timerHR.Enabled = false;
        }

        private void btnHakenDOWNLEFT_Click(object sender, EventArgs e)
        {
            timerHakenRunter.Enabled = true;
            timerHL.Enabled = true;
            timerHakenRauf.Enabled = false;
            timerHR.Enabled = false;
        }

        private void btnMRIGHT_Click(object sender, EventArgs e)
        {
            timerR.Enabled = true;
            timerL.Enabled = false;
        }

        private void timerR_Tick(object sender, EventArgs e)//Komplette Bewegung nach rechts
        {
            if (lblRader.Location.X >= 209 && lblRader.Location.X <= 1031)
            {
                lblRader.Location = new Point(lblRader.Location.X + 1, lblRader.Location.Y);
                pnlLinks.Location = new Point(pnlLinks.Location.X + 1, pnlLinks.Location.Y);
                pnlRechts.Location = new Point(pnlRechts.Location.X + 1, pnlRechts.Location.Y);
                pnlOben.Location = new Point(pnlOben.Location.X + 1, pnlOben.Location.Y);
                pnlSchwenk.Location = new Point(pnlSchwenk.Location.X + 1, pnlSchwenk.Location.Y);
                pnlKrankKopf.Location = new Point(pnlKrankKopf.Location.X + 1, pnlKrankKopf.Location.Y);
                pnlMast.Location = new Point(pnlMast.Location.X + 1, pnlMast.Location.Y);
                lblRolle.Location = new Point(lblRolle.Location.X + 1, lblRolle.Location.Y);
                pnlArm.Location = new Point(pnlArm.Location.X + 1, pnlArm.Location.Y);
                pnlSchnur.Location = new Point(pnlSchnur.Location.X + 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X + 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X + 1, lblO1.Location.Y);
                }
            }
        }

        private void btnSTOP1_Click(object sender, EventArgs e)
        {
            timerL.Enabled = false;
            timerR.Enabled = false;
        }

        private void btnMLEFT_Click(object sender, EventArgs e)
        {
            timerL.Enabled = true;
            timerR.Enabled = false;
        }

        private void timerL_Tick(object sender, EventArgs e)//Komplette Bewegung nach Links
        {
            if (lblRader.Location.X >= 210 && lblRader.Location.X <= 1032)
            {
                lblRader.Location = new Point(lblRader.Location.X - 1, lblRader.Location.Y);
                pnlLinks.Location = new Point(pnlLinks.Location.X - 1, pnlLinks.Location.Y);
                pnlRechts.Location = new Point(pnlRechts.Location.X - 1, pnlRechts.Location.Y);
                pnlOben.Location = new Point(pnlOben.Location.X - 1, pnlOben.Location.Y);
                pnlSchwenk.Location = new Point(pnlSchwenk.Location.X - 1, pnlSchwenk.Location.Y);
                pnlKrankKopf.Location = new Point(pnlKrankKopf.Location.X - 1, pnlKrankKopf.Location.Y);
                pnlMast.Location = new Point(pnlMast.Location.X - 1, pnlMast.Location.Y);
                lblRolle.Location = new Point(lblRolle.Location.X - 1, lblRolle.Location.Y);
                pnlArm.Location = new Point(pnlArm.Location.X - 1, pnlArm.Location.Y);
                pnlSchnur.Location = new Point(pnlSchnur.Location.X - 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);

                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X - 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X - 1, lblO1.Location.Y);
                }
            }
        }

        public void btnSLinks_Click(object sender, EventArgs e)
        {
            btnGreifen.Enabled = false;
            btnHackenDOWN.Enabled = false;
            btnHakenDOWNLEFT.Enabled = false;
            btnHakenDOWNRIGHT.Enabled = false;
            btnHakenLEFT.Enabled = false;
            btnHakenRIGHT.Enabled = false;
            btnHakenUP.Enabled = false;
            btnHakenUPLEFT.Enabled = false;
            btnHakenUR.Enabled = false;
            btnLösen.Enabled = false;
            btnSLinks.Enabled = false;
            btnSRechts.Enabled = false;
            btnSTOP2.Enabled = false;

            timerSL.Enabled = true;
            timerSLH.Enabled = true;
            timerRolle.Enabled = true;
            timerKopfR.Enabled = true;

            BC = pnlArm.Location.X + pnlArm.Width - pnlSchnur.Location.X;
        }

        private void timerSL_Tick(object sender, EventArgs e)//Schwenk ARM nach Links
        {
            int arm = pnlArm.Width;

            if (pnlArm.Location.X > pnlMast.Location.X)
            {
                lblAussparungen.Location = new Point(lblAussparungen.Location.X - 1, lblAussparungen.Location.Y);
                pnlArm.Width -= 1;
            }
            if (pnlArm.Width == 0)
            {
                pnlArm.Location = new Point(pnlMast.Location.X, pnlMast.Location.Y);
            }
            if (pnlArm.Location.X <= pnlMast.Location.X)
            {
                pnlArm.Width += 1;
                pnlArm.Location = new Point(pnlArm.Location.X - 1, pnlArm.Location.Y);
                if (pnlArm.Width == 224)
                {
                    timerSL.Enabled = false;
                    timerSLH.Enabled = false;

                    btnGreifen.Enabled = true;
                    btnHackenDOWN.Enabled = true;
                    btnHakenDOWNLEFT.Enabled = true;
                    btnHakenDOWNRIGHT.Enabled = true;
                    btnHakenLEFT.Enabled = true;
                    btnHakenRIGHT.Enabled = true;
                    btnHakenUP.Enabled = true;
                    btnHakenUPLEFT.Enabled = true;
                    btnHakenUR.Enabled = true;
                    btnLösen.Enabled = true;
                    btnSRechts.Enabled = true;
                    btnSTOP2.Enabled = true;
                    btnStop.Enabled = true;
                }
            }  
        }

        private void timerSR_Tick(object sender, EventArgs e) //Schwenk Arm nach Rechts
        {
            if (pnlArm.Location.X < pnlMast.Location.X)
            {
                pnlArm.Width -= 1;
                pnlArm.Location = new Point(pnlArm.Location.X + 1, pnlArm.Location.Y);
            }
            if (pnlArm.Width == 0)
            {
                pnlArm.Location = new Point(pnlMast.Location.X + 33, pnlMast.Location.Y);
            }
            if (pnlArm.Location.X == pnlMast.Location.X + 33)
            {
                pnlArm.Width += 1;
            }
            if (pnlArm.Width == 224)
            {
                timerSR.Enabled = false;
                timerSRH.Enabled = false;

                btnGreifen.Enabled = true;
                btnHackenDOWN.Enabled = true;
                btnHakenDOWNLEFT.Enabled = true;
                btnHakenDOWNRIGHT.Enabled = true;
                btnHakenLEFT.Enabled = true;
                btnHakenRIGHT.Enabled = true;
                btnHakenUP.Enabled = true;
                btnHakenUPLEFT.Enabled = true;
                btnHakenUR.Enabled = true;
                btnLösen.Enabled = true;
                btnSLinks.Enabled = true;
                btnSTOP2.Enabled = true;
            }


        }

        public void timerSLH_Tick(object sender, EventArgs e) //Schwenk HAKEN+SCHNUR
        {
            int arm = pnlArm.Width;
            if (pnlSchnur.Location.X > pnlMast.Location.X + 20)//Haken+Schnur wandern hinter den Mast
            {
                pnlSchnur.Location = new Point(pnlSchnur.Location.X - 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(pnlSchnur.Location.X - 10, lblHaken.Location.Y);
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X - 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X - 1, lblO1.Location.Y);
                }
            }
            if (pnlArm.Width > BC-20 && pnlArm.Location.X <= pnlMast.Location.X)
            {
                pnlSchnur.Location = new Point(pnlSchnur.Location.X - 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X - 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X - 1, lblO1.Location.Y);
                }
            }
        }

        private void timerSRH_Tick(object sender, EventArgs e)
        {
            if (pnlSchnur.Location.X < pnlMast.Location.X + 15)
            {
                pnlSchnur.Location = new Point(pnlSchnur.Location.X + 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(pnlSchnur.Location.X - 10, lblHaken.Location.Y);
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X + 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X + 1, lblO1.Location.Y);
                }
            }
            if (pnlArm.Width > 204-BC && pnlArm.Location.X >= pnlMast.Location.X + 33)
            {
                pnlSchnur.Location = new Point(pnlSchnur.Location.X + 1, pnlSchnur.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);
                if (box1)
                {
                    pnlBox1.Location = new Point(pnlBox1.Location.X + 1, pnlBox1.Location.Y);
                    lblO1.Location = new Point(lblO1.Location.X + 1, lblO1.Location.Y);
                }
            }

        }

        private void timerRolle_Tick(object sender, EventArgs e)
        {
            if (lblRolle.Location.X + 69 == pnlMast.Location.X) //Rolle nach Rechts
            {
                lblRolle.Location = new Point(lblRolle.Location.X + 1, lblRolle.Location.Y);
            }
            if (lblRolle.Location.X + 69 > pnlMast.Location.X)
            {
                lblRolle.Location = new Point(lblRolle.Location.X + 1, lblRolle.Location.Y);
            }

            if (lblRolle.Location.X - 6 == pnlMast.Location.X)
            {
                    timerRolle.Enabled = false;
            }
        }

        private void timerKRolle2_Tick(object sender, EventArgs e)
        {

            if (lblRolle.Location.X - 6 == pnlMast.Location.X)//Rolle nach Links
            {
                lblRolle.Location = new Point(lblRolle.Location.X - 1, lblRolle.Location.Y);
            }
            if (lblRolle.Location.X - 6 < pnlMast.Location.X)
            {
                lblRolle.Location = new Point(lblRolle.Location.X - 1, lblRolle.Location.Y);
            }
            if (lblRolle.Location.X + 69 == pnlMast.Location.X)
            {
                timerKRolle2.Enabled = false;
            }
        }

        private void btnSRechts_Click(object sender, EventArgs e)
        {
            BC = pnlArm.Location.X + pnlArm.Width - pnlSchnur.Location.X;

            timerKRolle2.Enabled = true;
            timerKopfL.Enabled = true;
            timerSR.Enabled = true;
            timerSRH.Enabled = true;

            btnGreifen.Enabled = false;
            btnHackenDOWN.Enabled = false;
            btnHakenDOWNLEFT.Enabled = false;
            btnHakenDOWNRIGHT.Enabled = false;
            btnHakenLEFT.Enabled = false;
            btnHakenRIGHT.Enabled = false;
            btnHakenUP.Enabled = false;
            btnHakenUPLEFT.Enabled = false;
            btnHakenUR.Enabled = false;
            btnLösen.Enabled = false;
            btnSLinks.Enabled = false;
            btnSRechts.Enabled = false;
            btnSTOP2.Enabled = false;
        }

        private void timerKopfR_Tick(object sender, EventArgs e)
        {
            if (pnlKrankKopf.Location.X <= pnlOben.Location.X)
            {
                pnlKrankKopf.Location = new Point(pnlKrankKopf.Location.X +1, pnlKrankKopf.Location.Y);
            }
            if (pnlKrankKopf.Location.X == pnlOben.Location.X)
            {
                timerKopfR.Enabled = false;
            }
        }


        private void timerKopfL_Tick_1(object sender, EventArgs e)
        {
            pnlKrankKopf.Location = new Point(pnlKrankKopf.Location.X - 1, pnlKrankKopf.Location.Y);
            if (pnlKrankKopf.Location.X <= pnlOben.Location.X)
            {
                pnlKrankKopf.Location = new Point(pnlKrankKopf.Location.X - 1, pnlKrankKopf.Location.Y);
            }
            if (pnlKrankKopf.Location.X == pnlOben.Location.X - 48)
            {
                timerKopfL.Enabled = false;
            }
        }

        private void btnGreifen_Click(object sender, EventArgs e)
        {
            if (lblO1.Bounds.IntersectsWith(lblHaken.Bounds))
            {
                lblAnzeige.Visible = true;//Anzeige
                lblAnzeige.Text = "Gewicht angekoppelt";
                int grosse = lblAnzeige.Width / 2;
                lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
                timerAnzeige.Enabled = true;
                box1 = true;
            }
        }

        private void btnLösen_Click(object sender, EventArgs e)
        {
            if (pnlBox1.Location.Y < 542)
            {
                box1 = false;
                timerBox1.Enabled = true;
                lblAnzeige.Visible = true;//Anzeige
                lblAnzeige.Text = "Gewicht abgekoppelt";
                int grosse = lblAnzeige.Width / 2;
                lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
                timerAnzeige.Enabled = true;
            }
            
        }

        private void timerBox1_Tick(object sender, EventArgs e)
        {
            if (pnlBox1.Location.Y < 542)
            {
                pnlBox1.Location = new Point(pnlBox1.Location.X, pnlBox1.Location.Y + 1);
                lblO1.Location = new Point(lblO1.Location.X, lblO1.Location.Y + 1);
            }
            if (pnlBox1.Location.Y == 542)
            {
                timerBox1.Enabled = false;
                
                timerAnzeige.Enabled = true;
            }
            if (pnlBox1.Location.Y >= 543)
            {
                lblAnzeige.Visible = true;//Anzeige
                lblAnzeige.Text = "Gewicht ist in der Amatur, du Idiot";
                int grosse = lblAnzeige.Width / 2;
                lblAnzeige.Location = new Point(lblAnzeige.Location.X - grosse, lblAnzeige.Location.Y);
            }
        }
    }
}
