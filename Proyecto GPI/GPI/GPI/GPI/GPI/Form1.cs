using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPI
{

    public partial class Form1 : Form
    {

        int[] comps = new int[20];
        int[] habs = new int[12];
        int[] necs = new int[12];
        int[] ptscomps = new int[18];
        int[] cargospre = new int[3];
        string[] nomcargos = new string[3];
        int[] ptshabs = new int[18];

        public Form1()
        {
            InitializeComponent();
            radioButton4.Checked = true;
            radioButton8.Checked = true;
            radioButton12.Checked = true;
            radioButton16.Checked = true;
            radioButton20.Checked = true;
            radioButton24.Checked = true;
            radioButton28.Checked = true;
            radioButton32.Checked = true;
            radioButton36.Checked = true;
            radioButton40.Checked = true;
            radioButton44.Checked = true;
            radioButton48.Checked = true;
            radioButton52.Checked = true;
            radioButton56.Checked = true;
            radioButton60.Checked = true;
            radioButton64.Checked = true;
            radioButton68.Checked = true;
            radioButton72.Checked = true;
            radioButton76.Checked = true;
            radioButton80.Checked = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            radioButton82.Checked = true;
            radioButton85.Checked = true;
            radioButton88.Checked = true;
            radioButton91.Checked = true;
            radioButton94.Checked = true;
            radioButton97.Checked = true;
            radioButton100.Checked = true;
            radioButton103.Checked = true;
            radioButton106.Checked = true;
            radioButton109.Checked = true;
            radioButton112.Checked = true;
            radioButton115.Checked = true;
            radioButton118.Checked = true;
            radioButton121.Checked = true;
            radioButton124.Checked = true;
            radioButton127.Checked = true;
            radioButton130.Checked = true;
            radioButton133.Checked = true;
            radioButton136.Checked = true;
            radioButton139.Checked = true;
            radioButton142.Checked = true;
            radioButton145.Checked = true;
            radioButton148.Checked = true;
            radioButton151.Checked = true;
            radioButton154.Checked = true;
            radioButton157.Checked = true;
            radioButton160.Checked = true;
            radioButton163.Checked = true;
            radioButton166.Checked = true;

            for (int i = 0; i < 12; i++)
            {
                necs[i] = 0;
                habs[i] = 0;
            }
            for (int i = 0; i < 18; i++)
            {
                ptscomps[i] = 0;
                ptshabs[i] = 0;
            }
            for (int i = 0; i < 20; i++)
            {
                comps[i] = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                cargospre[i] = -1;
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            //label2.Text = txtnombre.Text;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            // if (String.IsNullOrEmpty(txtnombre.Text))
            //   btnnombre.Enabled = false;
            //else
            //  btnnombre.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            //comp 1
            if (radioButton1.Checked == true)
            {
                comps[0] = 6;
            }
            if (radioButton2.Checked == true)
            {
                comps[0] = 4;
            }
            if (radioButton3.Checked == true)
            {
                comps[0] = 2;
            }
            if (radioButton4.Checked == true)
            {
                comps[0] = 0;
            }
            //comp 2
            if (radioButton5.Checked == true)
            {
                comps[1] = 6;
            }
            if (radioButton6.Checked == true)
            {
                comps[1] = 4;
            }
            if (radioButton7.Checked == true)
            {
                comps[1] = 2;
            }
            if (radioButton8.Checked == true)
            {
                comps[1] = 0;
            }
            //comp 3
            if (radioButton9.Checked == true)
            {
                comps[2] = 6;
            }
            if (radioButton10.Checked == true)
            {
                comps[2] = 4;
            }
            if (radioButton11.Checked == true)
            {
                comps[2] = 2;
            }
            if (radioButton12.Checked == true)
            {
                comps[2] = 0;
            }
            //comp 4
            if (radioButton13.Checked == true)
            {
                comps[3] = 6;
            }
            if (radioButton14.Checked == true)
            {
                comps[3] = 4;
            }
            if (radioButton15.Checked == true)
            {
                comps[3] = 2;
            }
            if (radioButton16.Checked == true)
            {
                comps[3] = 0;
            }
            //comp 5
            if (radioButton17.Checked == true)
            {
                comps[4] = 6;
            }
            if (radioButton18.Checked == true)
            {
                comps[4] = 4;
            }
            if (radioButton19.Checked == true)
            {
                comps[4] = 2;
            }
            if (radioButton20.Checked == true)
            {
                comps[4] = 0;
            }
            //comp 6
            if (radioButton21.Checked == true)
            {
                comps[5] = 6;
            }
            if (radioButton22.Checked == true)
            {
                comps[5] = 4;
            }
            if (radioButton23.Checked == true)
            {
                comps[5] = 2;
            }
            if (radioButton24.Checked == true)
            {
                comps[5] = 0;
            }
            //comp 7
            if (radioButton25.Checked == true)
            {
                comps[6] = 6;
            }
            if (radioButton26.Checked == true)
            {
                comps[6] = 4;
            }
            if (radioButton27.Checked == true)
            {
                comps[6] = 2;
            }
            if (radioButton28.Checked == true)
            {
                comps[6] = 0;
            }
            //comp 8
            if (radioButton29.Checked == true)
            {
                comps[7] = 6;
            }
            if (radioButton30.Checked == true)
            {
                comps[7] = 4;
            }
            if (radioButton31.Checked == true)
            {
                comps[7] = 2;
            }
            if (radioButton32.Checked == true)
            {
                comps[7] = 0;
            }
            //comp 9
            if (radioButton33.Checked == true)
            {
                comps[8] = 6;
            }
            if (radioButton34.Checked == true)
            {
                comps[8] = 4;
            }
            if (radioButton35.Checked == true)
            {
                comps[8] = 2;
            }
            if (radioButton36.Checked == true)
            {
                comps[8] = 0;
            }
            //comp 10
            if (radioButton37.Checked == true)
            {
                comps[9] = 6;
            }
            if (radioButton38.Checked == true)
            {
                comps[9] = 4;
            }
            if (radioButton39.Checked == true)
            {
                comps[9] = 2;
            }
            if (radioButton40.Checked == true)
            {
                comps[9] = 0;
            }
            //comp 11
            if (radioButton41.Checked == true)
            {
                comps[10] = 6;
            }
            if (radioButton42.Checked == true)
            {
                comps[10] = 4;
            }
            if (radioButton43.Checked == true)
            {
                comps[10] = 2;
            }
            if (radioButton44.Checked == true)
            {
                comps[10] = 0;
            }
            //comp 12
            if (radioButton45.Checked == true)
            {
                comps[11] = 6;
            }
            if (radioButton46.Checked == true)
            {
                comps[11] = 4;
            }
            if (radioButton47.Checked == true)
            {
                comps[11] = 2;
            }
            if (radioButton48.Checked == true)
            {
                comps[11] = 0;
            }
            //comp 13
            if (radioButton49.Checked == true)
            {
                comps[12] = 6;
            }
            if (radioButton50.Checked == true)
            {
                comps[12] = 4;
            }
            if (radioButton51.Checked == true)
            {
                comps[12] = 2;
            }
            if (radioButton52.Checked == true)
            {
                comps[12] = 0;
            }
            //comp 14
            if (radioButton53.Checked == true)
            {
                comps[13] = 6;
            }
            if (radioButton54.Checked == true)
            {
                comps[13] = 4;
            }
            if (radioButton55.Checked == true)
            {
                comps[13] = 2;
            }
            if (radioButton56.Checked == true)
            {
                comps[13] = 0;
            }
            //comp 15
            if (radioButton57.Checked == true)
            {
                comps[14] = 6;
            }
            if (radioButton58.Checked == true)
            {
                comps[14] = 4;
            }
            if (radioButton59.Checked == true)
            {
                comps[14] = 2;
            }
            if (radioButton60.Checked == true)
            {
                comps[14] = 0;
            }
            //comp 16
            if (radioButton61.Checked == true)
            {
                comps[15] = 6;
            }
            if (radioButton62.Checked == true)
            {
                comps[15] = 4;
            }
            if (radioButton63.Checked == true)
            {
                comps[15] = 2;
            }
            if (radioButton64.Checked == true)
            {
                comps[15] = 0;
            }
            //comp 17
            if (radioButton65.Checked == true)
            {
                comps[16] = 6;
            }
            if (radioButton66.Checked == true)
            {
                comps[16] = 4;
            }
            if (radioButton67.Checked == true)
            {
                comps[16] = 2;
            }
            if (radioButton68.Checked == true)
            {
                comps[16] = 0;
            }
            //comp 18
            if (radioButton69.Checked == true)
            {
                comps[17] = 6;
            }
            if (radioButton70.Checked == true)
            {
                comps[17] = 4;
            }
            if (radioButton71.Checked == true)
            {
                comps[17] = 2;
            }
            if (radioButton72.Checked == true)
            {
                comps[17] = 0;
            }
            //comp 19
            if (radioButton73.Checked == true)
            {
                comps[18] = 6;
            }
            if (radioButton74.Checked == true)
            {
                comps[18] = 4;
            }
            if (radioButton75.Checked == true)
            {
                comps[18] = 2;
            }
            if (radioButton76.Checked == true)
            {
                comps[18] = 0;
            }
            //comp 20
            if (radioButton77.Checked == true)
            {
                comps[19] = 6;
            }
            if (radioButton78.Checked == true)
            {
                comps[19] = 4;
            }
            if (radioButton79.Checked == true)
            {
                comps[19] = 2;
            }
            if (radioButton80.Checked == true)
            {
                comps[19] = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;

            groupBox5.Visible = false;
            //pregunta1
            if (radioButton81.Checked == true)
            {
                habs[7] = habs[7] + 1;
                necs[3] = necs[3] + 1;
                necs[7] = necs[7] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton82.Checked == true)
            {
                necs[6] = necs[6] + 3;
            }
            if (radioButton83.Checked == true)
            {
                habs[7] = habs[7] + 3;
                necs[3] = necs[3] + 3;
                necs[7] = necs[7] + 3;
            }
            //pregunta2
            if (radioButton84.Checked == true)
            {
                habs[7] = habs[7] + 1;
                necs[3] = necs[3] + 1;
                necs[7] = necs[7] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton85.Checked == true)
            {
                necs[6] = necs[6] + 3;
            }
            if (radioButton86.Checked == true)
            {
                habs[7] = habs[7] + 3;
                necs[3] = necs[3] + 3;
                necs[7] = necs[7] + 3;
            }
            //pregunta3
            if (radioButton87.Checked == true)
            {
                habs[8] = habs[8] + 1;
                habs[5] = habs[5] + 1;
            }
            if (radioButton88.Checked == true)
            {
                habs[8] = habs[8] + 3;
            }
            if (radioButton89.Checked == true)
            {
                habs[5] = habs[5] + 3;
            }
            //pregunta4
            if (radioButton90.Checked == true)
            {
                habs[10] = habs[10] + 1;
                necs[8] = necs[8] + 1;
                necs[10] = necs[10] + 1;
                habs[1] = habs[1] + 1;
                necs[2] = necs[2] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton91.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[2] = necs[2] + 3;
                necs[5] = necs[5] + 3;
            }
            if (radioButton92.Checked == true)
            {
                habs[10] = habs[10] + 3;
                necs[8] = necs[8] + 3;
                necs[10] = necs[10] + 3;
            }
            //pregunta5
            if (radioButton93.Checked == true)
            {
                habs[2] = habs[2] + 1;
                necs[9] = necs[9] + 1;
                necs[0] = necs[0] + 1;
                habs[1] = habs[1] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton94.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[6] = necs[6] + 3;
            }
            if (radioButton95.Checked == true)
            {
                habs[2] = habs[2] + 3;
                necs[9] = necs[9] + 3;
                necs[0] = necs[0] + 3;
            }

            //pregunta6

            if (radioButton96.Checked == true)
            {
                habs[3] = habs[3] + 1;
                necs[0] = necs[0] + 1;
                necs[10] = necs[10] + 1;
                habs[1] = habs[1] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton97.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[6] = necs[6] + 3;
            }
            if (radioButton98.Checked == true)
            {
                habs[3] = habs[3] + 3;
                necs[0] = necs[0] + 3;
                necs[10] = necs[10] + 3;
            }
            //pregunta7
            if (radioButton99.Checked == true)
            {
                habs[9] = habs[9] + 1;
                necs[3] = necs[3] + 1;
                necs[4] = necs[4] + 1;
                necs[7] = necs[7] + 1;
            }
            if (radioButton100.Checked == true)
            {
            }
            if (radioButton101.Checked == true)
            {
                habs[9] = habs[9] + 3;
                necs[3] = necs[3] + 3;
                necs[4] = necs[4] + 3;
                necs[7] = necs[7] + 3;
            }
            //pregunta8
            if (radioButton102.Checked == true)
            {
                habs[1] = habs[1] + 1;
                habs[3] = habs[3] + 1;
                necs[5] = necs[5] + 1;
                habs[7] = habs[7] + 1;
            }
            if (radioButton103.Checked == true)
            {
            }
            if (radioButton104.Checked == true)
            {
                habs[1] = habs[1] + 3;
                habs[3] = habs[3] + 3;
                necs[5] = necs[5] + 3;
                habs[7] = habs[7] + 3;
            }
            //pregunta9
            if (radioButton105.Checked == true)
            {
                habs[4] = habs[4] + 1;
                necs[8] = necs[8] + 1;
                necs[7] = necs[7] + 1;
            }
            if (radioButton106.Checked == true)
            {
            }
            if (radioButton107.Checked == true)
            {
                habs[4] = habs[4] + 3;
                necs[8] = necs[8] + 3;
                necs[7] = necs[7] + 3;
            }
            //pregunta10
            if (radioButton108.Checked == true)
            {
                habs[0] = habs[0] + 1;
                necs[4] = necs[4] + 1;
                habs[5] = habs[5] + 1;
            }
            if (radioButton109.Checked == true)
            {
                habs[5] = habs[5] + 3;
            }
            if (radioButton110.Checked == true)
            {
                habs[0] = habs[0] + 3;
                necs[4] = necs[4] + 3;
            }

            //pregunta11

            if (radioButton111.Checked == true)
            {
                habs[8] = habs[8] + 1;
                necs[6] = necs[6] + 1;
                habs[5] = habs[5] + 1;
            }
            if (radioButton112.Checked == true)
            {
                habs[5] = habs[5] + 3;
            }
            if (radioButton113.Checked == true)
            {
                habs[8] = habs[8] + 3;
                necs[6] = necs[6] + 3;
            }
            //pregunta12 
            if (radioButton115.Checked == true)
            {
                habs[8] = habs[8] + 3;
            }
            if (radioButton116.Checked == true)
            {
                habs[11] = habs[11] + 3;
                necs[1] = necs[1] + 3;
            }
            //pregunta13
            if (radioButton118.Checked == true)
            {
                habs[4] = habs[4] + 3;
                necs[2] = necs[2] + 3;
            }
            if (radioButton119.Checked == true)
            {
                habs[0] = habs[0] + 3;
                necs[1] = necs[1] + 3;
                necs[4] = necs[4] + 3;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void radioButton115_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            //pregunta14 
            if (radioButton120.Checked == true)
            {
                habs[3] = habs[3] + 1;
                habs[10] = habs[10] + 1;
                necs[10] = necs[10] + 1;
                necs[8] = necs[8] + 1;
                necs[11] = necs[11] + 1;
                habs[1] = habs[1] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton121.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[6] = necs[6] + 3;
            }
            if (radioButton122.Checked == true)
            {
                habs[3] = habs[3] + 3;
                habs[10] = habs[10] + 3;
                necs[10] = necs[10] + 3;
                necs[8] = necs[8] + 3;
                necs[11] = necs[11] + 3;
            }
            //pregunta15 
            if (radioButton123.Checked == true)
            {
                habs[10] = habs[10] + 1;
                necs[10] = necs[10] + 1;
                necs[8] = necs[8] + 1;
                necs[11] = necs[11] + 1;
                habs[1] = habs[1] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton124.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[5] = necs[5] + 3;
            }
            if (radioButton125.Checked == true)
            {
                habs[10] = habs[10] + 3;
                necs[10] = necs[10] + 3;
                necs[8] = necs[8] + 3;
                necs[11] = necs[11] + 3;
            }
            //pregunta16 
            if (radioButton126.Checked == true)
            {
                habs[10] = habs[10] + 1;
                necs[10] = necs[10] + 1;
                habs[1] = habs[1] + 1;
                habs[8] = habs[8] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton127.Checked == true)
            {
                habs[1] = habs[1] + 3;
                habs[8] = habs[8] + 3;
                necs[5] = necs[5] + 3;
            }
            if (radioButton128.Checked == true)
            {
                habs[10] = habs[10] + 3;
                necs[10] = necs[10] + 3;
            }
            //pregunta17 
            if (radioButton129.Checked == true)
            {
                habs[6] = habs[6] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton130.Checked == true)
            {
            }
            if (radioButton131.Checked == true)
            {
                habs[6] = habs[6] + 3;
                necs[5] = necs[5] + 3;
            }
            //pregunta18 
            if (radioButton132.Checked == true)
            {
                habs[9] = habs[9] + 1;
                necs[4] = necs[4] + 1;
                necs[0] = necs[0] + 1;
                necs[7] = necs[7] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton133.Checked == true)
            {
                necs[6] = necs[6] + 3;
            }
            if (radioButton134.Checked == true)
            {
                habs[9] = habs[9] + 3;
                necs[4] = necs[4] + 3;
                necs[0] = necs[0] + 3;
                necs[7] = necs[7] + 3;
            }
            //pregunta19 
            if (radioButton135.Checked == true)
            {
                habs[11] = habs[11] + 1;
                necs[10] = necs[10] + 1;
                necs[0] = necs[0] + 1;
                necs[1] = necs[1] + 1;
            }
            if (radioButton136.Checked == true)
            {
            }
            if (radioButton137.Checked == true)
            {
                habs[11] = habs[11] + 3;
                necs[10] = necs[10] + 3;
                necs[0] = necs[0] + 3;
                necs[1] = necs[1] + 3;
            }
            //pregunta20 
            if (radioButton138.Checked == true)
            {
                habs[11] = habs[11] + 1;
                habs[7] = habs[7] + 1;
                necs[6] = necs[6] + 1;
                necs[1] = necs[1] + 1;
                habs[8] = habs[8] + 1;
                habs[1] = habs[1] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton139.Checked == true)
            {
                habs[8] = habs[8] + 3;
                habs[1] = habs[1] + 3;
                necs[5] = necs[5] + 3;
            }
            if (radioButton140.Checked == true)
            {
                habs[11] = habs[11] + 3;
                habs[7] = habs[7] + 3;
                necs[6] = necs[6] + 3;
                necs[1] = necs[1] + 3;
            }
            //pregunta21 
            if (radioButton141.Checked == true)
            {
                habs[1] = habs[1] + 1;
                necs[5] = necs[5] + 1;
                habs[10] = habs[10] + 1;
            }
            if (radioButton142.Checked == true)
            {
                habs[10] = habs[10] + 3;
            }
            if (radioButton143.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[5] = necs[5] + 3;
            }
            //pregunta22 
            if (radioButton144.Checked == true)
            {
                habs[6] = habs[6] + 1;
                necs[5] = necs[5] + 1;
                habs[1] = habs[1] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton145.Checked == true)
            {
                habs[1] = habs[1] + 3;
                necs[6] = necs[6] + 3;
            }
            if (radioButton146.Checked == true)
            {
                habs[6] = habs[6] + 3;
                necs[5] = necs[5] + 3;
            }
            //pregunta23 
            if (radioButton147.Checked == true)
            {
                necs[5] = necs[5] + 1;
                habs[1] = habs[1] + 1;
                habs[8] = habs[8] + 1;
                necs[6] = necs[6] + 1;
            }
            if (radioButton148.Checked == true)
            {
                habs[1] = habs[1] + 3;
                habs[8] = habs[8] + 3;
                necs[6] = necs[6] + 3;
            }
            if (radioButton149.Checked == true)
            {
                necs[5] = necs[5] + 3;
            }
            //pregunta24 
            if (radioButton150.Checked == true)
            {
                habs[4] = habs[4] + 1;
                necs[7] = necs[7] + 1;
                necs[5] = necs[5] + 1;
                habs[2] = habs[2] + 1;
                necs[11] = necs[11] + 1;
            }
            if (radioButton151.Checked == true)
            {
                habs[2] = habs[2] + 3;
                necs[11] = necs[11] + 3;
            }
            if (radioButton152.Checked == true)
            {
                habs[4] = habs[4] + 3;
                necs[7] = necs[7] + 3;
                necs[5] = necs[5] + 3;
            }
            //pregunta25 
            if (radioButton153.Checked == true)
            {
                habs[11] = habs[11] + 1;
                necs[1] = necs[1] + 1;
                habs[4] = habs[4] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton154.Checked == true)
            {
                habs[11] = habs[11] + 3;
                necs[1] = necs[1] + 3;
            }
            if (radioButton155.Checked == true)
            {
                habs[4] = habs[4] + 3;
                necs[5] = necs[5] + 3;
            }
            //pregunta26 
            if (radioButton156.Checked == true)
            {
                habs[10] = habs[10] + 1;
                habs[9] = habs[9] + 1;
                habs[0] = habs[0] + 1;
                necs[4] = necs[4] + 1;
                necs[8] = necs[8] + 1;
                necs[7] = necs[7] + 1;
                habs[1] = habs[1] + 1;
                habs[8] = habs[8] + 1;
                necs[6] = necs[6] + 1;
                necs[2] = necs[2] + 1;
            }
            if (radioButton157.Checked == true)
            {
                habs[1] = habs[1] + 3;
                habs[8] = habs[8] + 3;
                necs[6] = necs[6] + 3;
                necs[2] = necs[2] + 3;
            }
            if (radioButton158.Checked == true)
            {
                habs[10] = habs[10] + 3;
                habs[9] = habs[9] + 3;
                habs[0] = habs[0] + 3;
                necs[4] = necs[4] + 3;
                necs[8] = necs[8] + 3;
                necs[7] = necs[7] + 3;
            }
        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;

            //pregunta27 
            if (radioButton159.Checked == true)
            {
                habs[2] = habs[2] + 1;
                necs[11] = necs[11] + 1;
                habs[6] = habs[6] + 1;
                habs[4] = habs[4] + 1;
                necs[5] = necs[5] + 1;
            }
            if (radioButton160.Checked == true)
            {
                habs[6] = habs[6] + 3;
                habs[4] = habs[4] + 3;
                necs[5] = necs[5] + 3;
            }
            if (radioButton161.Checked == true)
            {
                habs[2] = habs[2] + 3;
                necs[11] = necs[11] + 3;
            }
            //pregunta28 
            if (radioButton162.Checked == true)
            {
                habs[4] = habs[4] + 1;
                habs[10] = habs[10] + 1;
                necs[4] = necs[4] + 1;
            }
            if (radioButton163.Checked == true)
            {
                habs[10] = habs[10] + 3;
                necs[4] = necs[4] + 3;
            }
            if (radioButton164.Checked == true)
            {
                habs[4] = habs[4] + 3;
            }
            //pregunta29 
            if (radioButton165.Checked == true)
            {
                necs[6] = necs[6] + 1;
                necs[3] = necs[3] + 1;
            }
            if (radioButton166.Checked == true)
            {
                necs[3] = necs[3] + 3;
            }
            if (radioButton167.Checked == true)
            {
                necs[6] = necs[6] + 3;
            }


            //Definir cargos por competencias

            ptscomps[0] = comps[18] + comps[19] + comps[1] + comps[16];
            ptscomps[1] = comps[18] + comps[19] + comps[1] + comps[16];
            ptscomps[2] = comps[1] + comps[15] + comps[16] + comps[18] + comps[19];
            ptscomps[3] = comps[18] + comps[19] + comps[1] + comps[12];
            ptscomps[4] = comps[18] + comps[19] + comps[1] + comps[13] + comps[8];
            ptscomps[5] = comps[18] + comps[19] + comps[1] + comps[16] + comps[11];
            ptscomps[6] = comps[11] + comps[12] + comps[16];
            ptscomps[7] = comps[6] + comps[18] + comps[12];
            ptscomps[8] = comps[16] + comps[13] + comps[11];
            ptscomps[9] = comps[9] + comps[10] + comps[12];
            ptscomps[10] = comps[12] + comps[18];
            ptscomps[11] = comps[6] + comps[14] + comps[12];
            ptscomps[12] = comps[0] + comps[1] + comps[4];
            ptscomps[13] = comps[14] + comps[6];
            ptscomps[14] = comps[0] + comps[1] + comps[7];
            ptscomps[15] = comps[2] + comps[3];
            ptscomps[16] = comps[1] + comps[8];
            ptscomps[17] = comps[1] + comps[5] + comps[17];

            ptshabs[0] = habs[10] + habs[9] + habs[2] + habs[7];
            ptshabs[1] = habs[10] + habs[9] + habs[7];
            ptshabs[2] = habs[10] + habs[9] + habs[7];
            ptshabs[3] = habs[10] + habs[9] + habs[7];
            ptshabs[4] = habs[10] + habs[11] + habs[7];
            ptshabs[5] = habs[10] + habs[5] + habs[7];
            ptshabs[6] = habs[0] + habs[2] + habs[7];
            ptshabs[7] = habs[5] + habs[7] + habs[3];
            ptshabs[8] = habs[9] + habs[3] + habs[8];
            ptshabs[9] = habs[3] + habs[10] + habs[5];
            ptshabs[10] = habs[4] + habs[2] + habs[10];
            ptshabs[11] = habs[4] + habs[7] + habs[10];
            ptshabs[12] = habs[11] + habs[5] + habs[1];
            ptshabs[13] = habs[6] + habs[2] + habs[3];
            ptshabs[14] = habs[1] + habs[8] + habs[9];
            ptshabs[15] = habs[6] + habs[9] + habs[11];
            ptshabs[16] = habs[11] + habs[5] + habs[0];
            ptshabs[17] = habs[1] + habs[8] + habs[6];

            int max = 10;
            for (int i = 0; i < 18; i++)
            {
                // if (ptscomps[i] > max) 
                if (ptscomps[i] > max && ptshabs[i] > 8)
                {
                    max = ptscomps[i];
                    cargospre[0] = i;
                }
            }

            max = 10;

            for (int i = 0; i < 18; i++)
            {
                //      if (ptscomps[i] > max && cargospre[0]!=i)
                if (ptscomps[i] > max && ptshabs[i] > 8 && cargospre[0] != i)
                {
                    max = ptscomps[i];
                    cargospre[1] = i;
                }
            }




            for (int i = 0; i < 3; i++)
            {
                if (cargospre[i] == 0)
                    nomcargos[i] = "Gerente de Operaciones";
                if (cargospre[i] == 1)
                    nomcargos[i] = "Gerente de Tecnología";
                if (cargospre[i] == 2)
                    nomcargos[i] = "Gerente de Marketing";
                if (cargospre[i] == 3)
                    nomcargos[i] = "Gerente de RRHH";
                if (cargospre[i] == 4)
                    nomcargos[i] = "Gerente de Finanzas";
                if (cargospre[i] == 5)
                    nomcargos[i] = "Gerente de Proyectos";
                if (cargospre[i] == 6)
                    nomcargos[i] = "Jefe de Proyectos";
                if (cargospre[i] == 7)
                    nomcargos[i] = "Jefe de Sucursal";
                if (cargospre[i] == 8)
                    nomcargos[i] = "Encargado de Adquisiciones";
                if (cargospre[i] == 9)
                    nomcargos[i] = "Jefe de Prevención de Riesgos";
                if (cargospre[i] == 10)
                    nomcargos[i] = "Jefe de Personal";
                if (cargospre[i] == 11)
                    nomcargos[i] = "Jefe de Ventas";
                if (cargospre[i] == 12)
                    nomcargos[i] = "Programador";
                if (cargospre[i] == 13)
                    nomcargos[i] = "Vendedor";
                if (cargospre[i] == 14)
                    nomcargos[i] = "Testeador";
                if (cargospre[i] == 15)
                    nomcargos[i] = "Diseñador";
                if (cargospre[i] == 16)
                    nomcargos[i] = "Contador";
                if (cargospre[i] == 17)
                    nomcargos[i] = "Secretaria";
            }
            try
            {
                if (ptscomps[0] > 0)
                    label51.Text = nomcargos[0] + " con " + ptscomps[cargospre[0]] + " pts en Competencias y " + ptshabs[cargospre[0]] + " pts en habilidades";
                else
                    label51.Text = "";

                if (ptscomps[1] > 0)
                    label50.Text = nomcargos[1] + " con " + ptscomps[cargospre[1]] + " pts en Competencias y " + ptshabs[cargospre[1]] + " pts en habilidades";
                else
                    label50.Text = "";

            }
            catch
            {
                MessageBox.Show("No ha quedado seleccionado por no cumplir con el minimo de competenecias y habilidades\r\n O solo clasifico para un cargo en la empresa", "No ha sido seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            double[] poderaciones = new double[3];
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    poderaciones[i] = ptscomps[cargospre[i]] * 0.4 + ptshabs[cargospre[i]] * 0.6;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("El Resultado de su evaluación es el siguiente:", "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double max2 = 0.0;
            int indice = 0;
            for (int i = 0; i < 3; i++)
            {
                if (poderaciones[i] > max2)
                {
                    max2 = poderaciones[i];
                    indice = i;
                }
            }

            label54.Text = nomcargos[indice] + " con una ponderacion de " + poderaciones[indice] + " pts";

            max = 0;
            int[] estimulos = new int[2];
            for (int i = 0; i < 12; i++)
            {
                if (necs[i] > max)
                {
                    max = necs[i];
                    estimulos[0] = i;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (necs[i] > max && estimulos[0] != i)
                {
                    max = necs[i];
                    estimulos[0] = i;
                }
            }

            string[] nomestimulos = new string[2];

            for (int i = 0; i < 2; i++)
            {
                if (estimulos[i] == 0)
                    nomestimulos[i] = "Reconocimiento por su trabajo";
                if (estimulos[i] == 1)
                    nomestimulos[i] = "Sentir responsabilidad";
                if (estimulos[i] == 2)
                    nomestimulos[i] = "Sentir que lo mandan";
                if (estimulos[i] == 3)
                    nomestimulos[i] = "Incrementar conocimiento";
                if (estimulos[i] == 4)
                    nomestimulos[i] = "Utilizar conocimiento";
                if (estimulos[i] == 5)
                    nomestimulos[i] = "Tener buenas relaciones interpersonales";
                if (estimulos[i] == 6)
                    nomestimulos[i] = "Monetaria";
                if (estimulos[i] == 7)
                    nomestimulos[i] = "Éxito y logros";
                if (estimulos[i] == 8)
                    nomestimulos[i] = "Liderar grupos";
                if (estimulos[i] == 9)
                    nomestimulos[i] = "Fama";
                if (estimulos[i] == 10)
                    nomestimulos[i] = "Respeto";
                if (estimulos[i] == 11)
                    nomestimulos[i] = "Competir";
            }

            label57.Text = nomestimulos[0];
            label58.Text = nomestimulos[1];
        }

        private void radioButton161_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            radioButton8.Checked = true;
            radioButton12.Checked = true;
            radioButton16.Checked = true;
            radioButton20.Checked = true;
            radioButton24.Checked = true;
            radioButton28.Checked = true;
            radioButton32.Checked = true;
            radioButton36.Checked = true;
            radioButton40.Checked = true;
            radioButton44.Checked = true;
            radioButton48.Checked = true;
            radioButton52.Checked = true;
            radioButton56.Checked = true;
            radioButton60.Checked = true;
            radioButton64.Checked = true;
            radioButton68.Checked = true;
            radioButton72.Checked = true;
            radioButton76.Checked = true;
            radioButton80.Checked = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            radioButton82.Checked = true;
            radioButton85.Checked = true;
            radioButton88.Checked = true;
            radioButton91.Checked = true;
            radioButton94.Checked = true;
            radioButton97.Checked = true;
            radioButton100.Checked = true;
            radioButton103.Checked = true;
            radioButton106.Checked = true;
            radioButton109.Checked = true;
            radioButton112.Checked = true;
            radioButton115.Checked = true;
            radioButton118.Checked = true;
            radioButton121.Checked = true;
            radioButton124.Checked = true;
            radioButton127.Checked = true;
            radioButton130.Checked = true;
            radioButton133.Checked = true;
            radioButton136.Checked = true;
            radioButton139.Checked = true;
            radioButton142.Checked = true;
            radioButton145.Checked = true;
            radioButton148.Checked = true;
            radioButton151.Checked = true;
            radioButton154.Checked = true;
            radioButton157.Checked = true;
            radioButton160.Checked = true;
            radioButton163.Checked = true;
            radioButton166.Checked = true;
            for (int i = 0; i < 12; i++)
            {
                necs[i] = 0;
                habs[i] = 0;
            }
            for (int i = 0; i < 18; i++)
            {
                ptscomps[i] = 0;
                ptshabs[i] = 0;
            }
            for (int i = 0; i < 20; i++)
            {
                comps[i] = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                cargospre[i] = -1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton120_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();



        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();
        }
    }
}