using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class ReajusteSalarial : Form
    {
        public ReajusteSalarial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorasTrabalhadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnNoturno_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void categoria_Enter(object sender, EventArgs e)
        {

        }
        private void rbnCalouro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnVeterano_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        




        }

        private double getCoeficiente()
        {

            double salario = Convert.ToDouble(textBox1.Text);
            
            
            double coeficiente = 0;
            String turno = "";

            if (RbnMatutino.Checked)
            {
                turno = "Matutino";
            }
            else if (rbnVespertino.Checked)
            {
                turno = "Vespertino";
            }
            else if (rbnNoturno.Checked)
            {
                turno = "Noturno";
            }

            switch (turno)
            {
                case "Matutino":
                    coeficiente = (salario * 0.01);
                    break;
                case "Vespertino":
                    coeficiente = (salario * 0.02);
                    break;

                case "Noturno":
                    coeficiente = (salario * 0.03);
                    break;

            }
            
          

            return coeficiente;
        }
        private double getSalarioBruto()
        {
            double salarioBruto = getCoeficiente() * Convert.ToDouble(txtHorasTrabalhadas.Text);
           
            return salarioBruto;
        }
        private double getImpostoDoSalarioBruto()
        {
            double imposto = 0;
            String categoriaString = "";

            if (rbnCalouro.Checked)
            {
                categoriaString = "Calouro";
            }
            else
            {
                categoriaString = "Veterano";
            }

            switch (categoriaString)
            {
                case "Calouro":
                    if(getSalarioBruto() < 300.00)
                    {
                        imposto = getSalarioBruto() * 0.01;

                    }
                    else if(getSalarioBruto() >= 300.00)
                    {
                        imposto = getSalarioBruto() * 0.02;
                    }

                    break;

                case "Veterano":
                    if (getSalarioBruto() < 400.00)
                    {
                        imposto = getSalarioBruto() * 0.03;

                    }
                    else if (getSalarioBruto() >= 400.00)
                    {
                        imposto = getSalarioBruto() * 0.04;
                    }

                    break;

            }
            return imposto;

        }

        private double getGratificacao()
        {
            int gratificacao = 30;
            if(Turno.Text.Equals("Noturno") && Convert.ToDouble(txtHorasTrabalhadas.Text) > 80){
                gratificacao = 80;
            }
            return gratificacao;
        }

        private double getValorAuxilioAlimentacao()
        {
            double valorAuxilioAlimentacao = (getSalarioBruto()/3)/2;

            if (categoria.Text.Equals("Calouro") && getSalarioBruto() < (getSalarioBruto() / 2))
            {
                valorAuxilioAlimentacao = getSalarioBruto()/3;

            }
            return valorAuxilioAlimentacao;
        }

        public double getSalarioLiquido()
        {
            double salarioLiquido = (getSalarioBruto() + getGratificacao()+ getValorAuxilioAlimentacao()) - getImpostoDoSalarioBruto();

            return salarioLiquido;
        }

        private void setApresentarResultados()
        {
            try
            {
                double coeficiente = getCoeficiente();
                double salarioBruto = getSalarioBruto();
                double imposto = getImpostoDoSalarioBruto();
                double gratificacao = getGratificacao();
                double valorAuxilioAlimentacao = getValorAuxilioAlimentacao();
                double salarioLiquido = getSalarioLiquido();
                

                lblResultado.Text = string.Format("Coeficiente: {0:C2}\n Salário Bruto: {1:C2}\nImposto: {2:C2}\nGratificação: {3:C2}\nValor Auxílio Alimentação: {4:C2}\nSalário Líquido: {5:C2}",
                    coeficiente, salarioBruto, imposto, gratificacao, valorAuxilioAlimentacao, salarioLiquido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Espaço vazio ou caracteres Indevidos","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void lblAnalise_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
          
            setApresentarResultados();

         

        }

        // tratamento de exceção se não tiver nada
        // mostrar se é um salario bom ou n
    }
}
