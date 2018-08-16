using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[] frekans = new int[] { 10000, 20000, 30000, 40000, 50000, 100000, 200000, 300000, 400000, 500000, 600000, 700000, 800000, 900000, 1000000, 2000000, 2500000, 5000000, 10000000 };
        public Form1()
        {
            InitializeComponent();
            COMPortlariListele();

            for (int i = 0; i < frekans.Length; i++)
            {
                ComboBoxFrekans.Items.Add(frekanstostring(frekans[i]));
            }
            ComboBoxFrekans.SelectedIndex = 0;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string frekanstostring(double frekans)
        {
            string[] fkm_ = { "Hz", "KHz", "MHz", "GHz" };
            int i = 0;
            for (; i < fkm_.Length; i++)
            {
                if (frekans > 999) frekans /= 1000;
                else break;
            }
            return Convert.ToString(frekans) + " " + fkm_[i];
        }


        private void COMPortlariListele()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComboBoxPort.Items.Add(ports);
            }
            if (ports.Length == 0)
            {
                label6.Text = "COM port bulunamadi";
                label6.ForeColor = Color.Red;
                btnBaşlat.Enabled = false;
            }
            else ComboBoxPort.SelectedIndex = 0;



        }   

        private void Ayarlarigonder()
        {
            string ayar = "";
            int frekanss = frekans[ComboBoxFrekans.SelectedIndex];
            int PRF = Convert.ToInt16(txtPRF.Text);
            int darbesayisi = Convert.ToInt16(txtDSayısı.Text);
            double bekleme = 1/((double) (PRF)) - 1/ ((double)(frekanss));
            if (2*PRF/frekanss*darbesayisi >= 1)
            {
                int tmp = frekanss/PRF/2;
                MessageBox.Show("Darbe sayısı " + tmp + " değerinden büyük olamaz!");
                return;
            }
            if (CBstart.Checked && CBexternal.Checked)
            {
                MessageBox.Show("Dahili ve harici sinyal aynı anda çalışamaz!");
                return;
            }
            bool ms = false;
            if (bekleme > 1000)
            {
                bekleme = (int)(bekleme / 1000);
                ms = true;
            }
            else bekleme = (int)(bekleme);
            ayar += (Convert.ToChar(0)).ToString();
            ayar += (Convert.ToChar((CBstart.Checked?1:0) + (CBexternal.Checked?2:0) + (CBpolarite.Checked?4:0))).ToString();
            ayar += (Convert.ToChar((int)(bekleme % 256))).ToString();
            ayar += (Convert.ToChar(((int)(bekleme / 256)) | (ms?128:0))).ToString();
            ayar += (Convert.ToChar(darbesayisi)).ToString();
            ayar += (Convert.ToChar(ComboBoxFrekans.SelectedIndex)).ToString();
            serialPort1.Write(ayar);
        }

        private void btnBaglantı_Click(object sender, EventArgs e)
        {
            if (ComboBoxPort.SelectedIndex < 0)
            {
                label6.Text = "COM port bulunamadi";
                label6.ForeColor = Color.Red;
                return;
            }

            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = ComboBoxPort.SelectedItem.ToString();
                    serialPort1.Open();
                    label6.Text = "Bağlantı Açıldı";
                    label6.ForeColor = Color.Green;

                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Enabled = false;
                    serialPort1.Close();
                    label6.Text = "Bağlantı kesildi";
                    label6.ForeColor = Color.Red;


                }
            }
            catch
            {
                MessageBox.Show("Bağlantı açılamadı!");
                //}
            }


        }

        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            Ayarlarigonder();
        }
    }
}
    

