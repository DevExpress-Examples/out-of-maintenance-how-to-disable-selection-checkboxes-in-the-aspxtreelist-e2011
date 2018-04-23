using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.ASPxTreeList.Internal;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void ASPxTreeListDemo_HtmlRowPrepared(object sender, DevExpress.Web.ASPxTreeList.TreeListHtmlRowEventArgs e)
    {
        ASPxTreeList treeList = (ASPxTreeList)sender;
        WebControl selectionCheckbox = null;
        foreach (TableCell cell in e.Row.Cells)
        {
            TreeListSelectionCell selectionCell = cell as TreeListSelectionCell;
            if (selectionCell != null)
            {
                selectionCheckbox = (WebControl)selectionCell.Controls[0];
                break;
            }
        }
        if (selectionCheckbox != null)
        {
            TreeListNode node = treeList.FindNodeByKeyValue(e.NodeKey);
            if (node.HasChildren)
                selectionCheckbox.Enabled = false;
        }
    }
}