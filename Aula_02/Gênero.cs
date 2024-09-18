using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_02.MODEL;

namespace Aula_02
{
    public partial class Gênero : Form
    {
        private bool Incluir = true;
        public Gênero()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = GENERO.ListarTodos();

        }
        private void Gênero_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidaControles()
        {
            int Codigo;
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("O campo código é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            else if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            else if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo código não é numérico", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;

            }
            return true;

        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            txtNome.Text = "";
        }


        private void TxtCodigo_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {

                if (Incluir)
                {
                    GENERO oGenero = new GENERO
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nome = txtNome.Text

                    };

                    //GENERO.IncluirGeneroStatic(oGenero);
                    try
                    {
                        oGenero.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu a incluir um gênero: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                    }

                }
                else
                {
                    GENERO oGenero = new GENERO
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nome = txtNome.Text

                    };
                    try
                    {
                        GENERO.Alterar(oGenero);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu a alterar um gênero: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                    }

                }


            }
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                GENERO objSelecionado = (GENERO)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "ALTERAR")
                {
                    TxtCodigo.Text = objSelecionado.Codigo.ToString();
                    txtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
                    txtNome.Focus();
                    Incluir = false;

                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "EXCLUIR")
                {
                    if (MessageBox.Show("Confime a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }

                }
            }
        }
    }
}

