namespace cww
{
    partial class Form4
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Внутренний узел 0");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Внутренний узел 1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Корневой узел 0", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Внутренний узел 0");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Корневой узел 1", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(29, 22);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "Внутренний узел 0";
            treeNode6.Text = "Внутренний узел 0";
            treeNode7.Name = "Внутренний узел 1";
            treeNode7.Text = "Внутренний узел 1";
            treeNode8.Name = "Корневой узел 0";
            treeNode8.Text = "Корневой узел 0";
            treeNode9.Name = "Внутренний узел 0";
            treeNode9.Text = "Внутренний узел 0";
            treeNode10.Name = "Корневой узел 1";
            treeNode10.Text = "Корневой узел 1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(406, 186);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}