namespace Server
{
    partial class Server
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
            this.btnStartServ = new System.Windows.Forms.Button();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStartServ
            // 
            this.btnStartServ.Location = new System.Drawing.Point(95, 298);
            this.btnStartServ.Name = "btnStartServ";
            this.btnStartServ.Size = new System.Drawing.Size(168, 62);
            this.btnStartServ.TabIndex = 0;
            this.btnStartServ.Text = "button1";
            this.btnStartServ.UseVisualStyleBackColor = true;
            this.btnStartServ.Click += new System.EventHandler(this.btnStartServ_Click);
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(77, 74);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(274, 146);
            this.rtbMsg.TabIndex = 1;
            this.rtbMsg.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 434);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.btnStartServ);
            this.Name = "Server";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartServ;
        private System.Windows.Forms.RichTextBox rtbMsg;
    }
}

