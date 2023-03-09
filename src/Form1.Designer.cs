namespace UsingDotNET.SetProxy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProxyByPass = new TextBox();
            btnSetProxy = new Button();
            chkEnabled = new CheckBox();
            txtProxyServer = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtProxyByPass
            // 
            txtProxyByPass.AcceptsReturn = true;
            txtProxyByPass.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProxyByPass.Location = new Point(17, 116);
            txtProxyByPass.Margin = new Padding(4);
            txtProxyByPass.Multiline = true;
            txtProxyByPass.Name = "txtProxyByPass";
            txtProxyByPass.ScrollBars = ScrollBars.Both;
            txtProxyByPass.Size = new Size(489, 600);
            txtProxyByPass.TabIndex = 4;
            // 
            // btnSetProxy
            // 
            btnSetProxy.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetProxy.Location = new Point(87, 739);
            btnSetProxy.Margin = new Padding(4);
            btnSetProxy.Name = "btnSetProxy";
            btnSetProxy.Size = new Size(156, 28);
            btnSetProxy.TabIndex = 0;
            btnSetProxy.Text = "确定";
            btnSetProxy.UseVisualStyleBackColor = true;
            btnSetProxy.Click += btnSetProxy_Click;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkEnabled.Location = new Point(17, 56);
            chkEnabled.Margin = new Padding(4);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(141, 25);
            chkEnabled.TabIndex = 2;
            chkEnabled.Text = "使用代理服务器";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtProxyServer
            // 
            txtProxyServer.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProxyServer.Location = new Point(17, 15);
            txtProxyServer.Margin = new Padding(4);
            txtProxyServer.Name = "txtProxyServer";
            txtProxyServer.Size = new Size(281, 28);
            txtProxyServer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 21);
            label1.TabIndex = 3;
            label1.Text = "请勿将代理服务器用于下列地址";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(306, 739);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(163, 28);
            button1.TabIndex = 5;
            button1.Text = "打开系统代理设置";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 779);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtProxyServer);
            Controls.Add(chkEnabled);
            Controls.Add(btnSetProxy);
            Controls.Add(txtProxyByPass);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Proxy";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProxyByPass;
        private Button btnSetProxy;
        private CheckBox chkEnabled;
        private TextBox txtProxyServer;
        private Label label1;
        private Button button1;
    }
}