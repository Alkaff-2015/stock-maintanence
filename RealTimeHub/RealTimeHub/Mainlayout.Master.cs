using System;

namespace RealTechHub
{
    public partial class Mainlayout : System.Web.UI.MasterPage
    {
        basepage baseclass = new basepage();

        public string Menulst { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.DataBind();

            if (Session["Menu"] == null)
            {
                Session["Menu"] = baseclass.Menubuilder();
                Menulst = Session["Menu"].ToString();
            }
            else
            {
                Menulst = Session["Menu"].ToString();
            }
            LtrlMenu.Text = Menulst;
        }







    }
}