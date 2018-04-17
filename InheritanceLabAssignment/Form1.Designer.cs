namespace InheritanceLabAssignment
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDisplayCars = new System.Windows.Forms.Button();
            this.btnMostExpensiveCar = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomerID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.btnLeastExpensive = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(14, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(983, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Make";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mileage";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Year";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Engine Size";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Average Mpg";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Zero to Sixty";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Max Towing";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Type";
            // 
            // btnDisplayCars
            // 
            this.btnDisplayCars.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDisplayCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplayCars.Location = new System.Drawing.Point(1027, 79);
            this.btnDisplayCars.Name = "btnDisplayCars";
            this.btnDisplayCars.Size = new System.Drawing.Size(129, 68);
            this.btnDisplayCars.TabIndex = 1;
            this.btnDisplayCars.Text = "Display Cars";
            this.btnDisplayCars.UseVisualStyleBackColor = false;
            this.btnDisplayCars.Click += new System.EventHandler(this.btnDisplayCars_Click);
            // 
            // btnMostExpensiveCar
            // 
            this.btnMostExpensiveCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostExpensiveCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostExpensiveCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostExpensiveCar.Location = new System.Drawing.Point(1027, 153);
            this.btnMostExpensiveCar.Name = "btnMostExpensiveCar";
            this.btnMostExpensiveCar.Size = new System.Drawing.Size(129, 68);
            this.btnMostExpensiveCar.TabIndex = 2;
            this.btnMostExpensiveCar.Text = "Luxurious Car";
            this.btnMostExpensiveCar.UseVisualStyleBackColor = false;
            this.btnMostExpensiveCar.Click += new System.EventHandler(this.btnMostExpensiveCar_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilters.Location = new System.Drawing.Point(14, 411);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(224, 47);
            this.btnFilters.TabIndex = 3;
            this.btnFilters.Text = "Apply Filters";
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILTER";
            // 
            // cboMake
            // 
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(14, 361);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(224, 31);
            this.cboMake.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(266, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerID";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.FormattingEnabled = true;
            this.cboCustomerID.Location = new System.Drawing.Point(270, 361);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Size = new System.Drawing.Size(224, 31);
            this.cboCustomerID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(516, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(520, 361);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(224, 31);
            this.cboType.TabIndex = 9;
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // btnLeastExpensive
            // 
            this.btnLeastExpensive.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLeastExpensive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeastExpensive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeastExpensive.Location = new System.Drawing.Point(1027, 227);
            this.btnLeastExpensive.Name = "btnLeastExpensive";
            this.btnLeastExpensive.Size = new System.Drawing.Size(129, 68);
            this.btnLeastExpensive.TabIndex = 11;
            this.btnLeastExpensive.Text = "Cheap";
            this.btnLeastExpensive.UseVisualStyleBackColor = false;
            this.btnLeastExpensive.Click += new System.EventHandler(this.btnLeastExpensive_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalPrice.Location = new System.Drawing.Point(897, 362);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(84, 28);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(769, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Price:";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(389, 420);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(189, 31);
            this.txtNewPrice.TabIndex = 14;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePrice.Location = new System.Drawing.Point(629, 413);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(368, 43);
            this.btnChangePrice.TabIndex = 15;
            this.btnChangePrice.Text = "Change Price of Selected Car";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(266, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnLeastExpensive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.btnMostExpensiveCar);
            this.Controls.Add(this.btnDisplayCars);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Customers And Vehicles";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDisplayCars;
        private System.Windows.Forms.Button btnMostExpensiveCar;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnLeastExpensive;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label label6;
    }
}

