Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class MyViewInfo
		Inherits ButtonEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)

		End Sub
		Protected Overrides Function CreateButtonPainter() As EditorButtonPainter
			Dim painter As New MySkinEditorButtonPainter(LookAndFeel)
			painter.OwnerEditInfo = Me
			Return painter
		End Function

	End Class
End Namespace