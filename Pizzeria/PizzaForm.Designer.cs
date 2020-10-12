namespace Pizzeria
{
    partial class PizzaForm
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
        /// 

             

        private void InitializeComponent()
        {
            this.cheese_checkbox = new System.Windows.Forms.CheckBox();
            this.toppings_label = new System.Windows.Forms.Label();
            this.salami_checkbox = new System.Windows.Forms.CheckBox();
            this.ham_checkbox = new System.Windows.Forms.CheckBox();
            this.mushrooms_checkbox = new System.Windows.Forms.CheckBox();
            this.pizza_label = new System.Windows.Forms.Label();
            this.increase_button = new System.Windows.Forms.Button();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.decrease_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.pizza_price_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cheese_checkbox
            // 
            this.cheese_checkbox.AutoSize = true;
            this.cheese_checkbox.Location = new System.Drawing.Point(18, 120);
            this.cheese_checkbox.Name = "cheese_checkbox";
            this.cheese_checkbox.Size = new System.Drawing.Size(40, 17);
            this.cheese_checkbox.TabIndex = 0;
            this.cheese_checkbox.Text = "ser";
            this.cheese_checkbox.UseVisualStyleBackColor = true;
            this.cheese_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // toppings_label
            // 
            this.toppings_label.AutoSize = true;
            this.toppings_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.toppings_label.Location = new System.Drawing.Point(12, 73);
            this.toppings_label.Name = "toppings_label";
            this.toppings_label.Size = new System.Drawing.Size(133, 26);
            this.toppings_label.TabIndex = 1;
            this.toppings_label.Text = "Dodatki - 2zł";
            // 
            // salami_checkbox
            // 
            this.salami_checkbox.AutoSize = true;
            this.salami_checkbox.Location = new System.Drawing.Point(18, 158);
            this.salami_checkbox.Name = "salami_checkbox";
            this.salami_checkbox.Size = new System.Drawing.Size(55, 17);
            this.salami_checkbox.TabIndex = 2;
            this.salami_checkbox.Text = "salami";
            this.salami_checkbox.UseVisualStyleBackColor = true;
            this.salami_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // ham_checkbox
            // 
            this.ham_checkbox.AutoSize = true;
            this.ham_checkbox.Location = new System.Drawing.Point(144, 120);
            this.ham_checkbox.Name = "ham_checkbox";
            this.ham_checkbox.Size = new System.Drawing.Size(59, 17);
            this.ham_checkbox.TabIndex = 3;
            this.ham_checkbox.Text = "szynka";
            this.ham_checkbox.UseVisualStyleBackColor = true;
            this.ham_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // mushrooms_checkbox
            // 
            this.mushrooms_checkbox.AutoSize = true;
            this.mushrooms_checkbox.Location = new System.Drawing.Point(144, 158);
            this.mushrooms_checkbox.Name = "mushrooms_checkbox";
            this.mushrooms_checkbox.Size = new System.Drawing.Size(68, 17);
            this.mushrooms_checkbox.TabIndex = 4;
            this.mushrooms_checkbox.Text = "pieczarki";
            this.mushrooms_checkbox.UseVisualStyleBackColor = true;
            this.mushrooms_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // pizza_label
            // 
            this.pizza_label.AutoSize = true;
            this.pizza_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.pizza_label.Location = new System.Drawing.Point(12, 20);
            this.pizza_label.Name = "pizza_label";
            this.pizza_label.Size = new System.Drawing.Size(159, 32);
            this.pizza_label.TabIndex = 5;
            this.pizza_label.Text = "pizza_label";
            // 
            // increase_button
            // 
            this.increase_button.Location = new System.Drawing.Point(96, 210);
            this.increase_button.Name = "increase_button";
            this.increase_button.Size = new System.Drawing.Size(20, 20);
            this.increase_button.TabIndex = 6;
            this.increase_button.Text = "+";
            this.increase_button.UseVisualStyleBackColor = true;
            this.increase_button.Click += new System.EventHandler(this.increase_button_Click);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(44, 210);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(46, 20);
            this.quantity_textbox.TabIndex = 7;
            this.quantity_textbox.Text = "1";
            this.quantity_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity_textbox.TextChanged += new System.EventHandler(this.quantity_textbox_text_changed);
            this.quantity_textbox.Leave += new System.EventHandler(this.quantity_textbox_leave);
            // 
            // decrease_button
            // 
            this.decrease_button.Location = new System.Drawing.Point(18, 210);
            this.decrease_button.Name = "decrease_button";
            this.decrease_button.Size = new System.Drawing.Size(20, 20);
            this.decrease_button.TabIndex = 8;
            this.decrease_button.Text = "-";
            this.decrease_button.UseVisualStyleBackColor = true;
            this.decrease_button.Click += new System.EventHandler(this.decrease_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.add_button.Location = new System.Drawing.Point(46, 248);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(166, 49);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pizza_price_label
            // 
            this.pizza_price_label.AutoSize = true;
            this.pizza_price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pizza_price_label.Location = new System.Drawing.Point(167, 204);
            this.pizza_price_label.Name = "pizza_price_label";
            this.pizza_price_label.Size = new System.Drawing.Size(37, 25);
            this.pizza_price_label.TabIndex = 10;
            this.pizza_price_label.Text = "0zł";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 313);
            this.Controls.Add(this.pizza_price_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.decrease_button);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.increase_button);
            this.Controls.Add(this.pizza_label);
            this.Controls.Add(this.mushrooms_checkbox);
            this.Controls.Add(this.ham_checkbox);
            this.Controls.Add(this.salami_checkbox);
            this.Controls.Add(this.toppings_label);
            this.Controls.Add(this.cheese_checkbox);
            this.Name = "PizzaForm";
            this.Text = "PizzaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cheese_checkbox;
        private System.Windows.Forms.Label toppings_label;
        private System.Windows.Forms.CheckBox salami_checkbox;
        private System.Windows.Forms.CheckBox ham_checkbox;
        private System.Windows.Forms.CheckBox mushrooms_checkbox;
        private System.Windows.Forms.Label pizza_label;
        private System.Windows.Forms.Button increase_button;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Button decrease_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label pizza_price_label;
    }
}