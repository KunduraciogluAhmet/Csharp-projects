namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int dice1, dice2;
        string diceFolderPath;

        public Form1()
        {
            InitializeComponent();
            diceFolderPath = Path.Combine(Application.StartupPath, "dices");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);

            LoadDiceImage(dice1, pictureBox1);
            LoadDiceImage(dice2, pictureBox2);
        }
        /*
            switch(dice1)
            {
                case 1:
                    pictureBox1.ImageLocation= "\\dices\\1.png";
                    break;

                case 2:
                    pictureBox1.ImageLocation = "\\dices\\2.png";
                    break;

                case 3:
                    pictureBox1.ImageLocation = "\\dices\\3.png";
                    break;

                case 4:
                    pictureBox1.ImageLocation = "\\dices\\4.png";
                    break;

                case 5:
                    pictureBox1.ImageLocation = "\\dices\\5.png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "\\dices\\6.png";
                    break;

            }
            switch (dice2)
            {
                case 1:
                    pictureBox2.ImageLocation = "\\dices\\1.png";
                    break;

                case 2:
                    pictureBox2.ImageLocation = "\\dices\\2.png";
                    break;

                case 3:
                    pictureBox2.ImageLocation = "\\dices\\3.png";
                    break;

                case 4:
                    pictureBox2.ImageLocation = "\dices\4.png";
                    break;

                case 5:
                    pictureBox2.ImageLocation = "\\dices\\5.png";
                    break;
                case 6:
                    pictureBox2.ImageLocation = "\\dices\\6.png";
                    break;

            }
        */
        private void LoadDiceImage(int diceValue, PictureBox pictureBox)
        {
            // Resmin dosya yolu oluþturuluyor
            string imagePath = Path.Combine(diceFolderPath, $"{diceValue}.png");

            // Dosya yolunda bulunan resim yükleniyor
            if (File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
            }
            else
            {
                MessageBox.Show($"Resim bulunamadý: {imagePath}");
            }
        }
    }
}
