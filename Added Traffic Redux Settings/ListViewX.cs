using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Added_Traffic_Redux_Settings
{
	public class ListViewX : ListView
	{
		private const int LVM_FIRST = 0x1000;
		private const int LVM_SETGROUPINFO = LVM_FIRST + 147;
		private const int WM_LBUTTONUP = 0x202;
		private delegate void CallbackSetGroupState(ListViewGroup lstvwgrp, ListViewGroupState state);
		private delegate void CallbackSetGroupString(ListViewGroup lstvwgrp, string value);

		[DllImport("User32.dll"), Description(@"Sends the specified message to a window or windows.
		The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
		To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.
		To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, ref LVGROUP lParam); // Passing lParam as ref otherwise it crashes (https://www.codeproject.com/Articles/36775/Collapsible-ListViewGroup?msg=4255597#xx4255597xx)

		private static int? GetGroupID(ListViewGroup lstvwgrp)
		{
			int? rtnval = default;
			Type GrpTp = lstvwgrp.GetType();

			if (GrpTp != null)
			{
				PropertyInfo pi = GrpTp.GetProperty("ID", BindingFlags.NonPublic | BindingFlags.Instance);

				if (pi != null)
				{
					object tmprtnval = pi.GetValue(lstvwgrp, default);

					if (tmprtnval != null) rtnval = tmprtnval as int?;
				}
			}

			return rtnval;
		}

		private static void setGrpState(ListViewGroup lstvwgrp, ListViewGroupState state)
		{
			if (Environment.OSVersion.Version.Major < 6) return;
			if (lstvwgrp == null || lstvwgrp.ListView == null) return;

			if (lstvwgrp.ListView.InvokeRequired)
			{
				lstvwgrp.ListView.Invoke(new CallbackSetGroupState(setGrpState), lstvwgrp, state);
			}
			else
			{
				int? GrpId = GetGroupID(lstvwgrp);
				int gIndex = lstvwgrp.ListView.Groups.IndexOf(lstvwgrp);
				LVGROUP group = new LVGROUP();
				group.CbSize = Marshal.SizeOf(group);
				group.State = state;
				group.Mask = ListViewGroupMask.State;

				if (GrpId != null)
				{
					group.IGroupId = GrpId.Value;
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, GrpId.Value, ref group);
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, GrpId.Value, ref group);
				}
				else
				{
					group.IGroupId = gIndex;
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, gIndex, ref group);
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, gIndex, ref group);
				}

				lstvwgrp.ListView.Refresh();
			}
		}

		private static void setGrpFooter(ListViewGroup lstvwgrp, string footer)
		{
			if (Environment.OSVersion.Version.Major < 6) return;
			if (lstvwgrp == null || lstvwgrp.ListView == null) return;

			if (lstvwgrp.ListView.InvokeRequired)  lstvwgrp.ListView.Invoke(new CallbackSetGroupString(setGrpFooter), lstvwgrp, footer);
			else
			{
				int? GrpId = GetGroupID(lstvwgrp);
				int gIndex = lstvwgrp.ListView.Groups.IndexOf(lstvwgrp);
				LVGROUP group = new LVGROUP();
				group.CbSize = Marshal.SizeOf(group);
				group.PszFooter = footer;
				group.Mask = ListViewGroupMask.Footer;

				if (GrpId != null)
				{
					group.IGroupId = GrpId.Value;
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, GrpId.Value, ref group);
				}
				else
				{
					group.IGroupId = gIndex;
					SendMessage(lstvwgrp.ListView.Handle, LVM_SETGROUPINFO, gIndex, ref group);
				}
			}
		}

		public void SetGroupState(ListViewGroupState state)
		{
			foreach (ListViewGroup lvg in this.Groups) setGrpState(lvg, state);
		}

		public void SetGroupFooter(ListViewGroup lvg, string footerText)
		{
			setGrpFooter(lvg, footerText);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_LBUTTONUP) base.DefWndProc(ref m);
			base.WndProc(ref m);
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		[Description("LVGROUP structure. Used to set and retrieve groups.")]
		public partial struct LVGROUP
		{
			[Description("Size of this structure, in bytes.")]
			public int CbSize;
			[Description("Mask that specifies which members of the structure are valid input. One or more of the following values:LVGF_NONE No other items are valid.")]
			public ListViewGroupMask Mask;
			[Description("Pointer to a null-terminated string that contains the header text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the header text.")]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string PszHeader;
			[Description("Size in TCHARs of the buffer pointed to by the pszHeader member. If the structure is not receiving information about a group, this member is ignored.")]
			public int CchHeader;
			[Description("Pointer to a null-terminated string that contains the footer text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the footer text.")]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string PszFooter;
			[Description("Size in TCHARs of the buffer pointed to by the pszFooter member. If the structure is not receiving information about a group, this member is ignored.")]
			public int CchFooter;
			[Description("ID of the group.")]
			public int IGroupId;
			[Description("Mask used with LVM_GETGROUPINFO (Microsoft Windows XP and Windows Vista) and LVM_SETGROUPINFO (Windows Vista only) to specify which flags in the state value are being retrieved or set.")]
			public int StateMask;
			[Description("Flag that can have one of the following values:LVGS_NORMAL Groups are expanded, the group name is displayed, and all items in the group are displayed.")]
			public ListViewGroupState State;
			[Description("Indicates the alignment of the header or footer text for the group. It can have one or more of the following values. Use one of the header flags. Footer flags are optional. Windows XP: Footer flags are reserved.LVGA_FOOTER_CENTERReserved.")]
			public uint UAlign;
			[Description("Windows Vista. Pointer to a null-terminated string that contains the subtitle text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the subtitle text. This element is drawn under the header text.")]
			public IntPtr PszSubtitle;
			[Description("Windows Vista. Size, in TCHARs, of the buffer pointed to by the pszSubtitle member. If the structure is not receiving information about a group, this member is ignored.")]
			public uint CchSubtitle;
			[Description("Windows Vista. Pointer to a null-terminated string that contains the text for a task link when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the task text. This item is drawn right-aligned opposite the header text. When clicked by the user, the task link generates an LVN_LINKCLICK notification.")]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string PszTask;
			[Description("Windows Vista. Size in TCHARs of the buffer pointed to by the pszTask member. If the structure is not receiving information about a group, this member is ignored.")]
			public uint CchTask;
			[Description("Windows Vista. Pointer to a null-terminated string that contains the top description text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the top description text. This item is drawn opposite the title image when there is a title image, no extended image, and uAlign==LVGA_HEADER_CENTER.")]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string PszDescriptionTop;
			[Description("Windows Vista. Size in TCHARs of the buffer pointed to by the pszDescriptionTop member. If the structure is not receiving information about a group, this member is ignored.")]
			public uint CchDescriptionTop;
			[Description("Windows Vista. Pointer to a null-terminated string that contains the bottom description text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the bottom description text. This item is drawn under the top description text when there is a title image, no extended image, and uAlign==LVGA_HEADER_CENTER.")]
			[MarshalAs(UnmanagedType.LPWStr)]
			public string PszDescriptionBottom;
			[Description("Windows Vista. Size in TCHARs of the buffer pointed to by the pszDescriptionBottom member. If the structure is not receiving information about a group, this member is ignored.")]
			public uint CchDescriptionBottom;
			[Description("Windows Vista. Index of the title image in the control imagelist.")]
			public int ITitleImage;
			[Description("Windows Vista. Index of the extended image in the control imagelist.")]
			public int IExtendedImage;
			[Description("Windows Vista. Read-only.")]
			public int IFirstItem;
			[Description("Windows Vista. Read-only in non-owner data mode.")]
			public IntPtr CItems;
			[Description("Windows Vista. NULL if group is not a subset. Pointer to a null-terminated string that contains the subset title text when item information is being set. If group information is being retrieved, this member specifies the address of the buffer that receives the subset title text.")]
			public IntPtr PszSubsetTitle;
			[Description("Windows Vista. Size in TCHARs of the buffer pointed to by the pszSubsetTitle member. If the structure is not receiving information about a group, this member is ignored.")]
			public IntPtr CchSubsetTitle;
		}

		public enum ListViewGroupMask
		{
			None = 0x0,
			Header = 0x1,
			Footer = 0x2,
			State = 0x4,
			Align = 0x8,
			GroupId = 0x10,
			SubTitle = 0x100,
			Task = 0x200,
			DescriptionTop = 0x400,
			DescriptionBottom = 0x800,
			TitleImage = 0x1000,
			ExtendedImage = 0x2000,
			Items = 0x4000,
			Subset = 0x8000,
			SubsetItems = 0x10000
		}

		public enum ListViewGroupState
		{
			Normal = 0,
			Collapsed = 1,
			Hidden = 2,
			NoHeader = 4,
			Collapsible = 8,
			Focused = 16,
			Selected = 32,
			SubSeted = 64,
			SubSetLinkFocused = 128
		}
	}
}