using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RealTechHub
{
    public class basepage
    {
        public string Menubuilder()
        {
            StringBuilder sb = new StringBuilder();
            var dbaccess = new DBAccess();
            var ds = dbaccess.ExecuteSQL("select * from [dbo].[mainmenu]");
            List<Menu> listMenu = new List<Menu>();
            if (ds.Tables[0] != null && ds != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listMenu.Add(
                    new Menu
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        MenuName = Convert.ToString(dr["MenuName"]),
                        ParentId = dr["ParentId"] != DBNull.Value ? Convert.ToInt32(dr["ParentID"]) : (int?)null,
                        CssClass = dr["CssClass"] != DBNull.Value ? Convert.ToString(dr["CssClass"]) : (string)null,
                        NavigateUrl = dr["NavigateUrl"] != DBNull.Value ? Convert.ToString(dr["NavigateUrl"]) : (string)null,
                        Active = Convert.ToBoolean(dr["Active"])
                    });
                }


                sb.Append("<ul class='nav nav-pills nav-stacked custom-nav'>");
                sb.Append(GenerateMenu(listMenu, null, sb));
                sb.Append("</ul>");
            }

            return sb.ToString();

        }

        public string GenerateMenu(List<Menu> lstmenu, int? parent, StringBuilder sbMenu)
        {


            var lMenu = lstmenu.Where(x => x.ParentId == parent).ToList();

            if (lMenu != null && lMenu.Count > 0)
            {
                for (int i = 0; i <= lMenu.Count() - 1; i++)
                {

                    if (lMenu[i].NavigateUrl == "" && lMenu[i].NavigateUrl == null)
                    {
                        sbMenu.AppendFormat("<li class='menu-list'><a href='{0}'><i class='{1}'></i>", lMenu[i].NavigateUrl, lMenu[i].CssClass, lMenu[i].MenuName);
                        if (lMenu[i].MenuName != null && lMenu[i].MenuName != "")
                        {
                            sbMenu.AppendFormat("<span>{0}</span></a></li>", lMenu[i].MenuName);
                        }
                        else
                        {
                            sbMenu.Append("</a></li>");
                        }
                        sbMenu.Append("<li class='menu-list'>");
                        sbMenu.Append("<ul class='sub-menu-list'>");
                        GenerateMenu(lstmenu, lMenu[i].Id, sbMenu);
                        sbMenu.Append("</ul>");
                        sbMenu.Append("</li>");
                    }
                    else
                    {
                        sbMenu.AppendFormat("<li><a href='{0}'><i class='{1}'></i>", lMenu[i].NavigateUrl, lMenu[i].CssClass);
                        if (lMenu[i].MenuName != null && lMenu[i].MenuName != "")
                        {
                            sbMenu.AppendFormat("<span>{0}</span></a></li>", lMenu[i].MenuName);
                        }
                        else
                        {
                            sbMenu.Append("</a></li>");
                        }
                    }
                }
            }
            return sbMenu.ToString();
        }

        public class Menu
        {
            public int Id { get; set; }
            public string MenuName { get; set; }
            public int? ParentId { get; set; }
            public string CssClass { get; set; }
            public string NavigateUrl { get; set; }
            public bool Active { get; set; }
            public List<Menu> submenu { get; set; }
        }
    }
}