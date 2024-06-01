namespace graphLibrary
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
            this.Line_btn = new System.Windows.Forms.Button();
            this.Triangle_btn = new System.Windows.Forms.Button();
            this.Rectangle_btn = new System.Windows.Forms.Button();
            this.Circle_btn = new System.Windows.Forms.Button();
            this.dX_textBox = new System.Windows.Forms.TextBox();
            this.dY_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Line_mov_btn = new System.Windows.Forms.Button();
            this.Triangle_mov_btn = new System.Windows.Forms.Button();
            this.Rect_mov_btn = new System.Windows.Forms.Button();
            this.Circle_mov_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deg_textBox = new System.Windows.Forms.TextBox();
            this.Line_rot_btn = new System.Windows.Forms.Button();
            this.Triangle_rot_btn = new System.Windows.Forms.Button();
            this.Rect_rot_btn = new System.Windows.Forms.Button();
            this.Circle_rot_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Line_btn
            // 
            this.Line_btn.Location = new System.Drawing.Point(660, 71);
            this.Line_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Line_btn.Name = "Line_btn";
            this.Line_btn.Size = new System.Drawing.Size(100, 28);
            this.Line_btn.TabIndex = 0;
            this.Line_btn.Text = "Line";
            this.Line_btn.UseVisualStyleBackColor = true;
            this.Line_btn.Click += new System.EventHandler(this.Line_btn_Click);
            // 
            // Triangle_btn
            // 
            this.Triangle_btn.Location = new System.Drawing.Point(660, 126);
            this.Triangle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle_btn.Name = "Triangle_btn";
            this.Triangle_btn.Size = new System.Drawing.Size(100, 28);
            this.Triangle_btn.TabIndex = 1;
            this.Triangle_btn.Text = "Triangle";
            this.Triangle_btn.UseVisualStyleBackColor = true;
            this.Triangle_btn.Click += new System.EventHandler(this.Triangle_btn_Click);
            // 
            // Rectangle_btn
            // 
            this.Rectangle_btn.Location = new System.Drawing.Point(660, 182);
            this.Rectangle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Rectangle_btn.Name = "Rectangle_btn";
            this.Rectangle_btn.Size = new System.Drawing.Size(100, 28);
            this.Rectangle_btn.TabIndex = 2;
            this.Rectangle_btn.Text = "Rectangle";
            this.Rectangle_btn.UseVisualStyleBackColor = true;
            this.Rectangle_btn.Click += new System.EventHandler(this.Rectangle_btn_Click);
            // 
            // Circle_btn
            // 
            this.Circle_btn.Location = new System.Drawing.Point(660, 238);
            this.Circle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Circle_btn.Name = "Circle_btn";
            this.Circle_btn.Size = new System.Drawing.Size(100, 28);
            this.Circle_btn.TabIndex = 3;
            this.Circle_btn.Text = "Circle";
            this.Circle_btn.UseVisualStyleBackColor = true;
            this.Circle_btn.Click += new System.EventHandler(this.Circle_btn_Click);
            // 
            // dX_textBox
            // 
            this.dX_textBox.Location = new System.Drawing.Point(805, 27);
            this.dX_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.dX_textBox.Name = "dX_textBox";
            this.dX_textBox.Size = new System.Drawing.Size(55, 22);
            this.dX_textBox.TabIndex = 4;
            // 
            // dY_textBox
            // 
            this.dY_textBox.Location = new System.Drawing.Point(911, 27);
            this.dY_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.dY_textBox.Name = "dY_textBox";
            this.dY_textBox.Size = new System.Drawing.Size(55, 22);
            this.dY_textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "dX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "dY";
            // 
            // Line_mov_btn
            // 
            this.Line_mov_btn.Location = new System.Drawing.Point(803, 71);
            this.Line_mov_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Line_mov_btn.Name = "Line_mov_btn";
            this.Line_mov_btn.Size = new System.Drawing.Size(100, 28);
            this.Line_mov_btn.TabIndex = 8;
            this.Line_mov_btn.Text = "Move";
            this.Line_mov_btn.UseVisualStyleBackColor = true;
            this.Line_mov_btn.Click += new System.EventHandler(this.Line_mov_btn_Click);
            // 
            // Triangle_mov_btn
            // 
            this.Triangle_mov_btn.Location = new System.Drawing.Point(803, 126);
            this.Triangle_mov_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle_mov_btn.Name = "Triangle_mov_btn";
            this.Triangle_mov_btn.Size = new System.Drawing.Size(100, 28);
            this.Triangle_mov_btn.TabIndex = 9;
            this.Triangle_mov_btn.Text = "Move";
            this.Triangle_mov_btn.UseVisualStyleBackColor = true;
            this.Triangle_mov_btn.Click += new System.EventHandler(this.Triangle_mov_btn_Click);
            // 
            // Rect_mov_btn
            // 
            this.Rect_mov_btn.Location = new System.Drawing.Point(803, 182);
            this.Rect_mov_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Rect_mov_btn.Name = "Rect_mov_btn";
            this.Rect_mov_btn.Size = new System.Drawing.Size(100, 28);
            this.Rect_mov_btn.TabIndex = 10;
            this.Rect_mov_btn.Text = "Move";
            this.Rect_mov_btn.UseVisualStyleBackColor = true;
            this.Rect_mov_btn.Click += new System.EventHandler(this.Rect_mov_btn_Click);
            // 
            // Circle_mov_btn
            // 
            this.Circle_mov_btn.Location = new System.Drawing.Point(803, 238);
            this.Circle_mov_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Circle_mov_btn.Name = "Circle_mov_btn";
            this.Circle_mov_btn.Size = new System.Drawing.Size(100, 28);
            this.Circle_mov_btn.TabIndex = 11;
            this.Circle_mov_btn.Text = "Move";
            this.Circle_mov_btn.UseVisualStyleBackColor = true;
            this.Circle_mov_btn.Click += new System.EventHandler(this.Circle_mov_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1008, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "deg";
            // 
            // deg_textBox
            // 
            this.deg_textBox.Location = new System.Drawing.Point(995, 27);
            this.deg_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.deg_textBox.Name = "deg_textBox";
            this.deg_textBox.Size = new System.Drawing.Size(55, 22);
            this.deg_textBox.TabIndex = 13;
            // 
            // Line_rot_btn
            // 
            this.Line_rot_btn.Location = new System.Drawing.Point(932, 71);
            this.Line_rot_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Line_rot_btn.Name = "Line_rot_btn";
            this.Line_rot_btn.Size = new System.Drawing.Size(100, 28);
            this.Line_rot_btn.TabIndex = 14;
            this.Line_rot_btn.Text = "Rotate";
            this.Line_rot_btn.UseVisualStyleBackColor = true;
            this.Line_rot_btn.Click += new System.EventHandler(this.Line_rot_btn_Click);
            // 
            // Triangle_rot_btn
            // 
            this.Triangle_rot_btn.Location = new System.Drawing.Point(932, 126);
            this.Triangle_rot_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle_rot_btn.Name = "Triangle_rot_btn";
            this.Triangle_rot_btn.Size = new System.Drawing.Size(100, 28);
            this.Triangle_rot_btn.TabIndex = 15;
            this.Triangle_rot_btn.Text = "Rotate";
            this.Triangle_rot_btn.UseVisualStyleBackColor = true;
            this.Triangle_rot_btn.Click += new System.EventHandler(this.Triangle_rot_btn_Click);
            // 
            // Rect_rot_btn
            // 
            this.Rect_rot_btn.Location = new System.Drawing.Point(932, 182);
            this.Rect_rot_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Rect_rot_btn.Name = "Rect_rot_btn";
            this.Rect_rot_btn.Size = new System.Drawing.Size(100, 28);
            this.Rect_rot_btn.TabIndex = 16;
            this.Rect_rot_btn.Text = "Rotate";
            this.Rect_rot_btn.UseVisualStyleBackColor = true;
            this.Rect_rot_btn.Click += new System.EventHandler(this.Rect_rot_btn_Click);
            // 
            // Circle_rot_btn
            // 
            this.Circle_rot_btn.Location = new System.Drawing.Point(932, 238);
            this.Circle_rot_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Circle_rot_btn.Name = "Circle_rot_btn";
            this.Circle_rot_btn.Size = new System.Drawing.Size(100, 28);
            this.Circle_rot_btn.TabIndex = 17;
            this.Circle_rot_btn.Text = "Rotate";
            this.Circle_rot_btn.UseVisualStyleBackColor = true;
            this.Circle_rot_btn.Click += new System.EventHandler(this.Circle_rot_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 342);
            this.Controls.Add(this.Circle_rot_btn);
            this.Controls.Add(this.Rect_rot_btn);
            this.Controls.Add(this.Triangle_rot_btn);
            this.Controls.Add(this.Line_rot_btn);
            this.Controls.Add(this.deg_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Circle_mov_btn);
            this.Controls.Add(this.Rect_mov_btn);
            this.Controls.Add(this.Triangle_mov_btn);
            this.Controls.Add(this.Line_mov_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dY_textBox);
            this.Controls.Add(this.dX_textBox);
            this.Controls.Add(this.Circle_btn);
            this.Controls.Add(this.Rectangle_btn);
            this.Controls.Add(this.Triangle_btn);
            this.Controls.Add(this.Line_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Line_btn;
        private System.Windows.Forms.Button Triangle_btn;
        private System.Windows.Forms.Button Rectangle_btn;
        private System.Windows.Forms.Button Circle_btn;
        private System.Windows.Forms.TextBox dX_textBox;
        private System.Windows.Forms.TextBox dY_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Line_mov_btn;
        private System.Windows.Forms.Button Triangle_mov_btn;
        private System.Windows.Forms.Button Rect_mov_btn;
        private System.Windows.Forms.Button Circle_mov_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deg_textBox;
        private System.Windows.Forms.Button Line_rot_btn;
        private System.Windows.Forms.Button Triangle_rot_btn;
        private System.Windows.Forms.Button Rect_rot_btn;
        private System.Windows.Forms.Button Circle_rot_btn;
    }
}

