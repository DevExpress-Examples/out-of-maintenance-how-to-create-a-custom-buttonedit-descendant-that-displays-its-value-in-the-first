using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class MyViewInfo : ButtonEditViewInfo
    {
        public MyViewInfo(RepositoryItem item)
            : base(item)
        {

        }
        protected override EditorButtonPainter CreateButtonPainter()
        {
            MySkinEditorButtonPainter painter = new MySkinEditorButtonPainter(LookAndFeel);
            painter.OwnerEditInfo = this;
            return painter;
        }

    }
}