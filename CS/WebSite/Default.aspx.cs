using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void ASPxCallbackPanel1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e) {
        string[] parameters = e.Parameter.Split('|');
        string from = Server.MapPath(parameters[1]);
        string to = Path.Combine(Server.MapPath("~/Folder1/Recycle/"), parameters[2]);
        if(parameters[0] == "folder") {
            Directory.Move(@from, @to);
            ASPxFileManager1.Refresh();
        }
        else
            File.Move(@from, @to);
    }
}