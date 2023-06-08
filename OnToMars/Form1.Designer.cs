namespace OnToMars
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
            this.components = new System.ComponentModel.Container();
            this.pbRaketa = new System.Windows.Forms.PictureBox();
            this.pbMeteor = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbPoeni = new System.Windows.Forms.Label();
            this.pbMeteor2 = new System.Windows.Forms.PictureBox();
            this.pbMeteor3 = new System.Windows.Forms.PictureBox();
            this.pbMars = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMars)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRaketa
            // 
            this.pbRaketa.BackColor = System.Drawing.Color.Transparent;
            this.pbRaketa.Image = global::OnToMars.Properties.Resources.RaketaX;
            this.pbRaketa.Location = new System.Drawing.Point(440, 630);
            this.pbRaketa.Name = "pbRaketa";
            this.pbRaketa.Size = new System.Drawing.Size(45, 100);
            this.pbRaketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaketa.TabIndex = 2;
            this.pbRaketa.TabStop = false;
            // 
            // pbMeteor
            // 
            this.pbMeteor.BackColor = System.Drawing.Color.Transparent;
            this.pbMeteor.Image = global::OnToMars.Properties.Resources.Meteor;
            this.pbMeteor.Location = new System.Drawing.Point(124, 28);
            this.pbMeteor.Name = "pbMeteor";
            this.pbMeteor.Size = new System.Drawing.Size(60, 120);
            this.pbMeteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMeteor.TabIndex = 4;
            this.pbMeteor.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(900, 720);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 730);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Poeni:";
            this.label1.UseMnemonic = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 75;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbPoeni
            // 
            this.lbPoeni.AutoSize = true;
            this.lbPoeni.BackColor = System.Drawing.Color.Transparent;
            this.lbPoeni.ForeColor = System.Drawing.Color.White;
            this.lbPoeni.Location = new System.Drawing.Point(64, 731);
            this.lbPoeni.Name = "lbPoeni";
            this.lbPoeni.Size = new System.Drawing.Size(0, 13);
            this.lbPoeni.TabIndex = 7;
            // 
            // pbMeteor2
            // 
            this.pbMeteor2.Image = global::OnToMars.Properties.Resources.Meteor;
            this.pbMeteor2.Location = new System.Drawing.Point(462, 82);
            this.pbMeteor2.Name = "pbMeteor2";
            this.pbMeteor2.Size = new System.Drawing.Size(60, 120);
            this.pbMeteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMeteor2.TabIndex = 8;
            this.pbMeteor2.TabStop = false;
            // 
            // pbMeteor3
            // 
            this.pbMeteor3.Image = global::OnToMars.Properties.Resources.Meteor;
            this.pbMeteor3.Location = new System.Drawing.Point(736, 321);
            this.pbMeteor3.Name = "pbMeteor3";
            this.pbMeteor3.Size = new System.Drawing.Size(60, 120);
            this.pbMeteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMeteor3.TabIndex = 9;
            this.pbMeteor3.TabStop = false;
            // 
            // pbMars
            // 
            this.pbMars.Image = global::OnToMars.Properties.Resources.Mars;
            this.pbMars.Location = new System.Drawing.Point(683, -3);
            this.pbMars.Name = "pbMars";
            this.pbMars.Size = new System.Drawing.Size(250, 250);
            this.pbMars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMars.TabIndex = 10;
            this.pbMars.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Strelica levo - levo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strelica desno - desno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Strelica gore - ubrzanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Strelica dole - usporavanje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMars);
            this.Controls.Add(this.pbMeteor3);
            this.Controls.Add(this.pbMeteor2);
            this.Controls.Add(this.lbPoeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbMeteor);
            this.Controls.Add(this.pbRaketa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnToMars";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbRaketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbRaketa;
        private System.Windows.Forms.PictureBox pbMeteor;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPoeni;
        private System.Windows.Forms.PictureBox pbMeteor2;
        private System.Windows.Forms.PictureBox pbMeteor3;
        private System.Windows.Forms.PictureBox pbMars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

