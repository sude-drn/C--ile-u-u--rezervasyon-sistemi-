namespace uçuş_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " +comboBox1.Text+"-" +comboBox2.Text+ " Tarih: "+dateTimePicker1.Text+" saat:"+maskedTextBox3.Text + " yolcu bilgiler: ~ Ad:" + textBox1.Text + " TC: " +maskedTextBox4.Text+ " Telefon: " +maskedTextBox5.Text );
            MessageBox.Show("Yolcu kaydı yapıldı.");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}