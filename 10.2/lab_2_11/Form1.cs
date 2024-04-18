using System; // Импорт пространства имен System, содержащего основные типы.
using System.Windows.Forms; // Импорт пространства имен для работы с формами Windows.

namespace lab_2_11 // Определение пространства имен для вашего проекта.
{
    public partial class Form1 : Form // Объявление класса Form1, который наследуется от класса Form.
    {
        public Form1() // Конструктор класса Form1.
        {
            InitializeComponent(); // Автоматически сгенерированный метод для инициализации компонентов формы.
            euroRadioButton.Checked = true; // Установка радиокнопки для евро в выбранное состояние по умолчанию.
        }

        private void euroRadioButton_CheckedChanged(object sender, EventArgs e) // Обработчик события изменения состояния радиокнопки евро.
        {
            ConvertCurrency(); // Вызов метода для конвертации валюты.
            resultLabel.Text = "Евро"; // Установка текста метки результатов на "Евро".
        }

        private void dollarRadioButton_CheckedChanged(object sender, EventArgs e) // Обработчик события изменения состояния радиокнопки доллара.
        {
            ConvertCurrency(); // Вызов метода для конвертации валюты.
            resultLabel.Text = "Доллар"; // Установка текста метки результатов на "Доллар".
        }

        private void rubleTextBox_TextChanged(object sender, EventArgs e) // Обработчик события изменения текста в поле ввода рублей.
        {
            ConvertCurrency(); // Вызов метода для конвертации валюты.
        }

        private void ConvertCurrency() // Метод для конвертации валюты.
        {
            if (double.TryParse(rubleTextBox.Text, out double rubles)) // Попытка преобразования текста из поля ввода в число.
            {
                if (euroRadioButton.Checked) // Проверка, выбрана ли радиокнопка евро.
                {
                    double euros = rubles / 90; // Конвертация рублей в евро.
                    resultTextBox.Text = $"{euros:F2} €"; // Вывод результата в текстовое поле результатов с двумя знаками после запятой.
                }
                else if (dollarRadioButton.Checked) // Проверка, выбрана ли радиокнопка доллара.
                {
                    double dollars = rubles / 75; // Конвертация рублей в доллары.
                    resultTextBox.Text = $"{dollars:F2} $"; // Вывод результата в текстовое поле результатов с двумя знаками после запятой.
                }
            }
            else
            {
                resultTextBox.Text = string.Empty; // Очистка текстового поля результатов, если ввод некорректен.
            }
        }
    }
}
