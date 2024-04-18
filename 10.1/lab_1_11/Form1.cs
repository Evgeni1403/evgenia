using System; // Импорт стандартного пространства имен, содержащего базовые утилиты.
using System.Windows.Forms; // Для создания оконных приложений.

namespace lab_1_11 // Определение пространства имен для группировки связанных классов.
{
    public partial class Form1 : Form // Определение класса Form1, наследуемого от класса Form.
    {
        public Form1() // Конструктор класса Form1.
        {
            InitializeComponent(); // Метод для инициализации компонентов формы.
        }

        private void calculateButton_Click(object sender, EventArgs e) // Обработчик события клика по кнопке.
        {
            // Попытка преобразования текста из текстовых полей в числовые значения.
            if (double.TryParse(R1TextBox.Text, out double R1) &&
                double.TryParse(R2TextBox.Text, out double R2) &&
                double.TryParse(R3TextBox.Text, out double R3))
            {
                // Проверка на ненулевые значения сопротивлений.
                if (R1 == 0 || R2 == 0 || R3 == 0)
                {
                    // Вывод сообщения об ошибке, если какое-либо сопротивление равно нулю.
                    MessageBox.Show("Сопротивление не может быть нулевым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Расчет общего сопротивления для параллельного соединения.
                    double totalResistance = 1 / (1 / R1 + 1 / R2 + 1 / R3);

                    // Отображение рассчитанного значения сопротивления.
                    resultLabel.Text = $"Общее\nсопротивление: \n{totalResistance:F3} Ом";
                }
            }
            else
            {
                // Вывод сообщения об ошибке, если значения сопротивлений не могут быть преобразованы в числа.
                MessageBox.Show("Пожалуйста, введите числовые значения для сопротивлений", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
