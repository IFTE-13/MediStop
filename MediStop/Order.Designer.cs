
namespace MediStop
{
    partial class Order
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPreviewProductCompany = new System.Windows.Forms.Label();
            this.txtPreviewPorductPrice = new System.Windows.Forms.TextBox();
            this.txtPreviewProductCompany = new System.Windows.Forms.TextBox();
            this.lblPreviewPorductPrice = new System.Windows.Forms.Label();
            this.txtPreviewProductName = new System.Windows.Forms.TextBox();
            this.txtPreviewProductID = new System.Windows.Forms.TextBox();
            this.lblPreviewProductID = new System.Windows.Forms.Label();
            this.lblPreviewProductName = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.OrderedProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedProductCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductOrder = new System.Windows.Forms.DataGridView();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.dtpPlaceOrder = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.btnAddToCart);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblPreviewProductCompany);
            this.panel2.Controls.Add(this.txtPreviewPorductPrice);
            this.panel2.Controls.Add(this.txtPreviewProductCompany);
            this.panel2.Controls.Add(this.lblPreviewPorductPrice);
            this.panel2.Controls.Add(this.txtPreviewProductName);
            this.panel2.Controls.Add(this.txtPreviewProductID);
            this.panel2.Controls.Add(this.lblPreviewProductID);
            this.panel2.Controls.Add(this.lblPreviewProductName);
            this.panel2.Location = new System.Drawing.Point(18, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 89);
            this.panel2.TabIndex = 36;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(837, 16);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 50;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(882, 54);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 49;
            this.btnAddToCart.Text = "Update Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(701, 19);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 45;
            this.lblQuantity.Text = "Qunatity";
            // 
            // lblPreviewProductCompany
            // 
            this.lblPreviewProductCompany.AutoSize = true;
            this.lblPreviewProductCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewProductCompany.Location = new System.Drawing.Point(64, 58);
            this.lblPreviewProductCompany.Name = "lblPreviewProductCompany";
            this.lblPreviewProductCompany.Size = new System.Drawing.Size(59, 15);
            this.lblPreviewProductCompany.TabIndex = 44;
            this.lblPreviewProductCompany.Text = "Company";
            // 
            // txtPreviewPorductPrice
            // 
            this.txtPreviewPorductPrice.BackColor = System.Drawing.Color.White;
            this.txtPreviewPorductPrice.Location = new System.Drawing.Point(518, 55);
            this.txtPreviewPorductPrice.Name = "txtPreviewPorductPrice";
            this.txtPreviewPorductPrice.ReadOnly = true;
            this.txtPreviewPorductPrice.Size = new System.Drawing.Size(123, 20);
            this.txtPreviewPorductPrice.TabIndex = 43;
            // 
            // txtPreviewProductCompany
            // 
            this.txtPreviewProductCompany.BackColor = System.Drawing.Color.White;
            this.txtPreviewProductCompany.Location = new System.Drawing.Point(197, 55);
            this.txtPreviewProductCompany.Name = "txtPreviewProductCompany";
            this.txtPreviewProductCompany.ReadOnly = true;
            this.txtPreviewProductCompany.Size = new System.Drawing.Size(123, 20);
            this.txtPreviewProductCompany.TabIndex = 41;
            // 
            // lblPreviewPorductPrice
            // 
            this.lblPreviewPorductPrice.AutoSize = true;
            this.lblPreviewPorductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewPorductPrice.Location = new System.Drawing.Point(385, 58);
            this.lblPreviewPorductPrice.Name = "lblPreviewPorductPrice";
            this.lblPreviewPorductPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPreviewPorductPrice.TabIndex = 42;
            this.lblPreviewPorductPrice.Text = "Price";
            // 
            // txtPreviewProductName
            // 
            this.txtPreviewProductName.BackColor = System.Drawing.Color.White;
            this.txtPreviewProductName.Location = new System.Drawing.Point(518, 16);
            this.txtPreviewProductName.Name = "txtPreviewProductName";
            this.txtPreviewProductName.ReadOnly = true;
            this.txtPreviewProductName.Size = new System.Drawing.Size(123, 20);
            this.txtPreviewProductName.TabIndex = 40;
            // 
            // txtPreviewProductID
            // 
            this.txtPreviewProductID.BackColor = System.Drawing.Color.White;
            this.txtPreviewProductID.Location = new System.Drawing.Point(197, 16);
            this.txtPreviewProductID.Name = "txtPreviewProductID";
            this.txtPreviewProductID.ReadOnly = true;
            this.txtPreviewProductID.Size = new System.Drawing.Size(123, 20);
            this.txtPreviewProductID.TabIndex = 38;
            // 
            // lblPreviewProductID
            // 
            this.lblPreviewProductID.AutoSize = true;
            this.lblPreviewProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewProductID.Location = new System.Drawing.Point(64, 19);
            this.lblPreviewProductID.Name = "lblPreviewProductID";
            this.lblPreviewProductID.Size = new System.Drawing.Size(64, 15);
            this.lblPreviewProductID.TabIndex = 37;
            this.lblPreviewProductID.Text = "Product ID";
            // 
            // lblPreviewProductName
            // 
            this.lblPreviewProductName.AutoSize = true;
            this.lblPreviewProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewProductName.Location = new System.Drawing.Point(385, 19);
            this.lblPreviewProductName.Name = "lblPreviewProductName";
            this.lblPreviewProductName.Size = new System.Drawing.Size(86, 15);
            this.lblPreviewProductName.TabIndex = 39;
            this.lblPreviewProductName.Text = "Porduct Name";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderedProductID,
            this.OrderedProductName,
            this.OrderedProductCompany,
            this.OrderPrice,
            this.OrderQuantity,
            this.TotalPrice});
            this.dgvOrder.Location = new System.Drawing.Point(498, 245);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(551, 292);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.DoubleClick += new System.EventHandler(this.dgvOrder_DoubleClick);
            // 
            // OrderedProductID
            // 
            this.OrderedProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderedProductID.DataPropertyName = "ID";
            this.OrderedProductID.HeaderText = "ProductID";
            this.OrderedProductID.MinimumWidth = 6;
            this.OrderedProductID.Name = "OrderedProductID";
            this.OrderedProductID.ReadOnly = true;
            // 
            // OrderedProductName
            // 
            this.OrderedProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderedProductName.DataPropertyName = "Name";
            this.OrderedProductName.HeaderText = "ProductName";
            this.OrderedProductName.MinimumWidth = 6;
            this.OrderedProductName.Name = "OrderedProductName";
            this.OrderedProductName.ReadOnly = true;
            // 
            // OrderedProductCompany
            // 
            this.OrderedProductCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderedProductCompany.DataPropertyName = "Company";
            this.OrderedProductCompany.HeaderText = "Company";
            this.OrderedProductCompany.MinimumWidth = 6;
            this.OrderedProductCompany.Name = "OrderedProductCompany";
            this.OrderedProductCompany.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderPrice.DataPropertyName = "Price";
            this.OrderPrice.HeaderText = "Price";
            this.OrderPrice.MinimumWidth = 6;
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderQuantity.DataPropertyName = "Quantity";
            this.OrderQuantity.HeaderText = "Quantity";
            this.OrderQuantity.MinimumWidth = 6;
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // dgvProductOrder
            // 
            this.dgvProductOrder.AllowUserToAddRows = false;
            this.dgvProductOrder.AllowUserToDeleteRows = false;
            this.dgvProductOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Company,
            this.Price});
            this.dgvProductOrder.Location = new System.Drawing.Point(18, 245);
            this.dgvProductOrder.Name = "dgvProductOrder";
            this.dgvProductOrder.ReadOnly = true;
            this.dgvProductOrder.RowHeadersWidth = 51;
            this.dgvProductOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductOrder.Size = new System.Drawing.Size(474, 292);
            this.dgvProductOrder.TabIndex = 1;
            this.dgvProductOrder.DoubleClick += new System.EventHandler(this.dgvProductOrder_DoubleClick);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(896, 52);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(84, 24);
            this.btnPlaceOrder.TabIndex = 47;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(857, 15);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(123, 23);
            this.txtPrice.TabIndex = 46;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(777, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 45;
            this.lblPrice.Text = "Price";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(344, 57);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(102, 17);
            this.lblPurchaseDate.TabIndex = 44;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // dtpPlaceOrder
            // 
            this.dtpPlaceOrder.CustomFormat = "yyyy-MM-dd";
            this.dtpPlaceOrder.Enabled = false;
            this.dtpPlaceOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlaceOrder.Location = new System.Drawing.Point(483, 53);
            this.dtpPlaceOrder.Name = "dtpPlaceOrder";
            this.dtpPlaceOrder.Size = new System.Drawing.Size(123, 23);
            this.dtpPlaceOrder.TabIndex = 43;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(344, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 37;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(483, 15);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(123, 23);
            this.txtCustomerName.TabIndex = 38;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(157, 53);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(123, 23);
            this.txtCustomerPhone.TabIndex = 42;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(24, 19);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerID.TabIndex = 39;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(24, 57);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(49, 17);
            this.lblPhoneNo.TabIndex = 41;
            this.lblPhoneNo.Text = "Phone";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.Location = new System.Drawing.Point(157, 15);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(123, 23);
            this.txtCustomerID.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlaceOrder);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblPurchaseDate);
            this.groupBox1.Controls.Add(this.dtpPlaceOrder);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.lblPhoneNo);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 103);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Available Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Selected Products";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.dgvProductOrder);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1072, 537);
            this.Load += new System.EventHandler(this.Order_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridView dgvProductOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPreviewProductCompany;
        private System.Windows.Forms.TextBox txtPreviewPorductPrice;
        private System.Windows.Forms.TextBox txtPreviewProductCompany;
        private System.Windows.Forms.Label lblPreviewPorductPrice;
        private System.Windows.Forms.TextBox txtPreviewProductName;
        private System.Windows.Forms.TextBox txtPreviewProductID;
        private System.Windows.Forms.Label lblPreviewProductID;
        private System.Windows.Forms.Label lblPreviewProductName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedProductCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtpPlaceOrder;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
