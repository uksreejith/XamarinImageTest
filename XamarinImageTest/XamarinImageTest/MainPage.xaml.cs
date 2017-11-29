using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinImageTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSetSource_Clicked(object sender, EventArgs e)
        {
            try
            {
                imgTest.Source = "";
                imgTest.Source = txtSource.Text;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            try
            {
                txtSource.Text = "";
                imgTest.Source = "";
                imgTest.Source = txtSource.Text;
                txtSource.Focus();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}
