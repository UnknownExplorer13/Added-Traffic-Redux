using System;
using System.Windows.Forms;

namespace Added_Traffic_Redux_Settings.Forms
{
	public partial class frmList : Form
	{
		public ListViewItem ListViewItem { get; set; }
		public string Model { get; set; }
		public string Category { get; set; }
		public bool IsEdit { get; set; }

		public frmList()
		{
			base.Load += frmList_Load;
			InitializeComponent();
		}

		private void frmList_Load(object sender, EventArgs e)
		{
			if (IsEdit)
			{
				cmbCategory.Text = Category;
				txtNewVeh.Text = Model;
				btnAction.Text = "Edit";
			}
			else
			{
				cmbCategory.SelectedIndex = 0;
			}
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			if (IsEdit)
			{
				ListViewItem.SubItems[1].Text = txtNewVeh.Text;
				ListViewItem.Group = frmSettings.lvModelList.Groups[cmbCategory.Text];
			}
			else
			{
				var newLVI = new ListViewItem("");
				newLVI.SubItems.Add(txtNewVeh.Text);
				newLVI.Group = frmSettings.lvModelList.Groups[cmbCategory.Text];
				frmSettings.lvModelList.Items.Add(newLVI);
				frmSettings.lvModelList.Striped();
			}

			frmSettings.lvModelList.Striped();
			frmSettings.lvModelList.AddGroupFooter();
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}