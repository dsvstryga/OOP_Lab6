using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання даних з TextBox
                double x1 = double.Parse(textBoxX1.Text);
                double y1 = double.Parse(textBoxY1.Text);
                double A = double.Parse(textBoxA.Text);
                double B = double.Parse(textBoxB.Text);
                double C = double.Parse(textBoxC.Text);

                // Перевірка (щоб не було ділення на 0)
                if (A == 0 && B == 0)
                {
                    throw new Exception("A і B не можуть одночасно дорівнювати 0!");
                }

                // Обчислення
                double D = Math.Abs(A * x1 + B * y1 + C) / Math.Sqrt(A * A + B * B);

                // Вивід результату
                textBoxResult.Text = D.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні числа!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ділення на нуль!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
