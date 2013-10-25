using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej_LlenarDDL
{
    public partial class DividirCadena_si_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cadena que resulta de busqueda en el texto ingresado como separador
            char[] delimiterChars = {','};
            //guardo en text el valor ingresadi desde el form
            string text = TextBox1.Text;
            
            //creo un array 
            string[] words = text.Split(delimiterChars);
            int cantidadMails = words.Length;

            crearBucle(words, cantidadMails);  
        }
        
        private void crearBucle(string[] words,int cantidadmails)
        {
            lblcantmails.Text = cantidadmails.ToString();
            List<string> mails = new List<string>();
                foreach (string s in words)
                {
                    while (cantidadmails > 0)
                    {
                        mails.Add(words[cantidadmails - 1]);
                        cantidadmails = cantidadmails-1;
                    }
                }
                ImprimirMailsPorSeparado(mails);
                ImprimirDiferencias(consultarMails(mails));
                
               // List<ListaMail> miLista = new List<ListaMail>();
        }

        private void ImprimirDiferencias(List<string> list)
        {
            gvcoincid.DataSource = list;
            gvcoincid.DataBind();
        }

        private void ImprimirMailsPorSeparado(List<string> mails)
        {
            gvlista.DataSource = mails;
            gvlista.DataBind();
        }

        private List<string> consultarMails(List<string> mails)
        {
            
            List<string> resulta = new List<string>();
            
            //traigo todos los mails de la base de datos
            EJEMPLOEntities ctx = new EJEMPLOEntities();
            var consulta = (from c in ctx.MAILS
                            select c.mail).ToList();
            
            //comparo componentes de cada lista
            IEnumerable<string> Diferencias = mails.Except(consulta);
            
            //guardo en nueva lista los componentes que no son iguales
            foreach (string f in Diferencias) {
                resulta.Add(f);    
            }
            //
            //List<ListaMail> miLista = new List<ListaMail>();
            //List<List<string>> listaMails = new List<List<string>>();
            ////
            //if (resulta.Count > 0) {
            //    for (int i = 0; i < resulta.Count; i++) {
            //        listaMails.Add(new List<string> { miLista[i].idLista.ToString(), miLista[i].mailLista});
            //    }
            //}

            //valor de retorno->Lista de componentes diferentes a los traidos de la base
            PasarListaBD(resulta);
            return resulta;
        }

        private void PasarListaBD(List<string> resulta)
        {
            List<ListaMail> miLista = new List<ListaMail>();
            
            foreach (string f in resulta) {
                for (int i = 0; i < (resulta.Count)-1; i++) {
                    crearObjeto(miLista[i].idLista, miLista[i].mailLista);
                    //ListaMail lis1 = new ListaMail();
                    // lis1.idLista =  miLista[i].idLista;
                    // lis1.mailLista = miLista[i].mailLista;
                    // miLista.Add(lis1);
                }
            }
        }

        private void crearObjeto(int p, string p_2)
        {
            ListaMail lis1 = new ListaMail();
            lis1.idLista =  p;
            lis1.mailLista = p_2;
            EJEMPLOEntities ctx = new EJEMPLOEntities();
            ctx.MAILS.AddObject(new MailAlumnos { idmail = p, mail = p_2 });
            ctx.SaveChanges();
        }
    }
}