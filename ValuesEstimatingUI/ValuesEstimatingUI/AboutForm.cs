using System;
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
    public partial class AboutForm : MaterialForm
    {
        public AboutForm()
        {
            InitializeComponent();

            // Темная тема окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.LightGreen900,
                Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        /// <summary>
        /// Переход по ссылке на e-mail
        /// </summary>
        private void eMailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                eMailLinkLabel.LinkVisited = true;
                System.Diagnostics.Process.Start("mailto:akovkin6@gmail.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно перейти по ссылке");
            }
        }

        /// <summary>
        /// Переход по ссылке на GitHub
        /// </summary>
        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                gitHubLinkLabel.LinkVisited = true;
                System.Diagnostics.Process.Start("https://github.com/KovkinAleksei/ValuesEstimating");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно перейти по ссылке");
            }
        }

        /// <summary>
        /// Нажатие на кнопку Закрыть
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
