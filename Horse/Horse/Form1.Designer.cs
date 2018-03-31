namespace Horse
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
            this.Panel_Field = new System.Windows.Forms.FlowLayoutPanel();
            this.n_X = new System.Windows.Forms.NumericUpDown();
            this.n_Y = new System.Windows.Forms.NumericUpDown();
            this.btn_populateField = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.n_speed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Field
            // 
            this.Panel_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Field.Location = new System.Drawing.Point(12, 12);
            this.Panel_Field.Name = "Panel_Field";
            this.Panel_Field.Size = new System.Drawing.Size(500, 500);
            this.Panel_Field.TabIndex = 0;
            // 
            // n_X
            // 
            this.n_X.Location = new System.Drawing.Point(536, 12);
            this.n_X.Name = "n_X";
            this.n_X.Size = new System.Drawing.Size(44, 20);
            this.n_X.TabIndex = 1;
            // 
            // n_Y
            // 
            this.n_Y.Location = new System.Drawing.Point(610, 12);
            this.n_Y.Name = "n_Y";
            this.n_Y.Size = new System.Drawing.Size(44, 20);
            this.n_Y.TabIndex = 2;
            // 
            // btn_populateField
            // 
            this.btn_populateField.Location = new System.Drawing.Point(518, 38);
            this.btn_populateField.Name = "btn_populateField";
            this.btn_populateField.Size = new System.Drawing.Size(154, 23);
            this.btn_populateField.TabIndex = 3;
            this.btn_populateField.Text = "Создать поле";
            this.btn_populateField.UseVisualStyleBackColor = true;
            this.btn_populateField.Click += new System.EventHandler(this.btn_populateField_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Выбор расположения коня";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(518, 117);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(154, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Запуск";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // n_speed
            // 
            this.n_speed.Location = new System.Drawing.Point(519, 91);
            this.n_speed.Name = "n_speed";
            this.n_speed.Size = new System.Drawing.Size(61, 20);
            this.n_speed.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Скорость в мс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_speed);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_populateField);
            this.Controls.Add(this.n_Y);
            this.Controls.Add(this.n_X);
            this.Controls.Add(this.Panel_Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel_Field;
        private System.Windows.Forms.NumericUpDown n_X;
        private System.Windows.Forms.NumericUpDown n_Y;
        private System.Windows.Forms.Button btn_populateField;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown n_speed;
        private System.Windows.Forms.Label label1;
    }
}

