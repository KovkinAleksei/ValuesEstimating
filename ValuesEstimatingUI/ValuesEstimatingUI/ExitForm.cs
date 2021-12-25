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
    public partial class ExitForm : MaterialForm
    {
        public ExitForm()
        {
            // Тёмная тема окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.LightGreen900,
                Primary.Green500, Accent.Green400, TextShade.WHITE);

            InitializeComponent();

            this.ActiveControl = cancelButton;
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Отмена закрытия окна
        /// </summary>

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
