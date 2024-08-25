﻿namespace FastFoodPOS.Forms
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.TextConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNameError = new System.Windows.Forms.Label();
            this.LabelEmailError = new System.Windows.Forms.Label();
            this.LabelPasswordError = new System.Windows.Forms.Label();
            this.LabelConfirmPasswordError = new System.Windows.Forms.Label();
            this.VisibilityToggler = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AutoRoundedCorners = true;
            this.BtnSubmit.BorderRadius = 21;
            this.BtnSubmit.FillColor = System.Drawing.Color.Peru;
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(35, 517);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(377, 45);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextConfirmPassword.DefaultText = "";
            this.TextConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.TextConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextConfirmPassword.Location = new System.Drawing.Point(35, 439);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.PasswordChar = '●';
            this.TextConfirmPassword.PlaceholderText = "";
            this.TextConfirmPassword.SelectedText = "";
            this.TextConfirmPassword.Size = new System.Drawing.Size(377, 36);
            this.TextConfirmPassword.TabIndex = 3;
            this.TextConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TextPassword
            // 
            this.TextPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPassword.DefaultText = "";
            this.TextPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextPassword.ForeColor = System.Drawing.Color.Black;
            this.TextPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPassword.Location = new System.Drawing.Point(35, 338);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '●';
            this.TextPassword.PlaceholderText = "";
            this.TextPassword.SelectedText = "";
            this.TextPassword.Size = new System.Drawing.Size(377, 36);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(31, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(31, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // TextEmail
            // 
            this.TextEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextEmail.DefaultText = "";
            this.TextEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextEmail.ForeColor = System.Drawing.Color.Black;
            this.TextEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextEmail.Location = new System.Drawing.Point(35, 238);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.PlaceholderText = "(e.g johndoe@position)";
            this.TextEmail.SelectedText = "";
            this.TextEmail.Size = new System.Drawing.Size(377, 36);
            this.TextEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(31, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // TextName
            // 
            this.TextName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextName.DefaultText = "";
            this.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextName.ForeColor = System.Drawing.Color.Black;
            this.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.Location = new System.Drawing.Point(35, 137);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "(e.g John Doe)";
            this.TextName.SelectedText = "";
            this.TextName.Size = new System.Drawing.Size(377, 36);
            this.TextName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(31, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 70);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            // 
            // LabelNameError
            // 
            this.LabelNameError.AutoSize = true;
            this.LabelNameError.ForeColor = System.Drawing.Color.Red;
            this.LabelNameError.Location = new System.Drawing.Point(32, 176);
            this.LabelNameError.Name = "LabelNameError";
            this.LabelNameError.Size = new System.Drawing.Size(35, 13);
            this.LabelNameError.TabIndex = 6;
            this.LabelNameError.Text = "label6";
            // 
            // LabelEmailError
            // 
            this.LabelEmailError.AutoSize = true;
            this.LabelEmailError.ForeColor = System.Drawing.Color.Red;
            this.LabelEmailError.Location = new System.Drawing.Point(32, 277);
            this.LabelEmailError.Name = "LabelEmailError";
            this.LabelEmailError.Size = new System.Drawing.Size(35, 13);
            this.LabelEmailError.TabIndex = 6;
            this.LabelEmailError.Text = "label6";
            this.LabelEmailError.Click += new System.EventHandler(this.LabelEmailError_Click);
            // 
            // LabelPasswordError
            // 
            this.LabelPasswordError.AutoSize = true;
            this.LabelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordError.Location = new System.Drawing.Point(32, 377);
            this.LabelPasswordError.Name = "LabelPasswordError";
            this.LabelPasswordError.Size = new System.Drawing.Size(35, 13);
            this.LabelPasswordError.TabIndex = 6;
            this.LabelPasswordError.Text = "label6";
            this.LabelPasswordError.Click += new System.EventHandler(this.LabelPasswordError_Click);
            // 
            // LabelConfirmPasswordError
            // 
            this.LabelConfirmPasswordError.AutoSize = true;
            this.LabelConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.LabelConfirmPasswordError.Location = new System.Drawing.Point(32, 478);
            this.LabelConfirmPasswordError.Name = "LabelConfirmPasswordError";
            this.LabelConfirmPasswordError.Size = new System.Drawing.Size(35, 13);
            this.LabelConfirmPasswordError.TabIndex = 6;
            this.LabelConfirmPasswordError.Text = "label6";
            // 
            // VisibilityToggler
            // 
            this.VisibilityToggler.BackColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.VisibilityToggler.Checked = true;
            this.VisibilityToggler.CheckedState.Image = global::FastFoodPOS.Properties.Resources.hide;
            this.VisibilityToggler.FillColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VisibilityToggler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.VisibilityToggler.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.VisibilityToggler.Image = global::FastFoodPOS.Properties.Resources.show;
            this.VisibilityToggler.Location = new System.Drawing.Point(380, 338);
            this.VisibilityToggler.Name = "VisibilityToggler";
            this.VisibilityToggler.PressedColor = System.Drawing.Color.Transparent;
            this.VisibilityToggler.PressedDepth = 0;
            this.VisibilityToggler.Size = new System.Drawing.Size(32, 36);
            this.VisibilityToggler.TabIndex = 7;
            this.VisibilityToggler.Click += new System.EventHandler(this.VisibilityToggler_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.Image = global::FastFoodPOS.Properties.Resources.hide;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.Image = global::FastFoodPOS.Properties.Resources.show;
            this.guna2Button1.Location = new System.Drawing.Point(380, 439);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.Size = new System.Drawing.Size(32, 36);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.VisibilityToggler);
            this.Controls.Add(this.LabelConfirmPasswordError);
            this.Controls.Add(this.LabelPasswordError);
            this.Controls.Add(this.LabelEmailError);
            this.Controls.Add(this.LabelNameError);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TextConfirmPassword);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistration";
            this.Size = new System.Drawing.Size(465, 599);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextPassword;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
        private System.Windows.Forms.Label LabelNameError;
        private System.Windows.Forms.Label LabelEmailError;
        private System.Windows.Forms.Label LabelPasswordError;
        private System.Windows.Forms.Label LabelConfirmPasswordError;
        private Guna.UI2.WinForms.Guna2Button VisibilityToggler;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
