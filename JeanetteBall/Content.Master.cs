using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace JeanetteBall
{
    public partial class Content : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // todo: remove try/catch block once minor menu has been implemented
            try
            {
                // Background Image
                String imgName = SiteMap.CurrentNode["backgroundImg"];
                String imgPath = System.Web.VirtualPathUtility.ToAbsolute("~/images/bg/" + imgName + "");
                contentContainerDiv.Style.Add("background-image", "url(" + imgPath + ")");

                // Page Title
                String pageTitle = SiteMap.CurrentNode.Title;
                Page.Header.Title = "Jeanette Ball Dance - " + pageTitle;

                // Content Text Title
                if (contentTextTitle != null)
                {
                    contentTextTitle.Text = pageTitle;
                }
            }
            catch
            {
            }

           
        }
    }
}
