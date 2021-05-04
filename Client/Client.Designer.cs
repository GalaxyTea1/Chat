namespace Client
{
    partial class Client
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.LightCyan;
            this.txt1.Location = new System.Drawing.Point(12, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(499, 22);
            this.txt1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(557, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 43);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Send";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.Color.LightCyan;
            this.rtb1.Location = new System.Drawing.Point(12, 108);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(499, 315);
            this.rtb1.TabIndex = 3;
            this.rtb1.Text = "";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(557, 108);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 44);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Disconect";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(557, 182);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 36);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox1.Location = new System.Drawing.Point(27, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Client";
            // 
            // Client
            // 
            this.AcceptButton = this.btn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Client.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
    }
}

