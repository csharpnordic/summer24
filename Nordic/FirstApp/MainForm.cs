namespace FirstApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            // преобразование строки в число
            int n = int.Parse(button2.Text);
            // увеличение числа
            n = n + 1;
            // если число больше, чем 9
            if (n > 9)
            {
                n = 1; // вернёмся к единице
            }
            // преобразуем число обратно в строку
            button2.Text = n.ToString();
        }       
    }
}
