namespace WindowsFormsApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C# .Net");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PHP");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Java");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Yazılım", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sql Server");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("MySql");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Oracle");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PostgreSql");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Veritabanı", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(260, 93);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "C# .Net";
            treeNode2.Name = "Node2";
            treeNode2.Text = "PHP";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Java";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Yazılım";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Sql Server";
            treeNode6.Name = "Node6";
            treeNode6.Text = "MySql";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Oracle";
            treeNode8.Name = "Node8";
            treeNode8.Text = "PostgreSql";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Veritabanı";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(228, 184);
            this.treeView1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}