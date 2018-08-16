namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CBstart = new System.Windows.Forms.CheckBox();
            this.CBSürekli = new System.Windows.Forms.CheckBox();
            this.CBpolarite = new System.Windows.Forms.CheckBox();
            this.CBexternal = new System.Windows.Forms.CheckBox();
            this.txtDSayısı = new System.Windows.Forms.TextBox();
            this.txtPRF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.btnBaglantı = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxFrekans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBstart
            // 
            this.CBstart.AutoSize = true;
            this.CBstart.Checked = true;
            this.CBstart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBstart.Location = new System.Drawing.Point(621, 45);
            this.CBstart.Name = "CBstart";
            this.CBstart.Size = new System.Drawing.Size(60, 21);
            this.CBstart.TabIndex = 0;
            this.CBstart.Text = "Start";
            this.CBstart.UseVisualStyleBackColor = true;
            // 
            // CBSürekli
            // 
            this.CBSürekli.AutoSize = true;
            this.CBSürekli.Location = new System.Drawing.Point(621, 171);
            this.CBSürekli.Name = "CBSürekli";
            this.CBSürekli.Size = new System.Drawing.Size(73, 21);
            this.CBSürekli.TabIndex = 1;
            this.CBSürekli.Text = "Sürekli";
            this.CBSürekli.UseVisualStyleBackColor = true;
            // 
            // CBpolarite
            // 
            this.CBpolarite.AutoSize = true;
            this.CBpolarite.Checked = true;
            this.CBpolarite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBpolarite.Location = new System.Drawing.Point(621, 124);
            this.CBpolarite.Name = "CBpolarite";
            this.CBpolarite.Size = new System.Drawing.Size(78, 21);
            this.CBpolarite.TabIndex = 2;
            this.CBpolarite.Text = "Polarite";
            this.CBpolarite.UseVisualStyleBackColor = true;
            // 
            // CBexternal
            // 
            this.CBexternal.AutoSize = true;
            this.CBexternal.Location = new System.Drawing.Point(621, 90);
            this.CBexternal.Name = "CBexternal";
            this.CBexternal.Size = new System.Drawing.Size(81, 21);
            this.CBexternal.TabIndex = 3;
            this.CBexternal.Text = "External";
            this.CBexternal.UseVisualStyleBackColor = true;
            // 
            // txtDSayısı
            // 
            this.txtDSayısı.Location = new System.Drawing.Point(443, 86);
            this.txtDSayısı.Name = "txtDSayısı";
            this.txtDSayısı.Size = new System.Drawing.Size(124, 22);
            this.txtDSayısı.TabIndex = 4;
            this.txtDSayısı.Text = "10";
            // 
            // txtPRF
            // 
            this.txtPRF.Location = new System.Drawing.Point(264, 87);
            this.txtPRF.Name = "txtPRF";
            this.txtPRF.Size = new System.Drawing.Size(132, 22);
            this.txtPRF.TabIndex = 5;
            this.txtPRF.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frekans:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Darbe Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seçenekler:";
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.Location = new System.Drawing.Point(56, 157);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(108, 45);
            this.btnBaşlat.TabIndex = 11;
            this.btnBaşlat.Text = "Başlat";
            this.btnBaşlat.UseVisualStyleBackColor = true;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // btnBaglantı
            // 
            this.btnBaglantı.Location = new System.Drawing.Point(276, 17);
            this.btnBaglantı.Name = "btnBaglantı";
            this.btnBaglantı.Size = new System.Drawing.Size(108, 35);
            this.btnBaglantı.TabIndex = 13;
            this.btnBaglantı.Text = "Bağlan";
            this.btnBaglantı.UseVisualStyleBackColor = true;
            this.btnBaglantı.Click += new System.EventHandler(this.btnBaglantı_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = " Port:";
            // 
            // ComboBoxFrekans
            // 
            this.ComboBoxFrekans.FormattingEnabled = true;
            this.ComboBoxFrekans.ItemHeight = 16;
            this.ComboBoxFrekans.Location = new System.Drawing.Point(56, 90);
            this.ComboBoxFrekans.MaxDropDownItems = 100;
            this.ComboBoxFrekans.Name = "ComboBoxFrekans";
            this.ComboBoxFrekans.Size = new System.Drawing.Size(154, 24);
            this.ComboBoxFrekans.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 16;
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(118, 23);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxPort.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.ComboBoxPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxFrekans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBaglantı);
            this.Controls.Add(this.btnBaşlat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPRF);
            this.Controls.Add(this.txtDSayısı);
            this.Controls.Add(this.CBexternal);
            this.Controls.Add(this.CBpolarite);
            this.Controls.Add(this.CBSürekli);
            this.Controls.Add(this.CBstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBstart;
        private System.Windows.Forms.CheckBox CBSürekli;
        private System.Windows.Forms.CheckBox CBpolarite;
        private System.Windows.Forms.CheckBox CBexternal;
        private System.Windows.Forms.TextBox txtDSayısı;
        private System.Windows.Forms.TextBox txtPRF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.Button btnBaglantı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxFrekans;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Timer timer1;
    }
}

