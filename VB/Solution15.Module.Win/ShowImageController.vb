Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Namespace Solution15.Module.Win

	Public Class ShowImageController
		Inherits ViewController(Of ListView)
		Private controller As ListViewProcessCurrentObjectController
		Protected Overrides Overloads Sub OnActivated()
			MyBase.OnActivated()
			controller = Frame.GetController(Of ListViewProcessCurrentObjectController)()
			AddHandler controller.CustomProcessSelectedItem, AddressOf controller_CustomProcessSelectedItem
		End Sub
		Protected Overrides Overloads Sub OnDeactivated()
			RemoveHandler controller.CustomProcessSelectedItem, AddressOf controller_CustomProcessSelectedItem
			MyBase.OnDeactivated()
		End Sub
		Private Sub controller_CustomProcessSelectedItem(ByVal sender As Object, ByVal e As CustomProcessListViewSelectedItemEventArgs)
			Dim editor As GridListEditor = TryCast(View.Editor, GridListEditor)
			If editor Is Nothing Then
				Return
			End If
			Dim ghi As GridHitInfo = editor.GridView.CalcHitInfo(editor.Grid.PointToClient(System.Windows.Forms.Control.MousePosition))
			If ghi.InRowCell Then
				Dim data As Object = editor.GridView.GetRowCellValue(ghi.RowHandle, ghi.Column)
				If TypeOf data Is Image Then
					ShowImageDialog(CType(data, Image))
					e.Handled = True
				End If
			End If
		End Sub
		Private Sub ShowImageDialog(ByVal image As Image)
			Dim form As New System.Windows.Forms.Form()
			Dim pbox As New System.Windows.Forms.PictureBox()
			pbox.Dock = System.Windows.Forms.DockStyle.Fill
			pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
			pbox.Image = image
			form.Controls.Add(pbox)
			form.Size = New Size(300, 300)
			form.ControlBox = False
			AddHandler pbox.DoubleClick, AddressOf pbox_DoubleClick
			form.ShowDialog()
			form.Dispose()
		End Sub
		Private Sub pbox_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, System.Windows.Forms.Control).FindForm().Close()
		End Sub
	End Class
End Namespace
