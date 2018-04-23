using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1 {
    [System.ComponentModel.DesignerCategory("")]
	[UserRepositoryItem("Register")]
	public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit { 
		static RepositoryItemMyButtonEdit() { 
			Register(); 
		}
		public RepositoryItemMyButtonEdit() 
        {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
        }
		
		internal const string EditorName = "MyButtonEdit";

        public override void CreateDefaultButton()
        {
            base.CreateDefaultButton();
            Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            Buttons[0].Caption = "Test";
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(MyViewInfo),
                new ButtonEditPainter(), true, null));
        }
		public override string EditorTypeName { 
			get { return EditorName; } 
		}

	}
 
}
