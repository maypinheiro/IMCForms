using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMCForms
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = false;
                var peso = double.Parse(textBox1.Text);
                var altura = double.Parse(textBox2.Text);
                CalculoIMC calculoIMC = new CalculoIMC();
                var resultado = calculoIMC.IMC(peso, altura);
                label4.Text = resultado.ToString("f1");
                Resultado resultado1 = new Resultado();
                var estadoNutricional = resultado1.EstadoNutricional(resultado);
                label1.Visible = true;
                label5.Text = estadoNutricional;
            }
            catch (Exception)
            {
                label2.Visible = true;
        
            }

        }

    }
}
