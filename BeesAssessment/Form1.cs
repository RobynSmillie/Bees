using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeesAssessment
{
    public partial class Form1 : Form
    {
        private BeeOperations ops;
        private List<Bee> beeList;

        public Form1()
        {
            InitializeComponent();
            ops = new BeeOperations();
            ops.GenerateBees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beeList = ops.GetBees();

            foreach (Bee b in beeList)
            {
                int randNum = ops.randomNumber();
                b.Damage(randNum);
            }
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            label1.Text = beeList[0].GetHealthStatus();
            label2.Text = beeList[1].GetHealthStatus();
            label3.Text = beeList[2].GetHealthStatus();
            label4.Text = beeList[3].GetHealthStatus();
            label5.Text = beeList[4].GetHealthStatus();
            label6.Text = beeList[5].GetHealthStatus();
            label7.Text = beeList[6].GetHealthStatus();
            label8.Text = beeList[7].GetHealthStatus();
            label9.Text = beeList[8].GetHealthStatus();
            label10.Text = beeList[9].GetHealthStatus();

            label11.Text = beeList[10].GetHealthStatus();
            label12.Text = beeList[11].GetHealthStatus();
            label13.Text = beeList[12].GetHealthStatus();
            label14.Text = beeList[13].GetHealthStatus();
            label15.Text = beeList[14].GetHealthStatus();
            label16.Text = beeList[15].GetHealthStatus();
            label17.Text = beeList[16].GetHealthStatus();
            label18.Text = beeList[17].GetHealthStatus();
            label19.Text = beeList[18].GetHealthStatus();
            label20.Text = beeList[19].GetHealthStatus();

            label21.Text = beeList[20].GetHealthStatus();
            label22.Text = beeList[21].GetHealthStatus();
            label23.Text = beeList[22].GetHealthStatus();
            label24.Text = beeList[23].GetHealthStatus();
            label25.Text = beeList[24].GetHealthStatus();
            label26.Text = beeList[25].GetHealthStatus();
            label27.Text = beeList[26].GetHealthStatus();
            label28.Text = beeList[27].GetHealthStatus();
            label29.Text = beeList[28].GetHealthStatus();
            label30.Text = beeList[29].GetHealthStatus();
        }
    }
}
