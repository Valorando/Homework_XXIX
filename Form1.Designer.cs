namespace Homework_06_10
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Домашние задания");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Быстрый доступ", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("One Drive - Presonal");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Видео");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Документы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Загрузки");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Изображения");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Музыка");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Объемные объекты");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Рабочий стол");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Локальный диск (C:)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Локальный диск (D:)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Этот компьютер", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("DESKTOP - 23QFNP4");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Сеть", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 12;
            treeNode1.Name = "Узел17";
            treeNode1.Text = "Домашние задания";
            treeNode2.ImageIndex = 10;
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Быстрый доступ";
            treeNode3.ImageIndex = 9;
            treeNode3.Name = "Узел1";
            treeNode3.Text = "One Drive - Presonal";
            treeNode4.ImageIndex = 7;
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Видео";
            treeNode5.ImageIndex = 6;
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Документы";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "Узел6";
            treeNode6.Text = "Загрузки";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "Узел7";
            treeNode7.Text = "Изображения";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "Узел8";
            treeNode8.Text = "Музыка";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "Узел9";
            treeNode9.Text = "Объемные объекты";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Узел10";
            treeNode10.Text = "Рабочий стол";
            treeNode11.Name = "Узел11";
            treeNode11.Text = "Локальный диск (C:)";
            treeNode12.Name = "Узел12";
            treeNode12.Text = "Локальный диск (D:)";
            treeNode13.ImageIndex = 8;
            treeNode13.Name = "Узел2";
            treeNode13.Text = "Этот компьютер";
            treeNode14.ImageIndex = 8;
            treeNode14.Name = "Узел15";
            treeNode14.Text = "DESKTOP - 23QFNP4";
            treeNode15.ImageIndex = 11;
            treeNode15.Name = "Узел3";
            treeNode15.Text = "Сеть";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode13,
            treeNode15});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(255, 496);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-жесткий-диск-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-рабочий-стол-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-вид-слева-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-музыка-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-изображение-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-загрузки-48.png");
            this.imageList1.Images.SetKeyName(6, "icons8-документы-48.png");
            this.imageList1.Images.SetKeyName(7, "icons8-видео-48.png");
            this.imageList1.Images.SetKeyName(8, "icons8-этот-компьютер-48.png");
            this.imageList1.Images.SetKeyName(9, "icons8-загрузить-в-облако-48.png");
            this.imageList1.Images.SetKeyName(10, "icons8-звезда-48.png");
            this.imageList1.Images.SetKeyName(11, "icons8-бизнес-сеть-48.png");
            this.imageList1.Images.SetKeyName(12, "icons8-папка-48.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 496);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(271, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(271, 535);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}