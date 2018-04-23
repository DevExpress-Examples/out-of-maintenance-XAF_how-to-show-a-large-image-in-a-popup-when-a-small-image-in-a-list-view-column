using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace Solution15.Module.Win {

    public class ShowImageController : ViewController<ListView> {
        ListViewProcessCurrentObjectController controller;
        protected override void OnActivated() {
            base.OnActivated();
            controller = Frame.GetController<ListViewProcessCurrentObjectController>();
            controller.CustomProcessSelectedItem += new EventHandler<CustomProcessListViewSelectedItemEventArgs>(controller_CustomProcessSelectedItem);
        }
        protected override void OnDeactivated() {
            controller.CustomProcessSelectedItem -= new EventHandler<CustomProcessListViewSelectedItemEventArgs>(controller_CustomProcessSelectedItem);
            base.OnDeactivated();
        }
        void controller_CustomProcessSelectedItem(object sender, CustomProcessListViewSelectedItemEventArgs e) {
            GridListEditor editor = View.Editor as GridListEditor;
            if (editor == null) return;
            GridHitInfo ghi = editor.GridView.CalcHitInfo(editor.Grid.PointToClient(System.Windows.Forms.Control.MousePosition));
            if (ghi.InRowCell) {
                object data = editor.GridView.GetRowCellValue(ghi.RowHandle, ghi.Column);
                if (data is Image) {
                    ShowImageDialog((Image)data);
                    e.Handled = true;
                }
            }
        }
        private void ShowImageDialog(Image image) {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            System.Windows.Forms.PictureBox pbox = new System.Windows.Forms.PictureBox();
            pbox.Dock = System.Windows.Forms.DockStyle.Fill;
            pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbox.Image = image;
            form.Controls.Add(pbox);
            form.Size = new Size(300, 300);
            form.ControlBox = false;
            pbox.DoubleClick += new EventHandler(pbox_DoubleClick);
            form.ShowDialog();
            form.Dispose();
        }
        void pbox_DoubleClick(object sender, EventArgs e) {
            ((System.Windows.Forms.Control)sender).FindForm().Close();
        }
    }
}
