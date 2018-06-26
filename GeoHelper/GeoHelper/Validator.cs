using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GeoHelper
{
    // Класс з методами валідації полей форм.
    class Validator
    {
        public static bool ValidName(TextBox field, bool required = false)
        {
            string pattern = @"^[А-ЯІЇҐ][а-яіїґ\'\-]+(['-]([А-ЯІЇҐ][а-яіїґ\'\-]*)|([а-яіїґ]+))?$";
            if (!required && field.Text == "" || Regex.IsMatch(field.Text, pattern))
            {
                field.BackColor = Color.White;
                return true;
            }
            field.BackColor = Color.Pink;
            MessageBox.Show("Назва може складатися лише з літер української мови, дефісу та апострофа.\n" +
                "Назва складається з одного слова довжиною не менше 2 символів.",
                "Неправильно заповнені поля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        // Валідація полей на наявність дійсних чисел більше за нуль.
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
            MessageBox.Show("Поля повинні бути заповнені дійсними числами більше за нуль!",
                "Неправильно заповнені поля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        // Валідація полів на наявність цілих чисел більше за нуль.
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
                MessageBox.Show("Поля повинні бути заповнені цілими числами більше за нуль!",
                    "Неправильно заповнені поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
        }

        // Валідація полів, що описують діапазон дійсних чисел.
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
            MessageBox.Show("Поля повинні бути заповнені дійсними числами більше за нуль!\n" +
                "Мінімальне значення повинно бути менше або рівним максимальному!",
                    "Неправильно заповнені поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валідація полів, що описують діапазон цілих чисел.
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
            MessageBox.Show("Поля повинні бути заповнені цілими числами більше за нуль!!\n" +
                "Мінімальне значення повинно бути менше або рівним максимальному!",
                    "Неправильно заповнені поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валідація полів з координатами.
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
            MessageBox.Show("Поля повинні бути заповнені дійсними числами!\n" +
                "Значення координат повинні бути у межах від -90 до 90.\n" +
                "Додатні занчення відповідають північній широті та західній довготі.\n" +
                "Від'ємні значення відповідають південній широті та східній довготі.",
                    "Неправильно заповнені поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }

        // Валідація полів з вибором зі списка.
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
            MessageBox.Show("Значення поля повинно існувати у списку.",
                    "Неправильно заповнені поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return false;
        }
    }
}