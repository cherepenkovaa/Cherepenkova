namespace practica5
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ОЖИВИТЬ = new System.Windows.Forms.Button();
            this.СТЕРЕТЬ = new System.Windows.Forms.Button();
            this.НАРИСОВАТЬ = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ОЖИВИТЬ);
            this.splitContainer1.Panel2.Controls.Add(this.СТЕРЕТЬ);
            this.splitContainer1.Panel2.Controls.Add(this.НАРИСОВАТЬ);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // ОЖИВИТЬ
            // 
            this.ОЖИВИТЬ.Location = new System.Drawing.Point(413, 39);
            this.ОЖИВИТЬ.Name = "ОЖИВИТЬ";
            this.ОЖИВИТЬ.Size = new System.Drawing.Size(118, 59);
            this.ОЖИВИТЬ.TabIndex = 2;
            this.ОЖИВИТЬ.Text = "ОЖИВИТЬ";
            this.ОЖИВИТЬ.UseVisualStyleBackColor = true;
            this.ОЖИВИТЬ.Click += new System.EventHandler(this.ОЖИВИТЬ_Click);
            // 
            // СТЕРЕТЬ
            // 
            this.СТЕРЕТЬ.Location = new System.Drawing.Point(172, 80);
            this.СТЕРЕТЬ.Name = "СТЕРЕТЬ";
            this.СТЕРЕТЬ.Size = new System.Drawing.Size(139, 44);
            this.СТЕРЕТЬ.TabIndex = 1;
            this.СТЕРЕТЬ.Text = "СТЕРЕТЬ";
            this.СТЕРЕТЬ.UseVisualStyleBackColor = true;
            this.СТЕРЕТЬ.Click += new System.EventHandler(this.СТЕРЕТЬ_Click);
            // 
            // НАРИСОВАТЬ
            // 
            this.НАРИСОВАТЬ.Location = new System.Drawing.Point(172, 24);
            this.НАРИСОВАТЬ.Name = "НАРИСОВАТЬ";
            this.НАРИСОВАТЬ.Size = new System.Drawing.Size(139, 42);
            this.НАРИСОВАТЬ.TabIndex = 0;
            this.НАРИСОВАТЬ.Text = "НАРИСОВАТЬ";
            this.НАРИСОВАТЬ.UseVisualStyleBackColor = true;
            this.НАРИСОВАТЬ.Click += new System.EventHandler(this.НАРИСОВАТЬ_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ОЖИВИТЬ;
        private System.Windows.Forms.Button СТЕРЕТЬ;
        private System.Windows.Forms.Button НАРИСОВАТЬ;
        private System.Windows.Forms.Timer timer1;
    }
}

