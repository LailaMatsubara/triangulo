using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        float l1, l2, l3;

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtl1.Clear(); 
            txtl2.Clear(); 
            txtl3.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            l1 = float.Parse(txtl1.Text); 
            l2 = float.Parse(txtl2.Text); 
            l3 = float.Parse(txtl3.Text); 
            
            if (l1 + l2 > l3)
            {
                if (l1 + l3 > l2) 
                { 
                    if (l2 + l3 > l1) 
                    { 
                        if (l1 == l2) 
                        { 
                            if (l2 == l3) 
                            { 
                                MessageBox.Show("O triângulo cujas medidas foram inseridas é equilátero.", "É triângulo", MessageBoxButtons.OK); 
                            } 
                            else 
                            { 
                                MessageBox.Show("O triângulo cujas medidas foram inseridas é isóceles.", "É triângulo", MessageBoxButtons.OK); 
                            } 
                        } 
                        else 
                        { 
                            if (l1 == l3) 
                            { 
                                MessageBox.Show("O triângulo cujas medidas foram inseridas é isóceles.", "É triângulo", MessageBoxButtons.OK); 
                            } 
                            else 
                            { 
                                MessageBox.Show("O triângulo cujas medidas foram inseridas é escaleno.", "É triângulo", MessageBoxButtons.OK); 
                            } 
                        } 
                    } 
                    else 
                    { 
                        MessageBox.Show("A forma cujas medidas foram inseridas não é um triângulo, visto que não obedecem suas condições de existência.", "Nãoétriângulo", MessageBoxButtons.OK); 
                    } 
                }
                else
                {
                    MessageBox.Show("A forma cujas medidas foram inseridas não é um triângulo, visto que não obedecem suas condições de existência.", "Nãoétriângulo", MessageBoxButtons.OK);
                }
            }
            else 
            { 
                MessageBox.Show("A forma cujas medidas foram inseridas não é um triângulo, visto que não obedecem suas condições de existência.", "Nãoétriângulo", MessageBoxButtons.OK); 
            }
        }
    }
}
