Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports System.Drawing
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.ExpressApp.SystemModule

Namespace Solution15.Module

	<NavigationItem, OptimisticLocking(False)> _
	Public Class Employees
		Inherits XPBaseObject
		Public Address As String
		Public BirthDate As DateTime
		Public City As String
		Public Country As String
		<Key> _
		Public EmployeeID As Integer
		Public Extension As String
		Public FirstName As String
		Public HireDate As DateTime
		Public HomePhone As String
		Public LastName As String
		Public Notes As String
		<ValueConverter(GetType(ImageValueConverter))> _
		Public Photo As Image
		Public PostalCode As String
		Public Region As String
		Public ReportsTo As Integer
		Public Title As String
		Public TitleOfCourtesy As String
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

End Namespace
