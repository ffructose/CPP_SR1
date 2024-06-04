using System;
using System.Linq;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        Calculator calculator = new Calculator();

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateMultiplesOf6()
        {
            try
            {
                calculator.A = int.Parse(entryA1.Text);
                calculator.B = int.Parse(entryB1.Text);
                int result = calculator.ProductOfMultiplesOf6();
                resultLabel1.Text = $"Добуток чисел, кратних 6: {result}";
            }
            catch (Exception ex)
            {
                resultLabel1.Text = $"Помилка: {ex.Message}";
            }
        }

        private void CalculateInRange()
        {
            try
            {
                calculator.Numbers = new int[]
                {
                    int.Parse(entry1.Text),
                    int.Parse(entry2.Text),
                    int.Parse(entry3.Text)
                };
                int result = calculator.ProductInRange();
                resultLabel2.Text = $"Добуток чисел в діапазоні (10, 15): {result}";
            }
            catch (Exception ex)
            {
                resultLabel2.Text = $"Помилка: {ex.Message}";
            }
        }

        private void CalculateMultiplesOf6Btn_Clicked(object sender, EventArgs e)
        {
            CalculateMultiplesOf6();
        }

        private void CalculateInRangeBtn_Clicked(object sender, EventArgs e)
        {
            CalculateInRange();
        }
    }
}
