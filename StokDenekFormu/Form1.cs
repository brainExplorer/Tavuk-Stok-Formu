using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokDenekFormu
{
    public partial class FrmAnaSayfa : Form
    {

        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)
            {
                if (currentButton != btnSender as Button)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlStokMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        /*
         * UserControl altında menüdeki sayfalara ulaşacağız
         */

        private void addUserControl(System.Windows.Forms.UserControl userControl, object sender)
        {
            ActivateButton(sender);
            userControl.Dock = DockStyle.Fill;
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlProduct product = new UserControlProduct();
            panelMenu.BringToFront();
            addUserControl(product, sender);

        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlSupplier supplier = new UserControlSupplier();
            addUserControl(supplier, sender);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlSupplier customer = new UserControlSupplier();
            addUserControl(customer, sender);
        }

        private void btnStockMovements_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlStokHareketleri userControlStokHareketleri = new UserControlStokHareketleri();
            addUserControl(userControlStokHareketleri, sender);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlWarehouse notification = new UserControlWarehouse();
            addUserControl(notification, sender);
        }

        private void btnAyar_Click_1(object sender, EventArgs e)
        {
            DisableButton();
            UserControlSettings settings = new UserControlSettings();
            addUserControl(settings, sender);

        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            DisableButton();
            UserControlReporting reporting = new UserControlReporting();
            addUserControl(reporting, sender);
        }
    }
}
