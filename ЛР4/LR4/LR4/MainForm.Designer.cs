namespace CarSalesApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            // Лейбли
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ----- Labels -----
            this.lblType.Text = "Вид:";
            this.lblType.Location = new System.Drawing.Point(30, 10);

            this.lblBrand.Text = "Марка:";
            this.lblBrand.Location = new System.Drawing.Point(30, 40);

            this.lblManufacturer.Text = "Виробник:";
            this.lblManufacturer.Location = new System.Drawing.Point(30, 70);

            this.lblSupplier.Text = "Постачальник:";
            this.lblSupplier.Location = new System.Drawing.Point(30, 100);

            this.lblPrice.Text = "Ціна:";
            this.lblPrice.Location = new System.Drawing.Point(30, 130);

            this.lblSearch.Text = "Пошук за маркою:";
            this.lblSearch.Location = new System.Drawing.Point(400, 10);

            // ----- TextBoxes -----
            this.txtType.Location = new System.Drawing.Point(150, 10);
            this.txtType.Size = new System.Drawing.Size(200, 20);

            this.txtBrand.Location = new System.Drawing.Point(150, 40);
            this.txtBrand.Size = new System.Drawing.Size(200, 20);

            this.txtManufacturer.Location = new System.Drawing.Point(150, 70);
            this.txtManufacturer.Size = new System.Drawing.Size(200, 20);

            this.txtSupplier.Location = new System.Drawing.Point(150, 100);
            this.txtSupplier.Size = new System.Drawing.Size(200, 20);

            this.txtPrice.Location = new System.Drawing.Point(150, 130);
            this.txtPrice.Size = new System.Drawing.Size(200, 20);

            this.txtSearch.Location = new System.Drawing.Point(400, 30);
            this.txtSearch.Size = new System.Drawing.Size(150, 20);

            // ----- Buttons -----
            this.btnAdd.Location = new System.Drawing.Point(400, 70);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Додати";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(510, 70);
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.Text = "Редагувати";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnSearch.Location = new System.Drawing.Point(560, 30);
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.Text = "Пошук";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // ----- DataGridView -----
            this.dataGridView1.Location = new System.Drawing.Point(30, 180);
            this.dataGridView1.Size = new System.Drawing.Size(610, 250);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // ----- Form -----
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);

            // Лейбли на форму
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSearch);

            this.Name = "MainForm";
            this.Text = "Облік продажу автомашин";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;

        // Лейбли
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSearch;
    }
}
