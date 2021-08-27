<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2011)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to disable selection checkboxes in the ASPxTreeList


<p>This example demonstrates how to disable the selection checkboxes in the ASPxTreeList in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeListASPxTreeList_HtmlRowPreparedtopic"><u>ASPxTreeList.HtmlRowPrepared</u></a> event handler.</p><p><strong>Note:</strong> This approach does not work with the <a href="http://community.devexpress.com/blogs/aspnet/archive/2011/04/26/asp-net-check-box-new-render-state-for-multiple-controls-coming-soon-in-2011-volume-1.aspx"><u>Three-state checkbox</u></a> feature implementation starting with version v2011 vol 1.</p>


<h3>Description</h3>

<p>The selection checkbox reference can be get in one of the Cells.Controls hierarchy.</p><p>This approach does not work with the <a href="http://community.devexpress.com/blogs/aspnet/archive/2011/04/26/asp-net-check-box-new-render-state-for-multiple-controls-coming-soon-in-2011-volume-1.aspx"><u>Three-state checkbox</u></a> feature implementation starting with version v2011 vol 1.</p>

<br/>


