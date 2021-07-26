﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ValuesEstimatingUI
{
    public partial class HelpForm : MaterialForm
    {
        public HelpForm()
        {
            InitializeComponent();

            // Темная тема окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.LightGreen900,
                Primary.Green500, Accent.Green400, TextShade.WHITE);

            //helpTextBoxhh.Font = new Font(helpTextBoxhh.Font, FontStyle.Bold);
            helpTextBox.Text = "Ввод результатов измерений" +
                Environment.NewLine +
                "Введите не менее трёх значений результатов измерений в главном окне. " +
                "Числа вводятся через пробел, дробная часть отделяется запятой." +
                Environment.NewLine + Environment.NewLine +

                "Пример введённых данных: 80 81 79,5 83 80 77 79,7 81,5 80 80,3 80 " +
                Environment.NewLine + Environment.NewLine +

                "Доверительная вероятность" +
                Environment.NewLine +
                "Доверительная вероятность устанавливает, с какой вероятностью истинное значение измеряемой величины " +
                "попадает в доверительные границы погрешности. Чем выше доверительная вероятность, тем шире " +
                "доверительные границы погрешности." +
                Environment.NewLine + Environment.NewLine +
                "Для выбора доверительной вероятности нажмите раскройте список Доверительная вероятность " +
                "и выберете значение: 0.9, 0.95, 0,99 или 0,999." +
                Environment.NewLine + Environment.NewLine +

                "Вывод результата измерений" +
                Environment.NewLine +
                "Для вывода результата измерений без учёта дополнительной и основной погрешности нажмите кнопку Ввод " +
                "в правом нижнем углу главного окна программы." +
                Environment.NewLine + Environment.NewLine +

                "Дополнительная погрешность" +
                Environment.NewLine +
                "Дополнительная погрешность возникает при эксплуатации прибора в условиях, " +
                "отличающихся от нормальных (пониженная температура, повышенная влажность, не то напряжение питания)." +
                Environment.NewLine + Environment.NewLine +

                "Для ввода дополнительной погрешности нажмите кнопку Дополнительная погрешность и " +
                "введите значение дополнительной погрешности в всплывающем окне." +
                Environment.NewLine + Environment.NewLine +

                "Основная погрешность" +
                Environment.NewLine +
                "Основная погрешность возникает при эксплуатации прибора в нормальных условиях " +
                "(указанных в паспорте прибора). Эта погрешность приведена в паспорте прибора. Одним из способов " +
                "нормирования основной погрешности измерительной системы является присвоение прибору класса точности. " +
                Environment.NewLine +
                "Класс точности - это метрологическая характеристика прибора, определяющая гарантированную границу его основной " +
                "погрешности." +
                Environment.NewLine + Environment.NewLine +

                "По характеру зависимости от измеряемой величины основная погрешность прибора может быть аддитивной " +
                "(при измерении любых значений измеряемой величины всегда будет одна и та же погрешность, " +
                "нормирующим значением является геометрическая величина шкалы прибора), " +
                "мультипликативной (у таких приборов погрешность линейна) или " +
                "аддитивной и мультипликативной (погрешность имеет как аддитивный, так и мультипликативный характер, " +
                "нормирующим значением является геометрическая величина шкалы прибора)." +
                Environment.NewLine + Environment.NewLine +

                "Для ввода основной погрешности нажмите кнопку Основная погрешность " +
                "и введите в всплывающем окне значение основной погрешности вручную или" +
                " укажите метрологические характеристики средства " +
                "измерения для автоматического расчёта значения основной погрешности (класс точности прибора, характер основной погрешности, " +
                "нормирующую величину)." +
                Environment.NewLine + Environment.NewLine +

                "Сохранение результатов измерения" +
                Environment.NewLine + 
                "Для сохранения результатов измерения в текстовом файле нажмите на кнопку Сохранить в файле в левом " +
                "нижнем углу окна вывода результатов измерений. В всплывающем окне выберете путь сохранения файла и " +
                "нажмите на кнопку Сохранить.";

            this.ActiveControl = focusLabel;
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
