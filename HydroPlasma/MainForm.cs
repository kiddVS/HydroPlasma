using HydroPlasma.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydroPlasma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
        private void MainForm_Show(object sender, EventArgs e)
        { treeView1.SelectedNode = null; }
        private void MainForm_Load(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;

        }
        private void treeView1_NodeMouseClick(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "液相放电峰值压力计算":
                    TopPressureCalcForm form = new TopPressureCalcForm();
                    form.Show();
                    break;
                case "冲击波衰减特性计算":
                    PressureFallForm form1 = new PressureFallForm();
                    form1.Show();
                    break;
            }
        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown)
                e.Cancel = true;
        }
        private void treeView1_VisibleChanged(object sender, EventArgs e)
        {
            if (treeView1.Visible)
            {
                treeView1.SelectedNode = null;
            }
        }
        private void treeView1_DoubleClick(object sender, TreeViewCancelEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "液相放电峰值压力计算":
                    TopPressureCalcForm form = new TopPressureCalcForm();
                    form.TopMost = true;
                    form.Show();
                    break;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "液相放电峰值压力计算":
                    TopPressureCalcForm form = new TopPressureCalcForm();
                    form.TopMost = true;
                    form.Show();
                    break;
                case "冲击波衰减特性计算":
                    PressureFallForm form1 = new PressureFallForm();
                    form1.TopMost = true;
                    form1.Show();
                    break;
                case "液相放电与水下炸药转换":
                    Plasam2Explosive form2 = new Plasam2Explosive();
                    form2.TopMost = true;
                    form2.Show();
                    break;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("液相放电等离子冲击波传播规律计算软件 v1");
        }

        private void 液相放电峰值压力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopPressureCalcForm form = new TopPressureCalcForm();
            form.TopMost = true;
            form.Show();
        }

        private void 冲击波衰减特性计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PressureFallForm form1 = new PressureFallForm();
            form1.TopMost = true;
            form1.Show();
        }
    }
}
