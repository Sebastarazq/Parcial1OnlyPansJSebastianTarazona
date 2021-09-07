
using System;

namespace AplicacionOnlyPans
{
    partial class Form3
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
        private void InitializeComponent()
        {
            this.lblType = new System.Windows.Forms.Label();
            this.cboxAliñado = new System.Windows.Forms.CheckBox();
            this.cboxNoaliñado = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.txtNam1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(67, 36);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(106, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Escoja el tipo de pan";
            // 
            // cboxAliñado
            // 
            this.cboxAliñado.AutoSize = true;
            this.cboxAliñado.Location = new System.Drawing.Point(75, 91);
            this.cboxAliñado.Name = "cboxAliñado";
            this.cboxAliñado.Size = new System.Drawing.Size(83, 17);
            this.cboxAliñado.TabIndex = 1;
            this.cboxAliñado.Text = "Pan Aliñado";
            this.cboxAliñado.UseVisualStyleBackColor = true;
            this.cboxAliñado.CheckedChanged += new System.EventHandler(this.cboxAliñado_CheckedChanged);
            this.cboxAliñado.CheckStateChanged += new System.EventHandler(this.cboxAliñado_CheckStateChanged);
            this.cboxAliñado.Click += new System.EventHandler(this.cboxAliñado_CheckedChanged);
            // 
            // cboxNoaliñado
            // 
            this.cboxNoaliñado.AutoSize = true;
            this.cboxNoaliñado.Location = new System.Drawing.Point(75, 141);
            this.cboxNoaliñado.Name = "cboxNoaliñado";
            this.cboxNoaliñado.Size = new System.Drawing.Size(98, 17);
            this.cboxNoaliñado.TabIndex = 2;
            this.cboxNoaliñado.Text = "Pan no Aliñado";
            this.cboxNoaliñado.UseVisualStyleBackColor = true;
            this.cboxNoaliñado.CheckedChanged += new System.EventHandler(this.cboxNoaliñado_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(75, 190);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Pan especial";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // txtNam1
            // 
            this.txtNam1.Location = new System.Drawing.Point(297, 88);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(207, 20);
            this.txtNam1.TabIndex = 4;
            this.txtNam1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(297, 141);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(297, 190);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del comprador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de panes";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(297, 225);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(138, 23);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Registrar compra";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(556, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 211);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(297, 269);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(138, 23);
            this.btnPass.TabIndex = 12;
            this.btnPass.Text = "Pasar compra";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNam1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cboxNoaliñado);
            this.Controls.Add(this.cboxAliñado);
            this.Controls.Add(this.lblType);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboxAliñado_CheckStateChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cboxAliñado_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox cboxAliñado;
        private System.Windows.Forms.CheckBox cboxNoaliñado;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox txtNam1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPass;
    }
}