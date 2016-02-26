using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealTechHub
{
    public partial class ProductsEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var dbAccess = new DBAccess();
                var product = new Products
                {

                    ProductName = Convert.ToString(txtproductname.Text),
                    SupplierID = Convert.ToInt32(txtsupplier.Text),
                    CategoryID = Convert.ToInt32(txtctegoryid.Text),
                    QuantityPerUnit = Convert.ToString(txtQuantityPerUnit.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                    UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text),
                    ReorderLevel = Convert.ToInt32(txtReorderLevel.Text),
                    Discontinued = Convert.ToBoolean(txtDiscontinued.Text)
                };

                var strXml = cCommonUtils.GetXML(product);

                strXml = strXml.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                strXml = strXml.Replace("'", "''");

                dbAccess.ExecuteSQL(string.Format("EXEC USP_SAVEPRODUCTS '{0}'", strXml));
            }
            catch (Exception ex)
            {
                
            }   
        }
    }
}