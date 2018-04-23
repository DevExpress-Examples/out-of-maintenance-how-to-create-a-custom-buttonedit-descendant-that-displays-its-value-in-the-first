using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace WindowsApplication1
{
  [System.ComponentModel.DesignerCategory("")]
    public class MyButtonEdit : ButtonEdit
    {
        static MyButtonEdit()
        {
            RepositoryItemMyButtonEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }
    }
}
