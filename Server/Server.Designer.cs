using System;

namespace Server
{
    partial class Server
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
            this.rtbsv = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbsv
            // 
            this.rtbsv.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbsv.Location = new System.Drawing.Point(92, 102);
            this.rtbsv.Name = "rtbsv";
            this.rtbsv.Size = new System.Drawing.Size(499, 315);
            this.rtbsv.TabIndex = 6;
            this.rtbsv.Text = "";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(637, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 43);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Send";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtsend
            // 
            this.txtsend.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsend.Location = new System.Drawing.Point(92, 55);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(499, 22);
            this.txtsend.TabIndex = 4;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Gainsboro;
            this.check.Location = new System.Drawing.Point(618, 102);
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Size = new System.Drawing.Size(141, 314);
            this.check.TabIndex = 7;
            this.check.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.Location = new System.Drawing.Point(283, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "BamBoo Server";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = global::Server.Properties.Resources.sword;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.rtbsv);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtsend);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbsv;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.RichTextBox check;
        private System.Windows.Forms.TextBox textBox1;
    }
}

