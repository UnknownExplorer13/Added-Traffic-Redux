using System;
using System.Windows.Forms;

namespace Added_Traffic_Redux_Settings.Forms
{
	public partial class frmSwap : Form
	{
		public ListViewItem ListViewItem { get; set; }
		public VehicleSwap vehSwap { get; set; }
		public bool IsEdit { get; set; }

		public frmSwap()
		{
			base.Load += frmSwap_Load;
			InitializeComponent();
		}

		private frmSettings mainForm = null;
		public frmSwap(Form callingForm)
		{
			mainForm = callingForm as frmSettings;
			base.Load += frmSwap_Load;
			InitializeComponent();
		}

		private void frmSwap_Load(object sender, EventArgs e)
		{
			if (IsEdit)
			{
				txtOldVeh.Text = vehSwap.OldVehicle;
				txtNewVeh.Text = vehSwap.NewVehicle;
				cbEnable.Checked = vehSwap.Enable;
				btnAction.Text = "Edit";
			}
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			if (IsEdit)
			{
				if (txtOldVeh.Text.Length == 0) MessageBox.Show("Old Model cannot be blank.", "Error", default, MessageBoxIcon.Error);
				else
				{
					ListViewItem.Tag = new VehicleSwap(txtOldVeh.Text, txtNewVeh.Text, vehSwap.Enable);
					ListViewItem.SubItems[1].Text = txtOldVeh.Text;
					ListViewItem.SubItems[2].Text = txtNewVeh.Text;
					ListViewItem.Checked = cbEnable.Checked;
					Close();
				}
			}
			else
			{
				if (txtOldVeh.Text.Length == 0) MessageBox.Show("Old Model cannot be blank.", "Error", default, MessageBoxIcon.Error);
				else
				{
					var newLVI = new ListViewItem("");
					newLVI.SubItems.Add(txtOldVeh.Text);
					newLVI.SubItems.Add(txtNewVeh.Text);
					newLVI.Checked = cbEnable.Checked;
					newLVI.Tag = txtNewVeh.Text.Length == 0 ? new VehicleSwap(txtOldVeh.Text, cbEnable.Checked) : new VehicleSwap(txtOldVeh.Text, txtNewVeh.Text, cbEnable.Checked);

					this.mainForm.lvVehicleSwap.Items.Add(newLVI);
					this.mainForm.lvVehicleSwap.Striped();
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