namespace FutureMeApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbDeliveryTime;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDeliveryTime;
        private System.Windows.Forms.Button btnSend;

        /// <summary>
        /// Освобождаем ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть удалены; иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Код для инициализации компонентов формы.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbDeliveryTime = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDeliveryTime = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 50);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(475, 444);
            this.txtMessage.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(505, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // cmbDeliveryTime
            // 
            this.cmbDeliveryTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryTime.FormattingEnabled = true;
            this.cmbDeliveryTime.Items.AddRange(new object[] {
            "6 месяцев",
            "1 год",
            "3 года",
            "5 лет",
            "10 лет"});
            this.cmbDeliveryTime.Location = new System.Drawing.Point(505, 160);
            this.cmbDeliveryTime.Name = "cmbDeliveryTime";
            this.cmbDeliveryTime.Size = new System.Drawing.Size(259, 24);
            this.cmbDeliveryTime.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(185, 16);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Напишите свое сообщение:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(502, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Ваш email:";
            // 
            // lblDeliveryTime
            // 
            this.lblDeliveryTime.AutoSize = true;
            this.lblDeliveryTime.Location = new System.Drawing.Point(502, 127);
            this.lblDeliveryTime.Name = "lblDeliveryTime";
            this.lblDeliveryTime.Size = new System.Drawing.Size(182, 16);
            this.lblDeliveryTime.TabIndex = 5;
            this.lblDeliveryTime.Text = "Выберите время доставки:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(505, 454);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(259, 40);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Отправить в Будущее";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 506);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblDeliveryTime);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbDeliveryTime);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMessage);
            this.Name = "MainForm";
            this.Text = "FutureMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
