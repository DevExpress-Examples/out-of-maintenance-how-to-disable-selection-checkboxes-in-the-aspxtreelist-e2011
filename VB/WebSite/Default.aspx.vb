Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web.ASPxTreeList.Internal

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxTreeListDemo_HtmlRowPrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxTreeList.TreeListHtmlRowEventArgs)
		Dim treeList As ASPxTreeList = CType(sender, ASPxTreeList)
		Dim selectionCheckbox As WebControl = Nothing
		For Each cell As TableCell In e.Row.Cells
			Dim selectionCell As TreeListSelectionCell = TryCast(cell, TreeListSelectionCell)
			If selectionCell IsNot Nothing Then
				selectionCheckbox = CType(selectionCell.Controls(0), WebControl)
				Exit For
			End If
		Next cell
		If selectionCheckbox IsNot Nothing Then
			Dim node As TreeListNode = treeList.FindNodeByKeyValue(e.NodeKey)
			If node.HasChildren Then
				selectionCheckbox.Enabled = False
			End If
		End If
	End Sub
End Class