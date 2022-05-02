using System.Media;
namespace TalhaAslan_SalıLb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 atla = new Form2();
            atla.Show();
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Talha\Desktop\unlu-futbolcu-hakan-unal-jet-sosyete-ajda-hanim-is-insani-ali-bey-hepsi-burada.wav");
            soundPlayer.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 atla = new Form2();
            atla.Show();
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Talha\Desktop\muzik.wav");
            soundPlayer.Play();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            
        }
    }
}