namespace Saver_Images_from_OmSTU_Lib
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStartPage = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownEndPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL of book";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(107, 6);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(198, 20);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Enter += new System.EventHandler(selectTextBoxText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start page";
            // 
            // numericUpDownStartPage
            // 
            this.numericUpDownStartPage.Location = new System.Drawing.Point(107, 32);
            this.numericUpDownStartPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPage.Name = "numericUpDownStartPage";
            this.numericUpDownStartPage.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownStartPage.TabIndex = 2;
            this.numericUpDownStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartPage.Enter += new System.EventHandler(selectNumUpDownText);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(125, 88);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save book";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path for save";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(107, 59);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(106, 20);
            this.textBoxPath.TabIndex = 4;
            this.textBoxPath.Enter += new System.EventHandler(selectTextBoxText);
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(219, 56);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(86, 23);
            this.buttonSelectPath.TabIndex = 5;
            this.buttonSelectPath.Text = "Select path...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End page";
            // 
            // numericUpDownEndPage
            // 
            this.numericUpDownEndPage.Location = new System.Drawing.Point(238, 32);
            this.numericUpDownEndPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEndPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndPage.Name = "numericUpDownEndPage";
            this.numericUpDownEndPage.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownEndPage.TabIndex = 3;
            this.numericUpDownEndPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEndPage.Enter += new System.EventHandler(selectNumUpDownText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 123);
            this.Controls.Add(this.numericUpDownEndPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownStartPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Saver";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownEndPage;
    }
}

