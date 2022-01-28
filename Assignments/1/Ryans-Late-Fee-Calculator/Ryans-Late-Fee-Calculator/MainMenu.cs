/*
    Name: Asif Mahmud
    ID: C083711
    Assignment: 01
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ryans_Late_Fee_Calculator
{
    public partial class mainMenu : Form
    {
        calculateFee newReleaseObj;
        calculateFee libraryObj;
        calculateFee kidsObj;
        public mainMenu()
        {
            newReleaseObj = new calculateFee();
            libraryObj = new calculateFee();
            kidsObj = new calculateFee();
            InitializeComponent();
        }

        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            try
            {
                double lateFee = 2.00;
                newReleaseObj.setLateFee(lateFee, "New Release ($" + lateFee + "/day)");
                newReleaseObj.Show();
            }
            catch(System.ObjectDisposedException odEx)
            {
                newReleaseObj = new calculateFee();
                newReleaseObj.Show();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            try
            {
                double lateFee = 0.15;
                libraryObj.setLateFee(lateFee, "Kid's Movie ($" + lateFee + "/day)");
                libraryObj.Show();
            }
            catch (System.ObjectDisposedException odEx)
            {
                libraryObj = new calculateFee();
                libraryObj.Show();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            try
            {
                double lateFee = 0.57;
                kidsObj.setLateFee(lateFee, "Library Movie ($" + lateFee + "/day)");
                kidsObj.Show();
            }
            catch (System.ObjectDisposedException odEx)
            {
                kidsObj = new calculateFee();
                kidsObj.Show();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                Console.WriteLine(msg);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
