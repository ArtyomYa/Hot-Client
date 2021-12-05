namespace Project_Hot
{
    partial class Username
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Active = new System.Windows.Forms.CheckBox();
            this.Inactive = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 93);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(24, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(24, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(485, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 64);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(666, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 64);
            this.button1.TabIndex = 19;
            this.button1.Text = "Creat User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(830, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 64);
            this.button3.TabIndex = 20;
            this.button3.Text = "Show Users";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(1003, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 64);
            this.button4.TabIndex = 21;
            this.button4.Text = "Delete User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Active.Location = new System.Drawing.Point(151, 362);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(83, 24);
            this.Active.TabIndex = 22;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // Inactive
            // 
            this.Inactive.AutoSize = true;
            this.Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Inactive.Location = new System.Drawing.Point(151, 392);
            this.Inactive.Name = "Inactive";
            this.Inactive.Size = new System.Drawing.Size(96, 24);
            this.Inactive.TabIndex = 23;
            this.Inactive.Text = "Inactive";
            this.Inactive.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.username1,
            this.Password,
            this.Status1});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(455, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 304);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 118;
            // 
            // username1
            // 
            this.username1.Text = "Username";
            this.username1.Width = 119;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 118;
            // 
            // Status1
            // 
            this.Status1.Text = "Status";
            this.Status1.Width = 118;
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 471);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Inactive);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Username";
            this.Text = "Username";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Username_FormClosed);
            this.Load += new System.EventHandler(this.Username_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.CheckBox Inactive;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader username1;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Status1;
    }
}