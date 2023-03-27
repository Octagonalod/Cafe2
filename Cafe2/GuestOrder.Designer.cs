namespace Cafe2
{
    partial class GuestOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelAmnt = new System.Windows.Forms.Label();
            this.SellerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OrderNumTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGv);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LabelAmnt);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.OrderNumTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(289, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 687);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(627, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rs";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datelbl.ForeColor = System.Drawing.Color.DeepPink;
            this.Datelbl.Location = new System.Drawing.Point(771, 12);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(58, 27);
            this.Datelbl.TabIndex = 13;
            this.Datelbl.Text = "Date";
            // 
            // QtyTb
            // 
            this.QtyTb.BackColor = System.Drawing.Color.White;
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.QtyTb.ForeColor = System.Drawing.Color.Black;
            this.QtyTb.HintForeColor = System.Drawing.Color.White;
            this.QtyTb.HintText = "";
            this.QtyTb.isPassword = false;
            this.QtyTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.QtyTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineThickness = 3;
            this.QtyTb.Location = new System.Drawing.Point(329, 313);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QtyTb.Size = new System.Drawing.Size(162, 33);
            this.QtyTb.TabIndex = 12;
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(452, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Place the order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(554, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your Order";
            // 
            // OrdersGv
            // 
            this.OrdersGv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGv.Location = new System.Drawing.Point(329, 403);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.Size = new System.Drawing.Size(541, 211);
            this.OrdersGv.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(541, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelAmnt
            // 
            this.LabelAmnt.AutoSize = true;
            this.LabelAmnt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAmnt.ForeColor = System.Drawing.Color.DeepPink;
            this.LabelAmnt.Location = new System.Drawing.Point(759, 636);
            this.LabelAmnt.Name = "LabelAmnt";
            this.LabelAmnt.Size = new System.Drawing.Size(126, 27);
            this.LabelAmnt.TabIndex = 7;
            this.LabelAmnt.Text = "Order value";
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.BackColor = System.Drawing.Color.White;
            this.SellerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerNameTb.Enabled = false;
            this.SellerNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SellerNameTb.ForeColor = System.Drawing.Color.Black;
            this.SellerNameTb.HintForeColor = System.Drawing.Color.White;
            this.SellerNameTb.HintText = "";
            this.SellerNameTb.isPassword = false;
            this.SellerNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SellerNameTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.SellerNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.SellerNameTb.LineThickness = 3;
            this.SellerNameTb.Location = new System.Drawing.Point(23, 168);
            this.SellerNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(162, 33);
            this.SellerNameTb.TabIndex = 6;
            this.SellerNameTb.Text = "Guest";
            this.SellerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OrderNumTb
            // 
            this.OrderNumTb.BackColor = System.Drawing.Color.White;
            this.OrderNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderNumTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OrderNumTb.ForeColor = System.Drawing.Color.Black;
            this.OrderNumTb.HintForeColor = System.Drawing.Color.White;
            this.OrderNumTb.HintText = "";
            this.OrderNumTb.isPassword = false;
            this.OrderNumTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.OrderNumTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.OrderNumTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.OrderNumTb.LineThickness = 3;
            this.OrderNumTb.Location = new System.Drawing.Point(23, 112);
            this.OrderNumTb.Margin = new System.Windows.Forms.Padding(4);
            this.OrderNumTb.Name = "OrderNumTb";
            this.OrderNumTb.Size = new System.Drawing.Size(162, 33);
            this.OrderNumTb.TabIndex = 5;
            this.OrderNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ItemsGV
            // 
            this.ItemsGV.AllowUserToAddRows = false;
            this.ItemsGV.AllowUserToDeleteRows = false;
            this.ItemsGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(329, 55);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.ReadOnly = true;
            this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGV.Size = new System.Drawing.Size(541, 211);
            this.ItemsGV.TabIndex = 4;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Snacks",
            "Drinks"});
            this.categorycb.Location = new System.Drawing.Point(23, 55);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(191, 35);
            this.categorycb.TabIndex = 3;
            this.categorycb.Text = "Category";
            this.categorycb.SelectionChangeCommitted += new System.EventHandler(this.categorycb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(576, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 688);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1187, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DeepPink;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(714, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 36);
            this.button7.TabIndex = 19;
            this.button7.Text = "New order";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1209, 723);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrdersGv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelAmnt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderNumTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
    }
}