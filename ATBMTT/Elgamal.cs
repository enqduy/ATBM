
using MathNet.Numerics.Distributions;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Crypto.Macs;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace ATBMTT
{
    public partial class Elgamal : Form
    {
        static BigInteger p, alpha, beta, a, k, r;
        static List<BigInteger> key = new List<BigInteger>();
        public Elgamal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string stringKiemTra = richTextBox3.Text;
            String sign = richTextBox2.Text;
            try
            {
                if (ElgamalProcess.VerifySign(stringKiemTra, sign, beta, r, alpha, p))
                {
                    MessageBox.Show("Chữ ký hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chữ ký đã bị đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            key = ElgamalProcess.CreKey();
            p = key[0];
            alpha = key[1];
            beta = key[2];
            a = key[3];
            k = key[4];
            r = key[5];
            textBox1.Text = p.ToString();
            textBox2.Text = alpha.ToString();
            textBox3.Text = beta.ToString();
            textBox4.Text = a.ToString();
            textBox5.Text = k.ToString();
            textBox6.Text = r.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Mo hop chon file
            DialogResult result = openFileDialog.ShowDialog();

            // Kiem tra viec chon file
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Hien thi duong dan file
                textBox8.Text = filePath;

                // doc noi dung file da chon
                try
                {
                    string content = File.ReadAllText(filePath);
                    richTextBox3.Text = content;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Mo hop thoai chon file
            DialogResult result = openFileDialog.ShowDialog();

            // Kiem tra nguoi dung chon file hay khong
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Hien thi duong dan
                textBox7.Text = filePath;

                // Doc noi dung file
                try
                {
                    string content = File.ReadAllText(filePath);
                    richTextBox1.Text = content;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sign = ElgamalProcess.CreateSign(richTextBox1.Text, key[5], key[3], key[4], key[0]);
            richTextBox2.Text = sign;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            richTextBox2.Text = " ";
            richTextBox3.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            
        }
    }
}
