namespace RemoteController
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_connectedSessionCount = new System.Windows.Forms.Label();
            this.btn_sendCommand = new System.Windows.Forms.Button();
            this.tb_inputCommand = new System.Windows.Forms.TextBox();
            this.lb_connectedSessionInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "연결 세션 수 : ";
            // 
            // lbl_connectedSessionCount
            // 
            this.lbl_connectedSessionCount.AutoSize = true;
            this.lbl_connectedSessionCount.Location = new System.Drawing.Point(281, 238);
            this.lbl_connectedSessionCount.Name = "lbl_connectedSessionCount";
            this.lbl_connectedSessionCount.Size = new System.Drawing.Size(11, 12);
            this.lbl_connectedSessionCount.TabIndex = 1;
            this.lbl_connectedSessionCount.Text = "0";
            // 
            // btn_sendCommand
            // 
            this.btn_sendCommand.Location = new System.Drawing.Point(197, 259);
            this.btn_sendCommand.Name = "btn_sendCommand";
            this.btn_sendCommand.Size = new System.Drawing.Size(100, 23);
            this.btn_sendCommand.TabIndex = 2;
            this.btn_sendCommand.Text = "커맨드 실행";
            this.btn_sendCommand.UseVisualStyleBackColor = true;
            this.btn_sendCommand.Click += new System.EventHandler(this.btn_sendCommand_Click);
            // 
            // tb_inputCommand
            // 
            this.tb_inputCommand.Location = new System.Drawing.Point(15, 259);
            this.tb_inputCommand.Name = "tb_inputCommand";
            this.tb_inputCommand.Size = new System.Drawing.Size(176, 21);
            this.tb_inputCommand.TabIndex = 3;
            // 
            // lb_connectedSessionInfo
            // 
            this.lb_connectedSessionInfo.FormattingEnabled = true;
            this.lb_connectedSessionInfo.ItemHeight = 12;
            this.lb_connectedSessionInfo.Location = new System.Drawing.Point(16, 12);
            this.lb_connectedSessionInfo.Name = "lb_connectedSessionInfo";
            this.lb_connectedSessionInfo.Size = new System.Drawing.Size(276, 220);
            this.lb_connectedSessionInfo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 300);
            this.Controls.Add(this.lb_connectedSessionInfo);
            this.Controls.Add(this.tb_inputCommand);
            this.Controls.Add(this.btn_sendCommand);
            this.Controls.Add(this.lbl_connectedSessionCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_connectedSessionCount;
        private System.Windows.Forms.Button btn_sendCommand;
        private System.Windows.Forms.TextBox tb_inputCommand;
        private System.Windows.Forms.ListBox lb_connectedSessionInfo;
    }
}

