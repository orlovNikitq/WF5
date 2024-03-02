namespace cww
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_prevew = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 464);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(39, 504);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(89, 45);
            this.bt_open.TabIndex = 1;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(203, 504);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(89, 45);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(352, 504);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(89, 45);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_prevew
            // 
            this.bt_prevew.Location = new System.Drawing.Point(490, 504);
            this.bt_prevew.Name = "bt_prevew";
            this.bt_prevew.Size = new System.Drawing.Size(89, 45);
            this.bt_prevew.TabIndex = 4;
            this.bt_prevew.Text = "Previous";
            this.bt_prevew.UseVisualStyleBackColor = true;
            this.bt_prevew.Click += new System.EventHandler(this.bt_prevew_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(616, 504);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(89, 45);
            this.bt_next.TabIndex = 5;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sky.jpg");
            this.imageList1.Images.SetKeyName(1, "n.png");
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "q.png");
            this.imageList1.Images.SetKeyName(4, "2024-02-27_21-07-36.png");
            this.imageList1.Images.SetKeyName(5, "2024-02-29_18-46-37.png");
            this.imageList1.Images.SetKeyName(6, "2024-02-29_18-47-01.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_prevew);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_prevew;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

