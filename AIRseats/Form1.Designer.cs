namespace AIRseats
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txtcode = new TextBox();
            label5 = new Label();
            btnasigne = new Button();
            btnfree = new Button();
            txtload = new TextBox();
            label2 = new Label();
            txtname1 = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            txtname2 = new TextBox();
            txtname3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 41);
            label1.TabIndex = 0;
            label1.Text = "Box Assign";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Cursor = Cursors.Hand;
            lbl1.Font = new Font("Segoe UI Light", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(43, 104);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(145, 100);
            lbl1.TabIndex = 1;
            lbl1.Text = "📦";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Cursor = Cursors.Hand;
            lbl2.Font = new Font("Segoe UI Light", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(194, 104);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(145, 100);
            lbl2.TabIndex = 2;
            lbl2.Text = "📦";
            lbl2.Click += lbl2_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Cursor = Cursors.Hand;
            lbl3.Font = new Font("Segoe UI Light", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(345, 104);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(145, 100);
            lbl3.TabIndex = 3;
            lbl3.Text = "📦";
            lbl3.Click += lbl3_Click;
            // 
            // txtcode
            // 
            txtcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcode.Location = new Point(148, 256);
            txtcode.Name = "txtcode";
            txtcode.PlaceholderText = "code";
            txtcode.Size = new Size(226, 34);
            txtcode.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(140, 228);
            label5.Name = "label5";
            label5.Size = new Size(241, 20);
            label5.TabIndex = 5;
            label5.Text = "Please enter a box code to asigned";
            // 
            // btnasigne
            // 
            btnasigne.BackColor = Color.Black;
            btnasigne.Cursor = Cursors.Hand;
            btnasigne.FlatAppearance.BorderSize = 0;
            btnasigne.FlatStyle = FlatStyle.Flat;
            btnasigne.ForeColor = Color.White;
            btnasigne.Location = new Point(140, 420);
            btnasigne.Name = "btnasigne";
            btnasigne.Size = new Size(226, 34);
            btnasigne.TabIndex = 6;
            btnasigne.Text = "Assign";
            btnasigne.UseVisualStyleBackColor = false;
            btnasigne.Click += btnasigne_Click_1;
            // 
            // btnfree
            // 
            btnfree.BackColor = Color.Black;
            btnfree.Cursor = Cursors.Hand;
            btnfree.FlatAppearance.BorderSize = 0;
            btnfree.FlatStyle = FlatStyle.Flat;
            btnfree.ForeColor = Color.White;
            btnfree.Location = new Point(140, 460);
            btnfree.Name = "btnfree";
            btnfree.Size = new Size(226, 34);
            btnfree.TabIndex = 7;
            btnfree.Text = "Free";
            btnfree.UseVisualStyleBackColor = false;
            btnfree.Click += btnfree_Click;
            // 
            // txtload
            // 
            txtload.BackColor = SystemColors.Control;
            txtload.BorderStyle = BorderStyle.None;
            txtload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtload.Location = new Point(508, 483);
            txtload.Name = "txtload";
            txtload.PlaceholderText = "0";
            txtload.Size = new Size(38, 20);
            txtload.TabIndex = 9;
            txtload.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 483);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 10;
            label2.Text = "Seats asigned:";
            // 
            // txtname1
            // 
            txtname1.BackColor = SystemColors.Control;
            txtname1.BorderStyle = BorderStyle.None;
            txtname1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname1.Location = new Point(63, 93);
            txtname1.Name = "txtname1";
            txtname1.PlaceholderText = "name";
            txtname1.Size = new Size(95, 20);
            txtname1.TabIndex = 11;
            txtname1.TextAlign = HorizontalAlignment.Center;
            txtname1.TextChanged += txtname1_TextChanged;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(148, 310);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "name";
            txtname.Size = new Size(226, 34);
            txtname.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 8);
            label3.Name = "label3";
            label3.Size = new Size(59, 41);
            label3.TabIndex = 13;
            label3.Text = "📬";
            // 
            // txtname2
            // 
            txtname2.BackColor = SystemColors.Control;
            txtname2.BorderStyle = BorderStyle.None;
            txtname2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname2.Location = new Point(212, 93);
            txtname2.Name = "txtname2";
            txtname2.PlaceholderText = "name";
            txtname2.Size = new Size(95, 20);
            txtname2.TabIndex = 14;
            txtname2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtname3
            // 
            txtname3.BackColor = SystemColors.Control;
            txtname3.BorderStyle = BorderStyle.None;
            txtname3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname3.Location = new Point(364, 93);
            txtname3.Name = "txtname3";
            txtname3.PlaceholderText = "name";
            txtname3.Size = new Size(95, 20);
            txtname3.TabIndex = 15;
            txtname3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 507);
            Controls.Add(txtname3);
            Controls.Add(txtname2);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(txtname1);
            Controls.Add(label2);
            Controls.Add(txtload);
            Controls.Add(btnfree);
            Controls.Add(btnasigne);
            Controls.Add(label5);
            Controls.Add(txtcode);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtcode;
        private Label label5;
        private Button btnasigne;
        private Button btnfree;
        private TextBox txtload;
        private Label label2;
        private TextBox txtname1;
        private TextBox txtname;
        private Label label3;
        private TextBox txtname2;
        private TextBox txtname3;
    }
}
