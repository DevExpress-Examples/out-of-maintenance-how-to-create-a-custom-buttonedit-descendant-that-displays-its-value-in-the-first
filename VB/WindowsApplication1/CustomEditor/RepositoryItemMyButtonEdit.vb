Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"

		Public Overrides Sub CreateDefaultButton()
			MyBase.CreateDefaultButton()
			Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
			Buttons(0).Caption = "Test"
		End Sub

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(MyViewInfo), New ButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

	End Class

End Namespace