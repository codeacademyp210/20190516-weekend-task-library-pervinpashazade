using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class AuthorForm : Form
    {

        Autor authorFounded = new Autor();
        public AuthorForm()
        {
            InitializeComponent();
            GenerateAuthorsForm();
        }

        private void GenerateAuthorsForm()
        {
            dgvAuthorsForm.Rows.Clear();

            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                List<Autor> authors = db.Autors.ToList();

                foreach (var author in authors)
                {
                    dgvAuthorsForm.Rows.Add(author.ID,
                                            author.Name,
                                            author.Surname);
                }
            }
        }

        private void BtnSaveAuthorsForm_Click(object sender, EventArgs e)
        {
            if (btnDeleteAuthorsForm.Enabled=false)
            {
                if (!UpdateAuthors())
                {
                    MessageBox.Show("Author was not updated", "ERROR");
                    return;
                }

                GenerateAuthorsForm();
                MessageBox.Show("New author was successfully updated");
            }
            else
            {
                if (!CreateAuthors())
                {
                    MessageBox.Show("Author was not created", "ERROR");
                    return;
                }

                GenerateAuthorsForm();
                MessageBox.Show("New author was successfully created");
            }
            ResetAuthorsForm();
            ResetAuthorsForm();
        }

        private bool UpdateAuthors()
        {
            int affectRows = 0;
            using (LibraryDBEntities db = new LibraryDBEntities())
            {

                Autor newAutor = db.Autors.Where(aut => aut.ID == authorFounded.ID).FirstOrDefault();

                newAutor.Name = txtBoxNameAuthor.Text;
                newAutor.Surname = txtBoxSurnameAuthor.Text;


                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private bool CreateAuthors()
        {
            int affectRows = 0;
            using (LibraryDBEntities db = new LibraryDBEntities())
            {

                Autor autor = new Autor()
                {
                    Name = txtBoxNameAuthor.Text,
                    Surname = txtBoxSurnameAuthor.Text
                };
                db.Autors.Add(autor);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private void DgvAuthorsForm_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int authorID = (int)dgvAuthorsForm.Rows[e.RowIndex].Cells[0].Value;

            using (LibraryDBEntities db = new LibraryDBEntities())
            {
                authorFounded = db.Autors.Where(a => a.ID == authorID).FirstOrDefault();
                if (authorFounded != null)
                {
                    txtBoxNameAuthor.Text = dgvAuthorsForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtBoxSurnameAuthor.Text = dgvAuthorsForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }

            btnSaveAuthorsForm.Text = "Update";
            btnDeleteAuthorsForm.Enabled = true;
        }

        private void ResetAuthorsForm()
        {
            txtBoxNameAuthor.Text = "";
            txtBoxSurnameAuthor.Text = "";

            btnSaveAuthorsForm.Text = "Save";
            btnDeleteAuthorsForm.Enabled = false;
        }

        private void BtnResetAuthorsForm_Click(object sender, EventArgs e)
        {
            ResetAuthorsForm();
        }

        private void BtnDeleteAuthorsForm_Click(object sender, EventArgs e)
        {

        }
    }
}
