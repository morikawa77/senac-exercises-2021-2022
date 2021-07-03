using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class CalculoPesoIdeal : Form
    {
        public CalculoPesoIdeal()
        {
            InitializeComponent();

            rbtn_Masculino.Checked = false;
            rbtn_Feminino.Checked = false;
        }

        private void rbtn_Masculino_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Altura.Text == null)
                {
                    MessageBox.Show("Digite uma altura");
                } else
                {
                    lbl_Peso.Text = Convert.ToString((Convert.ToInt32(txt_Altura.Text) - 100) * 0.90);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void rbtn_Feminino_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Altura.Text == null)
                {
                    MessageBox.Show("Digite uma altura");
                }
                else
                {
                    lbl_Peso.Text = Convert.ToString((Convert.ToInt32(txt_Altura.Text) - 100) * 0.85);
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
