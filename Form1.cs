using System.Data;
using System.Data.SqlClient;

namespace Library_Catalogue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImportLibraryCatalog();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDb)\\dbONE;Initial Catalog=LibDB;Integrated Security=True");
        public int ID = 0;
        private void ImportLibraryCatalog()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Catalogue", conn);
            DataTable dT = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dT.Load(sdr);
            conn.Close();

            bookList.DataSource = dT;
        }

        private void Insert_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Catalogue VALUES (@Book , @Author , @Genre , @Date)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Book", bookTxt.Text);
                cmd.Parameters.AddWithValue("@Author", authorTxt.Text);
                cmd.Parameters.AddWithValue("@Genre", genreTxt.Text);
                cmd.Parameters.AddWithValue("@Date", dateTxt.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                ImportLibraryCatalog();
                MessageBox.Show(" New book has been successfully added to the catalogue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
        }

        private void ResetFields()
        {
            ID = 0;
            bookTxt.Text = string.Empty; authorTxt.Text = string.Empty; genreTxt.Text = string.Empty; dateTxt.Text = string.Empty;
            bookTxt.Focus();
        }

        private bool IsValid()
        {
            if (bookTxt.Text == string.Empty || authorTxt.Text == string.Empty || genreTxt.Text == string.Empty || dateTxt.Text == string.Empty)
            {
                MessageBox.Show(" Enter books details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Catalogue SET Book = @Book , Author = @Author , Genre = @Genre , Date = @Date WHERE ID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Book", bookTxt.Text);
                cmd.Parameters.AddWithValue("@Author", authorTxt.Text);
                cmd.Parameters.AddWithValue("@Genre", genreTxt.Text);
                cmd.Parameters.AddWithValue("@Date", dateTxt.Text);
                cmd.Parameters.AddWithValue("ID", this.ID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                ImportLibraryCatalog();
                MessageBox.Show(" Book has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Select a book to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(bookList.SelectedRows[0].Cells[0].Value);
            bookTxt.Text = bookList.SelectedRows[0].Cells[1].Value.ToString();
            authorTxt.Text = bookList.SelectedRows[0].Cells[2].Value.ToString();
            genreTxt.Text = bookList.SelectedRows[0].Cells[3].Value.ToString();
            dateTxt.Text = bookList.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Catalogue WHERE ID = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("ID", this.ID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                ImportLibraryCatalog();
                MessageBox.Show(" Book has been successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
            else
            {
                MessageBox.Show("Select a book to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
