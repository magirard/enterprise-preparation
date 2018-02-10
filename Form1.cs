using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoanAmount_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }



        private void label5_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void PsuRig6_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void PsuRig5_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void PsuRig4_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void PsuRig12_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }


        private int Loan = 0;
        private double YearRecover = 3;
        private double InterestRate = 0.12f;
        private int PersonnalCash = 75000;
        private double ImpotPct = 0.16f;
        private double RigUptimePct = 0.975f;
        private int AmpMax = 1000;
        private int AmpReserved = 60;
        private int AmpPerBreaker = 40;
        private double PctRepair = 0.05f;
        private double Electricity = 0.09f;
        private double InsurancePerRigPerWeek = 0.64f;
        private int WattPerCard = 150;
        private int WattOther = 150;
        private int InputVolt = 240;
        private int PSU4 = 1000;
        private int PSU5 = 1200;
        private int PSU6 = 1200;
        private int PSU12 = 2400;
        private int NbRigMax4OnAmp = 1;
        private int NbRigMax5OnAmp = 1;
        private int NbRigMax6OnAmp = 1;
        private int NbRigMax12OnAmp = 1;
        private int NbCardMax4OnAmp = 1;
        private int NbCardMax5OnAmp = 1;
        private int NbCardMax6OnAmp = 1;
        private int NbCardMax12OnAmp = 1;

        private void ShowCalculatedValues()
        {
            MaxRig4_t.Text = NbRigMax4OnAmp.ToString();
            MaxRig5_t.Text = NbRigMax5OnAmp.ToString();
            MaxRig6_t.Text = NbRigMax6OnAmp.ToString();
            MaxRig12_t.Text = NbRigMax12OnAmp.ToString();

            MaxCardRig4_t.Text = NbCardMax4OnAmp.ToString();
            MaxCardRig5_t.Text = NbCardMax5OnAmp.ToString();
            MaxCardRig6_t.Text = NbCardMax6OnAmp.ToString();
            MaxCardRig12_t.Text = NbCardMax12OnAmp.ToString();
        }
        private void ReassignInputVariables()
        {
            Loan = Convert.ToInt32(LoanAmount_t.Text.Replace(".",","));
            YearRecover = Convert.ToInt32(LoanYear_t.Text);
            InterestRate = Convert.ToDouble(Interest_t.Text.Replace(".", ","));
            PersonnalCash = Convert.ToInt32(PersonnalCash_t.Text);
            ImpotPct = Convert.ToDouble(Impot_t.Text.Replace(".", ","));
            RigUptimePct = Convert.ToDouble(RigUptimePct_t.Text.Replace(".", ","));
            AmpMax = Convert.ToInt32(AmpMax_t.Text);
            AmpReserved = Convert.ToInt32(AmpOther_t.Text);
            AmpPerBreaker = Convert.ToInt32(AmpPerBreaker_t.Text);
            PctRepair = Convert.ToDouble(ReparationPct_t.Text.Replace(".", ","));
            Electricity = Convert.ToDouble(Electricity_t.Text.Replace(".", ","));
            InsurancePerRigPerWeek = Convert.ToDouble(InsurancePerWeekPerRig_t.Text.Replace(".", ","));
            WattPerCard = Convert.ToInt32(WattPerCard_t.Text);
            WattOther = Convert.ToInt32(WattOther_t.Text);
            InputVolt = Convert.ToInt32(InputVolt_t.Text);
            PSU4 = Convert.ToInt32(PsuRig4_t.Text);
            PSU5 = Convert.ToInt32(PsuRig5_t.Text);
            PSU6 = Convert.ToInt32(PsuRig6_t.Text);
            PSU12 = Convert.ToInt32(PsuRig12_t.Text);

            
        }

        private void CalculateMaxPotentialCard()
        {
            int WattTotal = AmpPerBreaker * InputVolt;
            int nbRigMax4PerBreaker = WattTotal / PSU4;
            int nbRigMax5PerBreaker = WattTotal / PSU5;
            int nbRigMax6PerBreaker = WattTotal / PSU6;
            int nbRigMax12PerBreaker = WattTotal / PSU12;
            int nbBreaker = (AmpMax - AmpReserved) / AmpPerBreaker;

            NbRigMax4OnAmp = nbBreaker * nbRigMax4PerBreaker;
            NbRigMax5OnAmp = nbBreaker * nbRigMax5PerBreaker;
            NbRigMax6OnAmp = nbBreaker * nbRigMax6PerBreaker;
            NbRigMax12OnAmp = nbBreaker * nbRigMax12PerBreaker;

            NbCardMax4OnAmp = NbRigMax4OnAmp * 4;
            NbCardMax5OnAmp = NbRigMax5OnAmp * 5;
            NbCardMax6OnAmp = NbRigMax6OnAmp * 6;
            NbCardMax12OnAmp = NbRigMax12OnAmp * 12;
        }

        private void RigUptimePct_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void AmpMax_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void AmpPerBreaker_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void ReparationPct_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void Electricity_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void InsurancePerWeekPerRig_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void WattPerCard_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void WattOther_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }

        private void InputVolt_t_TextChanged(object sender, EventArgs e)
        {
            ReassignInputVariables();
            CalculateMaxPotentialCard();
            ShowCalculatedValues();
        }
    }
}
