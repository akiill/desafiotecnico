using System;
using System.Windows.Forms;
using desafiotecnicodll;

namespace desafiotecnicoform
{
    public partial class Desafio : Form
    {
        public Desafio()
        {
            InitializeComponent();
        }

        private void Desafio_Load(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void LimparForm()
        {
            lblMsgErro.Text = string.Empty;
            txtDivisores.Text = string.Empty;
            txtPrimos.Text = string.Empty;
            txtNumero.Text = string.Empty;
            lblAguarde.Visible = false;
            txtNumero.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsgErro.Text = string.Empty;
                lblAguarde.Visible = true;
                btnCalcular.Enabled = false;
                btnFechar.Enabled = false;
                btnLimpar.Enabled = false;
                
                long numero = 0;

                if (long.TryParse(txtNumero.Text, out numero))
                {
                    DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(numero);

                    if (string.IsNullOrEmpty(divisoresPrimos.erro))
                    {
                        divisoresPrimos.divisores.Sort();
                        divisoresPrimos.primos.Sort();
                        txtDivisores.Text = string.Join(",", divisoresPrimos.divisores);
                        txtPrimos.Text = string.Join(",", divisoresPrimos.primos);
                    } 
                    else
                    {
                        lblMsgErro.Text = divisoresPrimos.erro;
                    }
                }
                else
                {
                    MessageBox.Show("O valor digitado deverá ser numérico");
                    txtNumero.Text = string.Empty;
                    txtNumero.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                lblMsgErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMsgErro.Text = ex.Message;
            }

            lblAguarde.Visible = false;
            btnCalcular.Enabled = true;
            btnFechar.Enabled = true;
            btnLimpar.Enabled = true;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
