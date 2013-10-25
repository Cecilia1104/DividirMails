using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej_LlenarDDL
{
    public partial class PruebaSepararCadena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string SearchString ="";
            
            List<string> SearchChar = new List<string>();

            SearchString = TextBox1.Text;
            while (String.IsNullOrEmpty(SearchString))
            {


            }
            //string[] split = SearchString.Split(new Char[] { '\n' });
            //foreach (string s in split)
            //{
            //    if (s.Trim() != "-")
            //    {
            //        SearchChar += s;
            //    }
            //}
        }
    }
}