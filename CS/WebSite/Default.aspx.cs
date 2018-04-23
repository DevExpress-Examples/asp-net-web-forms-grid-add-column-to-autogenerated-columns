using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load (object sender, EventArgs e) {

    }
    protected void ASPxGridView1_DataBound (object sender, EventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        if (grid.Columns.IndexOf(grid.Columns["CommandColumn"]) != -1)
            return;
        GridViewCommandColumn col = new GridViewCommandColumn();
        col.Name = "CommandColumn";
        col.ShowSelectCheckbox = true;
        col.VisibleIndex = 0;
        grid.Columns.Add(col);

    }
}
