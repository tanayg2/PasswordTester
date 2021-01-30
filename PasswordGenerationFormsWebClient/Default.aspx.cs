using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PasswordGenerationFormsWebClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            //Get values from service
            string word = txtInput.Text;

            int numVowels = client.VowelCount(word);
            int numUpper = client.UpperCaseCount(word);
            string reverseWord = client.Reverse(word);

            try
            {
                //Update labels
                vowelCtOutLbl.Text = numVowels.ToString();
                upperCtOutLbl.Text = numUpper.ToString();
                reverseOutLbl.Text = reverseWord;
            }
            catch (Exception ex)
            {
                //If exception is thrown, write to hidden error label, allowing service to continue being used
                ErrorLbl.Text = ex.ToString();
            }
        }
    }
}