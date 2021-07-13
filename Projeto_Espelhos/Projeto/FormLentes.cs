using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormLentes : Form
    {
        public FormLentes()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbTipoLente.Text == "Convergente" || cbTipoLente.Text == "Divergente")
            {
                if (txtO.Text == "")
                {
                    string resulta;
                    resulta = "Você não informou o tamnho do objeto";
                    MessageBox.Show(resulta);
                }

                int f = Convert.ToInt16(txtF.Text);
                int p = Convert.ToInt16(txtP.Text);
                double o = Convert.ToDouble(txtO.Text);
                if (p == f && cbTipoLente.Text == "Convergente")
                {
                    this.pbF.Visible = true;
                    lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                    lbResultado.Items.Add("     FORMAÇÃO DE IMAGEM     ");
                    lbResultado.Items.Add("         ➖ Imprópia");

                    pbPrincipal.Visible = false;
                    lblAi.Visible = false;
                    lblAo.Visible = false;
                    lblFo.Visible = false;
                    lblFi.Visible = false;
                }
                else
                    this.pbF.Visible = false;

                if (p != f)
                {
                    lentes novo = new lentes();
                    if (cbTipoLente.Text == "Divergente")
                    {
                        f = -f;
                    }

                    double pp = novo.lenses(f, p);
                    double objt = novo.lens(o, f, p);
                    double amplian = novo.ampliacao(o, f, p);

                    int ap = (2 * f);


                    pbPrincipal.Visible = false;
                    lblAi.Visible = false;
                    lblAo.Visible = false;
                    lblFo.Visible = false;
                    lblFi.Visible = false;

                    String tipoLente = cbTipoLente.SelectedItem.ToString();

                    for (int i = 1; i <= 50; i++)
                    {
                        lbResultado.Items.Clear();
                        lbResultado.Items.Add("Distância imagem/lente (p'):  " + pp);
                        lbResultado.Items.Add("Tamanho da imagem (i):   " + objt);
                        lbResultado.Items.Add("Aumento linear ( A ):   " + amplian);

                    }



                    //("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊")

                    //DIVERGENTE
                    if (cbTipoLente.Text == "Divergente")
                    {

                        this.pbDivergente.Visible = true;
                        lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                        lbResultado.Items.Add("       FORMAÇÃO DE IMAGEM     ");
                        lbResultado.Items.Add("         ➖ Direita");
                        lbResultado.Items.Add("         ➖ Menor");
                        lbResultado.Items.Add("         ➖ Virtual");
                    }
                    else
                        this.pbDivergente.Visible = false;

                    if (cbTipoLente.Text == "Convergente")
                    {
                        //Objeto posicionado depois do antiprincipal objeto
                        if (p > ap)
                        {
                            this.pbDA.Visible = true;
                            lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                            lbResultado.Items.Add("     FORMAÇÃO DE IMAGEM     ");
                            lbResultado.Items.Add("      ➖ Invertida");
                            lbResultado.Items.Add("      ➖ Menor");
                            lbResultado.Items.Add("      ➖ Real");
                        }
                        else
                            this.pbDA.Visible = false;

                        //Objeto posicionado no antiprincipal objeto
                        if (p == ap)
                        {
                            this.pbA.Visible = true;
                            lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                            lbResultado.Items.Add("     FORMAÇÃO DE IMAGEM     ");
                            lbResultado.Items.Add("         ➖ Invertida");
                            lbResultado.Items.Add("         ➖ Igual");
                            lbResultado.Items.Add("         ➖ Real");
                        }
                        else
                            this.pbA.Visible = false;

                        //Objeto posicionado entre o antiprincipal objeto e o foco
                        if (p < ap && p > f)
                        {
                            this.pbEAF.Visible = true;
                            lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                            lbResultado.Items.Add("     FORMAÇÃO DE IMAGEM     ");
                            lbResultado.Items.Add("         ➖ Invertida");
                            lbResultado.Items.Add("         ➖ Maior");
                            lbResultado.Items.Add("         ➖ Real");
                        }
                        else
                            this.pbEAF.Visible = false;

                        //Objeto posicionado entre o foco e o centro óptico
                        if (p < f)
                        {
                            this.pbEFCO.Visible = true;
                            lbResultado.Items.Add("🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊🌊");
                            lbResultado.Items.Add("         FORMAÇÃO DE IMAGEM  ");
                            lbResultado.Items.Add("         ➖ Direita");
                            lbResultado.Items.Add("         ➖ Maior");
                            lbResultado.Items.Add("         ➖ Virtual");
                        }
                        else
                            this.pbEFCO.Visible = false;

                    }
                }
            }
            else
            {
                string result = "";
                result = "INFORME O TIPO DE LENTE!!!!";
                MessageBox.Show(result);
            }
        }

        private void LimparCampos()
        {
            txtF.Clear();
            txtP.Clear();
            txtO.Clear();
            cbTipoLente.SelectedIndex = -1;
            lbResultado.Items.Clear();

            pbPrincipal.Visible = true;
            lblAi.Visible = true;
            lblAo.Visible = true;
            lblFo.Visible = true;
            lblFi.Visible = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja limpar os itens?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
            }
        }

        private void tiposDeLentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposDeLentes ajuda = new TiposDeLentes();
            ajuda.Show();
        }

        private void divergenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Divergente_Raios tipos = new Divergente_Raios();
            tipos.Show();
        }

        private void convergenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nvergente_Raios outrotipos = new nvergente_Raios();
            outrotipos.Show();
        }

        private void utilizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilidades utilizacao = new utilidades();
            utilizacao.Show();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblAo_Click(object sender, EventArgs e)
        {

        }

        private void reflexaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reflexao refletion = new reflexao();
            refletion.Show();

        }
    }
    }

