namespace lab9
{
    partial class Profile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Form));
            this.Edit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Password1_Textbox = new System.Windows.Forms.TextBox();
            this.Email_Textbox = new System.Windows.Forms.TextBox();
            this.Address_Textbox = new System.Windows.Forms.TextBox();
            this.Password2_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Button.BackgroundImage")));
            this.Edit_Button.Location = new System.Drawing.Point(12, 218);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(64, 60);
            this.Edit_Button.TabIndex = 5;
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(88, 78);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Username_Textbox.TabIndex = 6;
            this.Username_Textbox.TextChanged += new System.EventHandler(this.Username_Textbox_TextChanged);
            // 
            // Password1_Textbox
            // 
            this.Password1_Textbox.Location = new System.Drawing.Point(88, 106);
            this.Password1_Textbox.Name = "Password1_Textbox";
            this.Password1_Textbox.PasswordChar = '*';
            this.Password1_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Password1_Textbox.TabIndex = 7;
            this.Password1_Textbox.TextChanged += new System.EventHandler(this.Password1_Textbox_TextChanged);
            // 
            // Email_Textbox
            // 
            this.Email_Textbox.Location = new System.Drawing.Point(88, 162);
            this.Email_Textbox.Name = "Email_Textbox";
            this.Email_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Email_Textbox.TabIndex = 8;
            // 
            // Address_Textbox
            // 
            this.Address_Textbox.Location = new System.Drawing.Point(88, 190);
            this.Address_Textbox.Name = "Address_Textbox";
            this.Address_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Address_Textbox.TabIndex = 9;
            // 
            // Password2_Textbox
            // 
            this.Password2_Textbox.Location = new System.Drawing.Point(88, 134);
            this.Password2_Textbox.Name = "Password2_Textbox";
            this.Password2_Textbox.PasswordChar = '*';
            this.Password2_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Password2_Textbox.TabIndex = 11;
            this.Password2_Textbox.TextChanged += new System.EventHandler(this.Password1_Textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat \r\nPassword:";
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Button.BackgroundImage")));
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(64, 60);
            this.Back_Button.TabIndex = 12;
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reset_Button.BackgroundImage")));
            this.Reset_Button.Location = new System.Drawing.Point(82, 12);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(64, 60);
            this.Reset_Button.TabIndex = 13;
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 291);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Password2_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address_Textbox);
            this.Controls.Add(this.Email_Textbox);
            this.Controls.Add(this.Password1_Textbox);
            this.Controls.Add(this.Username_Textbox);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Profile_Form";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.TextBox Password1_Textbox;
        private System.Windows.Forms.TextBox Email_Textbox;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.TextBox Password2_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Reset_Button;
    }
}