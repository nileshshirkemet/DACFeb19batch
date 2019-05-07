namespace SimpleUIApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.greetButton = new System.Windows.Forms.Button();
            this.simpleGreeter = new SimpleUIApp.Greeter(this.components);
            this.greeterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.greeterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(13, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(113, 20);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Welcome User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person:";
            // 
            // personTextBox
            // 
            this.personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greeterBindingSource, "Person", true));
            this.personTextBox.Location = new System.Drawing.Point(110, 55);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(100, 20);
            this.personTextBox.TabIndex = 2;
            this.personTextBox.TextChanged += new System.EventHandler(this.personTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Period:";
            // 
            // periodComboBox
            // 
            this.periodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greeterBindingSource, "Period", true));
            this.periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "Night",
            "Morning",
            "Afternoon",
            "Evening"});
            this.periodComboBox.Location = new System.Drawing.Point(110, 81);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(100, 21);
            this.periodComboBox.TabIndex = 4;
            // 
            // greetButton
            // 
            this.greetButton.Enabled = false;
            this.greetButton.Location = new System.Drawing.Point(82, 133);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(75, 23);
            this.greetButton.TabIndex = 5;
            this.greetButton.Text = "Greet";
            this.greetButton.UseVisualStyleBackColor = true;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // simpleGreeter
            // 
            this.simpleGreeter.Greetings = 0;
            this.simpleGreeter.Period = "Morning";
            this.simpleGreeter.Person = "Master";
            // 
            // greeterBindingSource
            // 
            this.greeterBindingSource.DataSource = typeof(SimpleUIApp.Greeter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 178);
            this.Controls.Add(this.greetButton);
            this.Controls.Add(this.periodComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputLabel);
            this.Name = "MainForm";
            this.Text = "SimpleUIApp";
            ((System.ComponentModel.ISupportInitialize)(this.greeterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.Button greetButton;
        private Greeter simpleGreeter;
        private System.Windows.Forms.BindingSource greeterBindingSource;
    }
}

