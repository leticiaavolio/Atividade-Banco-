﻿namespace PrjAtivida_Banco.forms
{
    partial class FrmCriarConta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Criar Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 154);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 204);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Número da Conta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 256);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo de Conta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 100);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Saldo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 154);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Limite:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 204);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 7;
            label8.Text = "Senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(348, 256);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 8;
            label9.Text = "Confirmação de Senha:";
            // 
            // button1
            // 
            button1.Location = new Point(258, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCriarConta";
            Text = "FrmCriarConta";
            Load += FrmCriarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}