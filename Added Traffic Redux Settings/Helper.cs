using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Added_Traffic_Redux_Settings
{
	internal static class Helper
	{
		public static void Striped(this ListView listview, Color color1 = default, Color color2 = default)
		{
			if (color2 == default) color2 = SystemColors.ButtonFace;
			if (color1 == default) color1 = SystemColors.Window;

			int alternator = 0;
			foreach (ListViewItem lvi in listview.Items)
			{
				if (lvi.Group is null)
				{
					if (alternator % 2 == 0)
					{
						for (int i = 0, loopTo = lvi.SubItems.Count - 1; i <= loopTo; i++)
						{
							if (!(lvi.SubItems[i].BackColor == Color.LightSalmon)) lvi.SubItems[i].BackColor = color1;
						}
					}
					else
					{
						for (int i = 0, loopTo1 = lvi.SubItems.Count - 1; i <= loopTo1; i++)
						{
							if (!(lvi.SubItems[i].BackColor == Color.LightSalmon)) lvi.SubItems[i].BackColor = color2;
						}
					}

					alternator += 1;
				}
			}
			foreach (ListViewGroup gp in listview.Groups)
			{
				foreach (ListViewItem lvi in gp.Items)
				{
					if (alternator % 2 == 0)
					{
						for (int i = 0, loopTo2 = lvi.SubItems.Count - 1; i <= loopTo2; i++)
						{
							if (!(lvi.SubItems[i].BackColor == Color.LightSalmon)) lvi.SubItems[i].BackColor = color1;
						}
					}
					else
					{
						for (int i = 0, loopTo3 = lvi.SubItems.Count - 1; i <= loopTo3; i++)
						{
							if (!(lvi.SubItems[i].BackColor == Color.LightSalmon)) lvi.SubItems[i].BackColor = color2;
						}
					}

					alternator += 1;
				}
			}
		}

		public static void AddGroupFooter(this ListViewX listviewx)
		{
			foreach (ListViewGroup lvg in listviewx.Groups)
			{
				listviewx.SetGroupFooter(lvg, $"Contains {lvg.Items.Count} models.");
			}
			listviewx.SetGroupState(ListViewX.ListViewGroupState.Collapsible | ListViewX.ListViewGroupState.Collapsed);
		}
	}
}