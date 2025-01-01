using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MarketMate.adminUserControls
{
    public partial class ManageCategories : UserControl
    {
        public ManageCategories()
        {
            InitializeComponent();
            this.Load += ManageCategories_Load;
            showCategories.CellClick += showCategories_CellClick;
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            InitializeDBConnection();
        }

        private void InitializeDBConnection()
        {
            try
            {
                if (dbConn.GetConnection().State == ConnectionState.Closed)
                {
                    dbConn.GetConnection().Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            // Validate the input before proceeding
            if (string.IsNullOrWhiteSpace(categoryTxt.Text))
            {
                MessageBox.Show("Please enter a valid Category Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    // SQL query to insert a new category
                    string insertQuery = @"INSERT INTO Category (CategoryName) 
                                   VALUES (@CategoryName);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CategoryName", categoryTxt.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            categoryTxt.Clear();

                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle unique constraint violation or other database errors
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("A category with this name already exists. Please enter a unique name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding the category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RefreshData()
        {
            LoadCategoryRecords();
        }

        private void LoadCategoryRecords()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    string query = @"SELECT 
                                CategoryName AS [Category Name],
                                CategoryID AS [Category ID]
                             FROM Category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        showCategories.DataSource = dt;

                        // Optional: Adjust DataGridView properties
                        showCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        showCategories.AllowUserToAddRows = false; 
                        showCategories.ReadOnly = true; 
                        showCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void showCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row and not the header or an empty area
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = showCategories.Rows[e.RowIndex];

                // Populate the text fields
                categoryIDTxt.Text = selectedRow.Cells["Category ID"].Value.ToString();
                categoryNameTxt.Text = selectedRow.Cells["Category Name"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (string.IsNullOrWhiteSpace(categoryIDTxt.Text) || !int.TryParse(categoryIDTxt.Text, out int categoryId))
            {
                MessageBox.Show("Please enter a valid Category ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryNameTxt.Text))
            {
                MessageBox.Show("Please enter a valid Category Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the category name in the database
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    // SQL query to update the category name
                    string updateQuery = @"UPDATE Category 
                                   SET CategoryName = @CategoryName 
                                   WHERE CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@CategoryName", categoryNameTxt.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshData();

                            categoryIDTxt.Clear();
                            categoryNameTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle unique constraint violation or other database errors
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("A category with this name already exists. Please enter a unique name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while updating the category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
