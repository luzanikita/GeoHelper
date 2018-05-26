using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoHelper
{
    // Класс, содержащий методы для валидации полейформ.
    class Validator
    {
        public static bool ValidName(TextBox field, bool required = false)
        {
            string pattern = @"^[А-Я][а-я]+(['-]([А-Я][а-я]*)|([а-я]+))?$";
            if (!required && field.Text == "" || Regex.IsMatch(field.Text, pattern))
            {
                field.BackColor = Color.White;
                return true;
            }
            field.BackColor = Color.Pink;
            MessageBox.Show("Название может состоять только из букв кириллицы, дефиса и апострофа.\n" +
                "Название состоит из одного слова длиной не меньше 2 символов.",
                "Неправильно заполнены поля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        // Валидация полей на содержание действительных чисел больше нуля.
        public static bool ValidDoubleField(TextBox field, bool required = false)
        {
            double x = 0;
            if (!required && field.Text == "" || Double.TryParse(field.Text, out x))
            {
                if (x >= 0)
                {
                    field.BackColor = Color.White;
                    return true;
                }
            }
            field.BackColor = Color.Pink;
            MessageBox.Show("Поля должны быть заполнены действительными числами больше нуля!",
                "Неправильно заполнены поля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        // Валидация полей на содержание целых чисе больше нуля.
        public static bool ValidIntField(TextBox field, bool required = false)
        {
            int x = 0;
            if (!required && field.Text == "" || Int32.TryParse(field.Text, out x))
            {
                if (x >= 0)
                {
                    field.BackColor = Color.White;
                    return true;
                }
            }
                field.BackColor = Color.Pink;
                MessageBox.Show("Поля должны быть заполнены целыми числами больше нуля!",
                    "Неправильно заполнены поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
        }

        // Валидация парных полей, описывающих диапазон действительных чисел.
        public static bool ValidDoubleMinMaxTextBox(TextBox minField, TextBox maxField, bool required = false)
        {
            double min = !required && minField.Text == "" ? -2 : 0;
            double max = !required && maxField.Text == "" ? -1 : 0;

            if ((min == -2 || Double.TryParse(minField.Text, out min)) &&
                (max == -1 || Double.TryParse(maxField.Text, out max)))
            {
                if (max == -1 || min <= max)
                {
                    minField.BackColor = Color.White;
                    maxField.BackColor = Color.White;
                    return true;
                }
            }
            minField.BackColor = Color.Pink;
            maxField.BackColor = Color.Pink;
            MessageBox.Show("Поля должны быть заполнены действительными числами!\nМинимальное значение должно быть меньше либо равно максимальному!",
                    "Неправильно заполнены поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валидация парных полей, описывающих диапазон целых чисел.
        public static bool ValidIntMinMaxTextBox(TextBox minField, TextBox maxField, bool required = false)
        {
            int min = !required && minField.Text == "" ? -2 : 0;
            int max = !required && maxField.Text == "" ? -1 : 0;

            if ((min == -2 || Int32.TryParse(minField.Text, out min)) &&
                (max == -1 || Int32.TryParse(maxField.Text, out max)))
            {
                if (max == -1 || min <= max)
                {
                    minField.BackColor = Color.White;
                    maxField.BackColor = Color.White;
                    return true;
                }
            }
            minField.BackColor = Color.Pink;
            maxField.BackColor = Color.Pink;
            MessageBox.Show("Поля должны быть заполнены целыми числами!\nМинимальное значение должно быть меньше либо равно максимальному!",
                    "Неправильно заполнены поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валидация полей координат.
        public static bool ValidCoordTextBox(TextBox field, bool required = false)
        {
            double x = 0;
            if (!required && field.Text == "" || Double.TryParse(field.Text, out x))
            {
                if (x >= -90 && x <= 90)
                {
                    field.BackColor = Color.White;
                    return true;
                }
            }
            field.BackColor = Color.Pink;
            MessageBox.Show("Поля должны быть заполнены действительными числами!\n" +
                "Значения координат должно быть в пределах от 0 до 90.\n" +
                "Положительные значения отвечают за северную широту и западную долготу.\n" +
                "Отрицательные значения отвечают за южную широту и восточную долготу.",
                    "Неправильно заполнены поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валидация полей с выбором из списка, на содержание
        public static bool ValidComboBox<T>(ComboBox field)
        {
            List<T> data = (List<T>)field.DataSource;
            foreach (var item in data)
            {
                if (item.ToString() == field.Text)
                {
                    field.BackColor = Color.White;
                    return true;
                }
            }
            field.BackColor = Color.Pink;
            MessageBox.Show("Значение поля должно существовать в списке",
                    "Неправильно заполнены поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }
    }
}