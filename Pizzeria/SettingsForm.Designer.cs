namespace Pizzeria
{
    partial class SettingsForm
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
            this.save_button = new System.Windows.Forms.Button();
            this.host_textbox = new System.Windows.Forms.TextBox();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.email_from_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_to_textbox = new System.Windows.Forms.TextBox();
            this.host_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.email_from_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_to_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.save_button.Location = new System.Drawing.Point(33, 279);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(269, 45);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // host_textbox
            // 
            this.host_textbox.Location = new System.Drawing.Point(138, 37);
            this.host_textbox.Name = "host_textbox";
            this.host_textbox.Size = new System.Drawing.Size(164, 20);
            this.host_textbox.TabIndex = 1;
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(138, 83);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(164, 20);
            this.port_textbox.TabIndex = 2;
            // 
            // email_from_textbox
            // 
            this.email_from_textbox.Location = new System.Drawing.Point(138, 128);
            this.email_from_textbox.Name = "email_from_textbox";
            this.email_from_textbox.Size = new System.Drawing.Size(164, 20);
            this.email_from_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(138, 169);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(164, 20);
            this.password_textbox.TabIndex = 4;
            // 
            // email_to_textbox
            // 
            this.email_to_textbox.Location = new System.Drawing.Point(138, 211);
            this.email_to_textbox.Name = "email_to_textbox";
            this.email_to_textbox.Size = new System.Drawing.Size(164, 20);
            this.email_to_textbox.TabIndex = 5;
            // 
            // host_label
            // 
            this.host_label.AutoSize = true;
            this.host_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.host_label.Location = new System.Drawing.Point(29, 35);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(47, 20);
            this.host_label.TabIndex = 6;
            this.host_label.Text = "Host:";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port_label.Location = new System.Drawing.Point(29, 83);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(42, 20);
            this.port_label.TabIndex = 7;
            this.port_label.Text = "Port:";
            // 
            // email_from_label
            // 
            this.email_from_label.AutoSize = true;
            this.email_from_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_from_label.Location = new System.Drawing.Point(29, 128);
            this.email_from_label.Name = "email_from_label";
            this.email_from_label.Size = new System.Drawing.Size(89, 20);
            this.email_from_label.TabIndex = 8;
            this.email_from_label.Text = "EmailFrom:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_label.Location = new System.Drawing.Point(29, 169);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(82, 20);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password:";
            // 
            // email_to_label
            // 
            this.email_to_label.AutoSize = true;
            this.email_to_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_to_label.Location = new System.Drawing.Point(29, 211);
            this.email_to_label.Name = "email_to_label";
            this.email_to_label.Size = new System.Drawing.Size(70, 20);
            this.email_to_label.TabIndex = 10;
            this.email_to_label.Text = "EmailTo:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 347);
            this.Controls.Add(this.email_to_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_from_label);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.host_label);
            this.Controls.Add(this.email_to_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_from_textbox);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.host_textbox);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox host_textbox;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox email_from_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox email_to_textbox;
        private System.Windows.Forms.Label host_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label email_from_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_to_label;
    }
}