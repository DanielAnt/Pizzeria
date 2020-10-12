namespace Pizzeria
{
    partial class MainDishForm
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
            this.dish_price_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.decrease_button = new System.Windows.Forms.Button();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.increase_button = new System.Windows.Forms.Button();
            this.dish_label = new System.Windows.Forms.Label();
            this.salads_checkbox = new System.Windows.Forms.CheckBox();
            this.sauces_checkbox = new System.Windows.Forms.CheckBox();
            this.extras_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dish_price_label
            // 
            this.dish_price_label.AutoSize = true;
            this.dish_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dish_price_label.Location = new System.Drawing.Point(209, 189);
            this.dish_price_label.Name = "dish_price_label";
            this.dish_price_label.Size = new System.Drawing.Size(37, 25);
            this.dish_price_label.TabIndex = 21;
            this.dish_price_label.Text = "0zł";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.add_button.Location = new System.Drawing.Point(70, 233);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(204, 50);
            this.add_button.TabIndex = 20;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // decrease_button
            // 
            this.decrease_button.Location = new System.Drawing.Point(55, 194);
            this.decrease_button.Name = "decrease_button";
            this.decrease_button.Size = new System.Drawing.Size(20, 20);
            this.decrease_button.TabIndex = 19;
            this.decrease_button.Text = "-";
            this.decrease_button.UseVisualStyleBackColor = true;
            this.decrease_button.Click += new System.EventHandler(this.decrease_button_Click);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(81, 194);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(46, 20);
            this.quantity_textbox.TabIndex = 18;
            this.quantity_textbox.Text = "1";
            this.quantity_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity_textbox.TextChanged += new System.EventHandler(this.quantity_textbox_text_changed);
            this.quantity_textbox.Leave += new System.EventHandler(this.quantity_textbox_leave);
            // 
            // increase_button
            // 
            this.increase_button.Location = new System.Drawing.Point(133, 194);
            this.increase_button.Name = "increase_button";
            this.increase_button.Size = new System.Drawing.Size(20, 20);
            this.increase_button.TabIndex = 17;
            this.increase_button.Text = "+";
            this.increase_button.UseVisualStyleBackColor = true;
            this.increase_button.Click += new System.EventHandler(this.increase_button_Click);
            // 
            // dish_label
            // 
            this.dish_label.AutoSize = true;
            this.dish_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dish_label.Location = new System.Drawing.Point(10, 32);
            this.dish_label.MaximumSize = new System.Drawing.Size(300, 0);
            this.dish_label.Name = "dish_label";
            this.dish_label.Size = new System.Drawing.Size(100, 25);
            this.dish_label.TabIndex = 16;
            this.dish_label.Text = "dish_label";
            // 
            // salads_checkbox
            // 
            this.salads_checkbox.AutoSize = true;
            this.salads_checkbox.Location = new System.Drawing.Point(167, 146);
            this.salads_checkbox.Name = "salads_checkbox";
            this.salads_checkbox.Size = new System.Drawing.Size(117, 17);
            this.salads_checkbox.TabIndex = 15;
            this.salads_checkbox.Text = "bar sałatkowy - 5zł";
            this.salads_checkbox.UseVisualStyleBackColor = true;
            this.salads_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // sauces_checkbox
            // 
            this.sauces_checkbox.AutoSize = true;
            this.sauces_checkbox.Location = new System.Drawing.Point(25, 146);
            this.sauces_checkbox.Name = "sauces_checkbox";
            this.sauces_checkbox.Size = new System.Drawing.Size(116, 17);
            this.sauces_checkbox.TabIndex = 14;
            this.sauces_checkbox.Text = "zestaw sosów - 6zł";
            this.sauces_checkbox.UseVisualStyleBackColor = true;
            this.sauces_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // extras_label
            // 
            this.extras_label.AutoSize = true;
            this.extras_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.extras_label.Location = new System.Drawing.Point(11, 105);
            this.extras_label.Name = "extras_label";
            this.extras_label.Size = new System.Drawing.Size(64, 20);
            this.extras_label.TabIndex = 12;
            this.extras_label.Text = "Dodatki";
            // 
            // MainDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.dish_price_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.decrease_button);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.increase_button);
            this.Controls.Add(this.dish_label);
            this.Controls.Add(this.salads_checkbox);
            this.Controls.Add(this.sauces_checkbox);
            this.Controls.Add(this.extras_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainDishForm";
            this.Text = "MainDishForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dish_price_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button decrease_button;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Button increase_button;
        private System.Windows.Forms.Label dish_label;
        private System.Windows.Forms.CheckBox salads_checkbox;
        private System.Windows.Forms.CheckBox sauces_checkbox;
        private System.Windows.Forms.Label extras_label;
    }
}