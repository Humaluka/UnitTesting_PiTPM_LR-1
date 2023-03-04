namespace PiTPMLR_1
{
    partial class MainForm
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
            this.btn_sortShell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_massEnter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_massOut = new System.Windows.Forms.TextBox();
            this.rb_Asc = new System.Windows.Forms.RadioButton();
            this.rb_Dec = new System.Windows.Forms.RadioButton();
            this.btn_sortSwap = new System.Windows.Forms.Button();
            this.btn_sortSelect = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sortShell
            // 
            this.btn_sortShell.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_sortShell.Location = new System.Drawing.Point(273, 82);
            this.btn_sortShell.Name = "btn_sortShell";
            this.btn_sortShell.Size = new System.Drawing.Size(158, 61);
            this.btn_sortShell.TabIndex = 0;
            this.btn_sortShell.Text = "Сортировка Шелла";
            this.btn_sortShell.UseVisualStyleBackColor = true;
            this.btn_sortShell.Click += new System.EventHandler(this.btn_sortShell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Массив";
            // 
            // tb_massEnter
            // 
            this.tb_massEnter.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_massEnter.Location = new System.Drawing.Point(17, 46);
            this.tb_massEnter.Name = "tb_massEnter";
            this.tb_massEnter.Size = new System.Drawing.Size(216, 33);
            this.tb_massEnter.TabIndex = 2;
            this.tb_massEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_massEnter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новый массив";
            // 
            // tb_massOut
            // 
            this.tb_massOut.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_massOut.Location = new System.Drawing.Point(17, 141);
            this.tb_massOut.Name = "tb_massOut";
            this.tb_massOut.ReadOnly = true;
            this.tb_massOut.Size = new System.Drawing.Size(216, 33);
            this.tb_massOut.TabIndex = 4;
            // 
            // rb_Asc
            // 
            this.rb_Asc.AutoSize = true;
            this.rb_Asc.Checked = true;
            this.rb_Asc.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rb_Asc.Location = new System.Drawing.Point(273, 12);
            this.rb_Asc.Name = "rb_Asc";
            this.rb_Asc.Size = new System.Drawing.Size(174, 29);
            this.rb_Asc.TabIndex = 5;
            this.rb_Asc.TabStop = true;
            this.rb_Asc.Text = "По возрастанию";
            this.rb_Asc.UseVisualStyleBackColor = true;
            // 
            // rb_Dec
            // 
            this.rb_Dec.AutoSize = true;
            this.rb_Dec.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.rb_Dec.Location = new System.Drawing.Point(273, 47);
            this.rb_Dec.Name = "rb_Dec";
            this.rb_Dec.Size = new System.Drawing.Size(150, 29);
            this.rb_Dec.TabIndex = 6;
            this.rb_Dec.TabStop = true;
            this.rb_Dec.Text = "По убыванию";
            this.rb_Dec.UseVisualStyleBackColor = true;
            // 
            // btn_sortSwap
            // 
            this.btn_sortSwap.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_sortSwap.Location = new System.Drawing.Point(273, 151);
            this.btn_sortSwap.Name = "btn_sortSwap";
            this.btn_sortSwap.Size = new System.Drawing.Size(158, 62);
            this.btn_sortSwap.TabIndex = 7;
            this.btn_sortSwap.Text = "Сортировка обменом";
            this.btn_sortSwap.UseVisualStyleBackColor = true;
            this.btn_sortSwap.Click += new System.EventHandler(this.btn_sortSwap_Click);
            // 
            // btn_sortSelect
            // 
            this.btn_sortSelect.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_sortSelect.Location = new System.Drawing.Point(273, 219);
            this.btn_sortSelect.Name = "btn_sortSelect";
            this.btn_sortSelect.Size = new System.Drawing.Size(158, 65);
            this.btn_sortSelect.TabIndex = 8;
            this.btn_sortSelect.Text = "Сортировка выбором";
            this.btn_sortSelect.UseVisualStyleBackColor = true;
            this.btn_sortSelect.Click += new System.EventHandler(this.btn_sortSelect_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btn_Clear.Location = new System.Drawing.Point(17, 219);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(158, 65);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 318);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_sortSelect);
            this.Controls.Add(this.btn_sortSwap);
            this.Controls.Add(this.rb_Dec);
            this.Controls.Add(this.rb_Asc);
            this.Controls.Add(this.tb_massOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_massEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sortShell);
            this.Name = "MainForm";
            this.Text = "4332_SafinRustem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sortShell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_massEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_massOut;
        private System.Windows.Forms.RadioButton rb_Asc;
        private System.Windows.Forms.RadioButton rb_Dec;
        private System.Windows.Forms.Button btn_sortSwap;
        private System.Windows.Forms.Button btn_sortSelect;
        private System.Windows.Forms.Button btn_Clear;
    }
}

