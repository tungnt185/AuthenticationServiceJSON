using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerDemoApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Test.AuthenticationServiceClient client = new Test.AuthenticationServiceClient();
            bool result = client.Login("nttung", "123456", null, true);
            Response.Write(result);
        }
    }
}