using ABCAutomotive.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal int selectedPageIndex;
        internal List<PageControl> list = new List<PageControl>();

        private int formerPagePosistion;

        private void btnLoan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLoan.Height;
            SidePanel.Top = btnLoan.Top;

            formerPagePosistion = 0;
            DisplayPage(panel2, Loans.Instance);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReturns.Height;
            SidePanel.Top = btnReturns.Top;

            formerPagePosistion = 1;
            DisplayPage(panel2, Returns.Instance);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPayment.Height;
            SidePanel.Top = btnPayment.Top;

            formerPagePosistion = 2;
            DisplayPage(panel2, Payment.Instance);
        }

        #region TabMethods
        public void DisplayPage(Panel panel, PageControl page)
        {

            list = panel2.Controls.OfType<PageControl>().ToList().OrderBy(pa => pa.Position).ToList();

            if (!panel.Contains(page))
            {
                panel2.Controls.Add(page);
                //page.Dock = DockStyle.Fill;
                //page.BringToFront();
            }
            else
            {
                //page.Dock = DockStyle.Fill;
                //page.BringToFront();
            }
            page.Dock = DockStyle.Fill;
            page.BringToFront();
        }

        //public int ChangePageAccordingly()
        //{
        //    //if (formerPagePosistion == 0)
        //    //{
        //    //    return 1;
        //    //}

        //    //if (formerPagePosistion == 1)
        //    //{
        //    //    return 0;
        //    //}
        //    //if (formerPagePosistion == 2)
        //    //{
        //    //    return 3;
        //    //}
        //    //if (formerPagePosistion == 3)
        //    //{
        //    //    return 2;
        //    //}
        //    //return 3;

        //    return 0;
        //}

        public void ChangeSelectedPage()
        {
            
            if (selectedPageIndex > list.Count - 1)
            {
                selectedPageIndex--;

            }
            int previousPageIndex;
            int nextPageIndex;
            switch (selectedPageIndex)
            {

                case 0:

                    nextPageIndex = selectedPageIndex;
                    previousPageIndex = selectedPageIndex - 1;
                    DetermineNextTab(panel2, nextPageIndex, previousPageIndex);
                    break;

                case 1:
                    nextPageIndex = selectedPageIndex;
                    previousPageIndex = selectedPageIndex - 1;
                    DetermineNextTab(panel2, previousPageIndex, nextPageIndex);
                    break;

                case 2:
                    nextPageIndex = selectedPageIndex;
                    previousPageIndex = selectedPageIndex - 1;
                    DetermineNextTab(panel2, previousPageIndex, nextPageIndex);

                    break;

                case 3:
                    nextPageIndex = selectedPageIndex;
                    previousPageIndex = selectedPageIndex - 1;
                    DetermineNextTab(panel2, previousPageIndex, nextPageIndex);
                    break;


                default:
                    nextPageIndex = 0;
                    previousPageIndex = selectedPageIndex - 1;
                    DetermineNextTab(panel2, nextPageIndex, previousPageIndex);

                    break;
            }


        }

        private void DetermineNextTab(Panel panel, int tabOne, int tabTwo)
        {
            list = panel2.Controls.OfType<PageControl>().ToList().OrderBy(pa => pa.Position).ToList();

            if (panel.Controls.OfType<PageControl>().Count() > 0)
            {

                if (panel.Controls.Contains(list[tabOne]))
                {
                    DisplayPage(panel, list[tabOne]);
                }
                else if (panel.Controls.Contains(list[tabTwo]))
                {
                    DisplayPage(panel, list[tabTwo]);
                }

            }         

        }

        #endregion TabMethods

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReserve.Height;
            SidePanel.Top = btnReserve.Top;

            DisplayPage(panel2, Reserve.Instance);

        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnModifyStudent.Height;
            SidePanel.Top = btnModifyStudent.Top;

            DisplayPage(panel2, EditStudent.Instance);
        }
    }
}
