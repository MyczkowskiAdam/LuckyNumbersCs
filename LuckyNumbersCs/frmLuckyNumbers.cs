using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbersCs
{
    public partial class frmLuckyNumbers : Form
    {
        string[] lucky = {
            "are a natural leader",
            "are a natural peacemaker",
            "are creative and optimistic",
            "are a hard worker",
            "value freedom",
            "are a carer and provider",
            "are a thinker",
            "have diplomatic skills",
            "are selfless and generous"
        };

        static string FrNm, LstNm;
        static char[] FrNmAr;
        static char[] LstNmAr;
        const string alphabet = "abcdefghijklmnopqrstuvwxyz"; //Letters of alphabet used throughout the program
        const string CAPalphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Capital letters of alphabet used throughout the program
        static int FrNmVal, LstNmVal, LuckyNumber, tmp;

        public frmLuckyNumbers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FrNm = txtbFrNm.Text;
            LstNm = txtbLstNm.Text;
            if (String.IsNullOrWhiteSpace(txtbFrNm.Text) && String.IsNullOrWhiteSpace(txtbLstNm.Text) || String.IsNullOrWhiteSpace(txtbFrNm.Text) || String.IsNullOrWhiteSpace(txtbLstNm.Text))
            {
                MessageBox.Show("Input boxes cannot be empty, please enter some text!!", "Empty Boxes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
            else
            {
                ClearAll();
                NmToNum();
                doCalc();
                displayInfo();
            }
        }
        private void ClearAll()
        {
            txtbFrNm.Clear();
            txtbLstNm.Clear();
            FrNmVal = LstNmVal = LuckyNumber = tmp = 0;
        }

        private void NmToNum()
        {
            FrNmAr = FrNm.ToCharArray();
            LstNmAr = LstNm.ToCharArray();

            for (int i = 0; i < FrNmAr.Length; i++)
            {
                tmp = alphabet.IndexOf(FrNmAr[i]);
                if (tmp == -1)
                {
                    tmp = CAPalphabet.IndexOf(FrNmAr[i]);
                    if (tmp == -1)
                    {
                        MessageBox.Show(string.Format("Unknown character ' {0}' , please enter text only", FrNmAr[i]), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                FrNmVal += (tmp % 9) + 1; // Use simple mathematical equation to change the tmp int into a right number as in the cheatsheet, for example 'c' is in pos 2, 2 % 9 = 2 because 2 / 9 = 0.(2), 2 + 1 = 3. ^Lookup cheatsheet: c = 3
            }

            for (int i = 0; i < LstNmAr.Length; i++)
            {
                tmp = alphabet.IndexOf(LstNmAr[i]);
                if (tmp == -1)
                {
                    tmp = CAPalphabet.IndexOf(LstNmAr[i]);
                    if (tmp == -1)
                    {
                        MessageBox.Show(string.Format("Unknown character ' {0} ', please enter text only", LstNmAr[i]), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                LstNmVal += (tmp % 9) + 1; // Use simple mathematical equation to change the tmp int into a right number as in the cheatsheet, for example 'c' is in pos 2, 2 % 9 = 2 because 2 / 9 = 0.(2), 2 + 1 = 3. ^Lookup cheatsheet: c = 3
            }
        }

        private void doCalc()
        {
            while (FrNmVal > 9)
            { // if number is lower than 9 it's a single digit and doesn't need to be split
                char[] FrNmValC = FrNmVal.ToString().ToCharArray();
                FrNmVal = (FrNmValC[0] - '0') + (FrNmValC[1] - '0');

            } 

            while (LstNmVal > 9)
            { // if number is lower than 9 it's a single digit and doesn't need to be split
                char[] LstNmValC = LstNmVal.ToString().ToCharArray();
                LstNmVal = (LstNmValC[0] - '0') + (LstNmValC[1] - '0');
            }

            LuckyNumber = FrNmVal + LstNmVal;

            while (LuckyNumber > 9)
            { // if number is lower than 9 it's a single digit and doesn't need to be split
                char[] LuckyNumberC = LuckyNumber.ToString().ToCharArray();
                LuckyNumber = (LuckyNumberC[0] - '0') + (LuckyNumberC[1] - '0');
            }

        }

        private void displayInfo()
        {
                lblOUT.Text = string.Format("Your lucky number is {0} !! This means that you {1}", LuckyNumber, lucky[LuckyNumber-1]);
        }
    }
}