
namespace PasswordGenerationFormsClient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.vowelCountLabel = new System.Windows.Forms.Label();
            this.upperCountLabel = new System.Windows.Forms.Label();
            this.reverseLabel = new System.Windows.Forms.Label();
            this.vowelCtOutputLabel = new System.Windows.Forms.Label();
            this.upperCtOutputLabel = new System.Windows.Forms.Label();
            this.reverseOutputLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 20);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Enter String:";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vowelCountLabel
            // 
            this.vowelCountLabel.AutoSize = true;
            this.vowelCountLabel.Location = new System.Drawing.Point(12, 92);
            this.vowelCountLabel.Name = "vowelCountLabel";
            this.vowelCountLabel.Size = new System.Drawing.Size(70, 13);
            this.vowelCountLabel.TabIndex = 2;
            this.vowelCountLabel.Text = "Vowel Count:";
            this.vowelCountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // upperCountLabel
            // 
            this.upperCountLabel.AutoSize = true;
            this.upperCountLabel.Location = new System.Drawing.Point(13, 125);
            this.upperCountLabel.Name = "upperCountLabel";
            this.upperCountLabel.Size = new System.Drawing.Size(123, 13);
            this.upperCountLabel.TabIndex = 3;
            this.upperCountLabel.Text = "Uppercase Letter Count:";
            this.upperCountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // reverseLabel
            // 
            this.reverseLabel.AutoSize = true;
            this.reverseLabel.Location = new System.Drawing.Point(13, 159);
            this.reverseLabel.Name = "reverseLabel";
            this.reverseLabel.Size = new System.Drawing.Size(50, 13);
            this.reverseLabel.TabIndex = 4;
            this.reverseLabel.Text = "Reverse:";
            // 
            // vowelCtOutputLabel
            // 
            this.vowelCtOutputLabel.AutoSize = true;
            this.vowelCtOutputLabel.Location = new System.Drawing.Point(139, 92);
            this.vowelCtOutputLabel.Name = "vowelCtOutputLabel";
            this.vowelCtOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.vowelCtOutputLabel.TabIndex = 5;
            // 
            // upperCtOutputLabel
            // 
            this.upperCtOutputLabel.AutoSize = true;
            this.upperCtOutputLabel.Location = new System.Drawing.Point(139, 125);
            this.upperCtOutputLabel.Name = "upperCtOutputLabel";
            this.upperCtOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.upperCtOutputLabel.TabIndex = 6;
            // 
            // reverseOutputLabel
            // 
            this.reverseOutputLabel.AutoSize = true;
            this.reverseOutputLabel.Location = new System.Drawing.Point(139, 159);
            this.reverseOutputLabel.Name = "reverseOutputLabel";
            this.reverseOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.reverseOutputLabel.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(167, 36);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Run!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reverseOutputLabel);
            this.Controls.Add(this.upperCtOutputLabel);
            this.Controls.Add(this.vowelCtOutputLabel);
            this.Controls.Add(this.reverseLabel);
            this.Controls.Add(this.upperCountLabel);
            this.Controls.Add(this.vowelCountLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label vowelCountLabel;
        private System.Windows.Forms.Label upperCountLabel;
        private System.Windows.Forms.Label reverseLabel;
        private System.Windows.Forms.Label vowelCtOutputLabel;
        private System.Windows.Forms.Label upperCtOutputLabel;
        private System.Windows.Forms.Label reverseOutputLabel;
        private System.Windows.Forms.Button submitButton;
    }
}

