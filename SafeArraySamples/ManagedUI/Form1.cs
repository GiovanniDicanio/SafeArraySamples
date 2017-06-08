using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ManagedUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("NativeDll.dll", PreserveSig = false)]
        public static extern void ProduceSafeArrayOfBytes(
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)]
            out byte[] result
        );

        [DllImport("NativeDll.dll", PreserveSig = false)]
        public static extern void ProduceSafeArrayOfStrings(
            [Out, MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
            out string[] result
        );

        private void buttonTestByteSA_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("Getting byte safe array from native DLL:");

            byte[] data;
            ProduceSafeArrayOfBytes(out data);

            foreach (var x in data)
            {
                listBoxOutput.Items.Add(x);
            }
        }

        private void buttonTestStringSA_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add("Getting string safe array from native DLL:");

            string[] data;
            ProduceSafeArrayOfStrings(out data);

            foreach (var x in data)
            {
                listBoxOutput.Items.Add(x);
            }
        }

        private void linkLabelBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var link = new LinkLabel.Link();
            link.LinkData = "http://msmvps.com/gdicanio";
            linkLabelBlog.Links.Add(link);
        }
    }
}
