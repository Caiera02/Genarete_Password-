namespace Gerador_de_Senha
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
            lblSenhaGerada = new Label();
            txtPwd = new TextBox();
            btnGenerate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSenhaGerada
            // 
            lblSenhaGerada.AutoSize = true;
            lblSenhaGerada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenhaGerada.Location = new Point(68, 50);
            lblSenhaGerada.MinimumSize = new Size(100, 0);
            lblSenhaGerada.Name = "lblSenhaGerada";
            lblSenhaGerada.Size = new Size(241, 21);
            lblSenhaGerada.TabIndex = 0;
            lblSenhaGerada.Text = "Type it how much number desery";
            lblSenhaGerada.Click += label1_Click;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = SystemColors.ScrollBar;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.ForeColor = SystemColors.ControlText;
            txtPwd.Location = new Point(82, 89);
            txtPwd.MaximumSize = new Size(200, 250);
            txtPwd.MinimumSize = new Size(50, 25);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(200, 25);
            txtPwd.TabIndex = 1;
            txtPwd.TextChanged += textBox1_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(144, 236);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 179);
            label1.MaximumSize = new Size(3500, 20);
            label1.MinimumSize = new Size(100, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = ".....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(364, 271);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(txtPwd);
            Controls.Add(lblSenhaGerada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenhaGerada;
        private TextBox txtPwd;
        private Button btnGenerate;
        private Label label1;
    }
}