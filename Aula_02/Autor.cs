using Aula_02.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02
{
    public partial class Autor : Form
    {
        private bool Incluir = true;
        public Autor()
        {
            InitializeComponent();
        }

        private void CarregaAutor()
        {
            GrdAutor.AutoGenerateColumns = false;
            GrdAutor.DataSource = ClAutor.ListarAutor();
        }

        private void Autor_Load(object sender, EventArgs e)
        {
            CarregaAutor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool ValidaControles()
        {
            int Id;
            if (TxtId.Text.Trim() == "")
            {
                MessageBox.Show("O campo Id é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtId.Focus();
                return false;
            }
            else if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            else if (int.TryParse(TxtId.Text, out Id) == false)
            {
                MessageBox.Show("O campo código não é numérico", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtId.Focus();
                return false;

            }
            return true;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {

                if (Incluir)
                {
                    ClAutor oAutor = new ClAutor
                    {
                        Id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text

                    };

                    //GENERO.IncluirGeneroStatic(oGenero);
                    try
                    {
                        oAutor.Incluir();
                        CarregaAutor();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu a incluir um Autor: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNome.Focus();
                    }

                }
                else
                {
                    ClAutor oAutor = new ClAutor
                    {
                        Id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text

                    };
                    try
                    {
                        ClAutor.Alterar(oAutor);
                        CarregaAutor();
                        LimpaControles();
                        Incluir = true;
                        TxtId.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu a alterar um gênero: {ex.Message}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNome.Focus();
                    }

                }


            }
        }

        
        private void GrdAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdAutor.Rows[e.RowIndex].DataBoundItem != null)
            {
                ClAutor objSelecionado = (ClAutor)GrdAutor.Rows[e.RowIndex].DataBoundItem;
                if (GrdAutor.Columns[e.ColumnIndex].Name == "Alterar")
                {
                    TxtId.Text = objSelecionado.Id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtId.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;

                }
                else if (GrdAutor.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    if (MessageBox.Show("Confime a exclusão", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaAutor();
                    }

                }
            }
        }

        private void GrdAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
