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
            ImportLibraryCatalogue();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDb)\\dbONE;Initial Catalog=LibraryCatalog;Integrated Security=True");
        private void ImportLibraryCatalogue()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from LibraryCatalogue", conn);
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

            SqlCommand cmd = new SqlCommand("INSERT INTO LibraryCatalogue VALUES (@Book , @Author , @Genre , @PublishedDate)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Book", bookTxt.Text);
            cmd.Parameters.AddWithValue("@Author", authorTxt.Text);
            cmd.Parameters.AddWithValue("@Genre", genreTxt.Text);
            cmd.Parameters.AddWithValue("@PublishedDate", dateTxt.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(" New book has been successfully added to the catalogue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImportLibraryCatalogue();
            }
        }

        private bool IsValid()
        {
            try
            {
                if (bookTxt.Text == string.Empty)
                    throw new InvalidDataException(" Enter Book name.");
                else if (authorTxt.Text == string.Empty)
                    throw new InvalidDataException(" Enter Author name.");
                else if (genreTxt.Text == string.Empty)
                    throw new InvalidDataException(" Enter genre type.");
                else if (dateTxt.Text == string.Empty)
                    throw new InvalidDataException(" Enter publication date.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Message. {ex.Message}", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
            return true;
        }
    }
}