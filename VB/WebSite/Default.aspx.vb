Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub ASPxGridView1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		If grid.Columns.IndexOf(grid.Columns("CommandColumn")) <> -1 Then
			Return
		End If
		Dim col As New GridViewCommandColumn()
		col.Name = "CommandColumn"
		col.ShowSelectCheckbox = True
		col.VisibleIndex = 0
		grid.Columns.Add(col)

	End Sub
End Class
