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
        /// <param name="sender">Источник события</param>
        /// <param name="e">Параметры события</param>
        private void button_Click(object sender, EventArgs e)
        {
            // Приведение типа к кнопке
            Button button = (Button)sender;
            // преобразование строки в число
            int n = int.Parse(button.Text);
            // увеличение числа
            n = n + 1;
            // если число больше, чем 9
            if (n > 9)
            {
                n = 1; // вернёмся к единице
            }
            // преобразуем число обратно в строку
            button.Text = n.ToString();

            // Покрасить все кнопки в единый серый цвет
            foreach (Button b1 in Controls)
            {
                b1.BackColor = Color.Gray;
            }

            // Перебор всех кнопок
            foreach (Button b1 in Controls)
            {
                // Для каждой кнопки перебираем все остальные кнопки
                foreach (Button b2 in Controls)
                {
                    // Не надо проверять кнопку с ней же самой
                    if (b1 == b2) continue;

                    // Если текст на кнопках совпадает, перекрасим вторую кнопку
                    if (b1.Text == b2.Text)
                    {
                        b2.BackColor = Color.Coral;
                    }
                }
            }
        }
    }
}
