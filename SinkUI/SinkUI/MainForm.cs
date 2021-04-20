using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SinkUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
     
        private void buildButton_Click(object sender, EventArgs e)
        {
            string errorList = "";
            if ((ANumericUpDown.Value-30)<CNumericUpDown.Value)        
            {
                ANumericUpDown.BackColor = Color.Salmon;
                CNumericUpDown.BackColor = Color.Salmon;
                errorList+= "Разность длины мойки и длины чаши должна превышать 30 \n";
            }

            if ((BNumericUpDown.Value - 30) < ENumericUpDown.Value)
            {
                BNumericUpDown.BackColor = Color.Salmon;
                ENumericUpDown.BackColor = Color.Salmon;
                errorList += "Разность ширины мойки и ширины чаши должна превышать 30 \n";
            }

            if (D_NumericUpDown.Value < dNumericUpDown.Value)
            {
                D_NumericUpDown.BackColor = Color.Salmon;
                dNumericUpDown.BackColor = Color.Salmon;
                errorList += "Диаметр отверстия для слива должен быть больше диаметра отверстия для крана \n";
            }

            if (errorList.Length != 0)
            {
                MessageBox.Show(errorList, "Данное условие не соблюдено:",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void CNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            CNumericUpDown.BackColor = Color.White;
        }

        private void ANumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            ANumericUpDown.BackColor = Color.White;
        }

        private void BNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            BNumericUpDown.BackColor = Color.White;
        }

        private void ENumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            ENumericUpDown.BackColor = Color.White;
        }

        private void D_NumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            D_NumericUpDown.BackColor = Color.White;
        }

        private void dNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            dNumericUpDown.BackColor = Color.White;
        }
    }
}
