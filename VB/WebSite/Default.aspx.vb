Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		Dim parameters() As String = e.Parameter.Split("|"c)
		Dim From As String = Server.MapPath(parameters(1))
		Dim [to] As String = Path.Combine(Server.MapPath("~/Folder1/Recycle/"), parameters(2))
		If parameters(0) = "folder" Then
			Directory.Move([from], [to])
			ASPxFileManager1.Refresh()
		Else
			File.Move([from], [to])
		End If
	End Sub
End Class