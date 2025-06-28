using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarSalesApp
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarSales;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (Type, Brand, Manufacturer, Supplier, Price) VALUES (@Type, @Brand, @Manufacturer, @Supplier, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadCars();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Cars SET Type=@Type, Brand=@Brand, Manufacturer=@Manufacturer, Supplier=@Supplier, Price=@Price WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                    cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadCars();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars WHERE Brand LIKE @Brand";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Brand", "%" + txtSearch.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
                txtBrand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
                txtManufacturer.Text = dataGridView1.CurrentRow.Cells["Manufacturer"].Value.ToString();
                txtSupplier.Text = dataGridView1.CurrentRow.Cells["Supplier"].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            }
        }
    }
}
