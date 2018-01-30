using HydroPlasma.Forms;

namespace HydroPlasma
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("液相放电与水下炸药转换");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("液相放电峰值压力计算");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("冲击波衰减特性计算");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.液相放电峰值压力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.冲击波衰减特性计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.计算ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.液相放电峰值压力ToolStripMenuItem,
            this.冲击波衰减特性计算ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.计算ToolStripMenuItem.Text = "计算";
            // 
            // 液相放电峰值压力ToolStripMenuItem
            // 
            this.液相放电峰值压力ToolStripMenuItem.Name = "液相放电峰值压力ToolStripMenuItem";
            this.液相放电峰值压力ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.液相放电峰值压力ToolStripMenuItem.Text = "液相放电峰值压力";
            this.液相放电峰值压力ToolStripMenuItem.Click += new System.EventHandler(this.液相放电峰值压力ToolStripMenuItem_Click);
            // 
            // 冲击波衰减特性计算ToolStripMenuItem
            // 
            this.冲击波衰减特性计算ToolStripMenuItem.Name = "冲击波衰减特性计算ToolStripMenuItem";
            this.冲击波衰减特性计算ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.冲击波衰减特性计算ToolStripMenuItem.Text = "冲击波衰减特性计算";
            this.冲击波衰减特性计算ToolStripMenuItem.Click += new System.EventHandler(this.冲击波衰减特性计算ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "关于";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.NodeFont = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode1.Text = "液相放电与水下炸药转换";
            treeNode2.Name = "节点0";
            treeNode2.NodeFont = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode2.Text = "液相放电峰值压力计算";
            treeNode3.Name = "节点1";
            treeNode3.NodeFont = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode3.Text = "冲击波衰减特性计算";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(278, 768);
            this.treeView1.TabIndex = 2;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::HydroPlasma.Properties.Resources._4d80482282bc2766d88491fafe590626__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(296, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 768);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "液相放电等离子体冲击波传播计算软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TreeView1_NodeMouseDoubleClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            // throw new System.NotImplementedException();
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
            }
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 液相放电峰值压力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 冲击波衰减特性计算ToolStripMenuItem;
    }
}

