namespace WindowsFormsApp4
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
            this.labelResolution = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(253, 47);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(173, 20);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Бегущая строка...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(26, 196);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(119, 71);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Чтение файла и бегущая строка";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_MouseClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(518, 196);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 71);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть приложение";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseClick);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(356, 196);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(119, 71);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Изменить форму";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChange_MouseClick);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(192, 196);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(119, 71);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Замена по тэгам";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 295);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelResolution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonReplace;
    }
}

