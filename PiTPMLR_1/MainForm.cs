using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiTPMLR_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_massEnter.Clear();
            tb_massOut.Clear();
        }

        private void btn_sortShell_Click(object sender, EventArgs e)
        {
            int[] arr = tb_massEnter.Text.Split(' ').Select(int.Parse).ToArray();
            bool ascending = rb_Asc.Checked;
            Algoritms.ShellSort(arr, ascending);
            string output = string.Join(" ", arr);
            tb_massOut.Text = output;
        }

        private void btn_sortSwap_Click(object sender, EventArgs e)
        {
            int[] arr = tb_massEnter.Text.Split(' ').Select(int.Parse).ToArray();
            bool ascending = rb_Asc.Checked;
            Algoritms.SwapSort(arr, ascending);
            string output = string.Join(" ", arr);
            tb_massOut.Text = output;
        }

        private void btn_sortSelect_Click(object sender, EventArgs e)
        {
            int[] arr = tb_massEnter.Text.Split(' ').Select(int.Parse).ToArray();
            bool ascending = rb_Asc.Checked;
            Algoritms.SelectSort(arr, ascending);
            string output = string.Join(" ", arr);
            tb_massOut.Text = output;
        }
        private void tb_massEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
