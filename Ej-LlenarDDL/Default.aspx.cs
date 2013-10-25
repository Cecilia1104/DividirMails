using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej_LlenarDDL
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 

            ListItem item = new ListItem("Hola Mundo", "Hola Mundo");

            this.DropDownList1.Items.Add(item);

            item = new ListItem("Hola Mundo 2", "Hola Mundo 2");

            this.DropDownList1.Items.Add(item);


            // Crea un nuevo Item
            ListItem oItem = new ListItem("Juan Valdes", "1");
            // Lo agrega a la colección de Items del DropDownList
            ddlComputedColumns.Items.Add(oItem);
        }


        }
    }
}
