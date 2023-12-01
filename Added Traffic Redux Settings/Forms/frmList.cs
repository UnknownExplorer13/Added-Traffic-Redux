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

		private frmSettings mainForm = null;
		public frmList(Form callingForm)
		{
			mainForm = callingForm as frmSettings;
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
				if (txtNewVeh.Text.Length == 0) MessageBox.Show("Model cannot be blank.", "Error", default, MessageBoxIcon.Error);
				else
				{
					ListViewItem.SubItems[1].Text = txtNewVeh.Text;
					ListViewItem.Group = this.mainForm.lvModelList.Groups[cmbCategory.Text];
					this.mainForm.lvModelList.Striped();
					this.mainForm.lvModelList.AddGroupFooter();
					Close();
				}
			}
			else
			{
				if (txtNewVeh.Text.Length == 0) MessageBox.Show("Model cannot be blank.", "Error", default, MessageBoxIcon.Error);
				else
				{
					var newLVI = new ListViewItem("");
					newLVI.SubItems.Add(txtNewVeh.Text);
					newLVI.Group = this.mainForm.lvModelList.Groups[cmbCategory.Text];
					this.mainForm.lvModelList.Items.Add(newLVI);
					this.mainForm.lvModelList.Striped();
					this.mainForm.lvModelList.AddGroupFooter();
					Close();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}