namespace CS408Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconButton = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logText = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox_Side = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox_Main.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox_Side.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_Main.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_Main.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(839, 745);
            this.groupBox_Main.TabIndex = 1;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "MAIN MENU";
            this.groupBox_Main.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 696);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Controls.Add(this.usernameText);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 136);
            this.panel2.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(21, 64);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(534, 50);
            this.usernameTextBox.TabIndex = 6;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameText.Location = new System.Drawing.Point(14, 23);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(155, 38);
            this.usernameText.TabIndex = 4;
            this.usernameText.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disconButton);
            this.panel1.Controls.Add(this.portText);
            this.panel1.Controls.Add(this.ipText);
            this.panel1.Controls.Add(this.portTextBox);
            this.panel1.Controls.Add(this.ipTextBox);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Location = new System.Drawing.Point(3, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 204);
            this.panel1.TabIndex = 0;
            // 
            // disconButton
            // 
            this.disconButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disconButton.Location = new System.Drawing.Point(561, 148);
            this.disconButton.Name = "disconButton";
            this.disconButton.Size = new System.Drawing.Size(243, 46);
            this.disconButton.TabIndex = 5;
            this.disconButton.Text = "Disconnect";
            this.disconButton.UseVisualStyleBackColor = true;
            this.disconButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portText.Location = new System.Drawing.Point(554, 30);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(153, 38);
            this.portText.TabIndex = 4;
            this.portText.Text = "Server Port";
            // 
            // ipText
            // 
            this.ipText.AutoSize = true;
            this.ipText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipText.Location = new System.Drawing.Point(14, 30);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(147, 38);
            this.ipText.TabIndex = 3;
            this.ipText.Text = "IP Address";
            this.ipText.Click += new System.EventHandler(this.label1_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(561, 78);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(243, 50);
            this.portTextBox.TabIndex = 2;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(21, 78);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(534, 50);
            this.ipTextBox.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectButton.Location = new System.Drawing.Point(312, 148);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(243, 46);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logText);
            this.panel3.Controls.Add(this.logTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 341);
            this.panel3.TabIndex = 2;
            // 
            // logText
            // 
            this.logText.AutoSize = true;
            this.logText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logText.Location = new System.Drawing.Point(14, 13);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(62, 38);
            this.logText.TabIndex = 6;
            this.logText.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(21, 54);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(783, 281);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // groupBox_Side
            // 
            this.groupBox_Side.Controls.Add(this.refreshButton);
            this.groupBox_Side.Controls.Add(this.listBox1);
            this.groupBox_Side.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Side.Location = new System.Drawing.Point(857, 12);
            this.groupBox_Side.Name = "groupBox_Side";
            this.groupBox_Side.Size = new System.Drawing.Size(401, 745);
            this.groupBox_Side.TabIndex = 2;
            this.groupBox_Side.TabStop = false;
            this.groupBox_Side.Text = "PLAYER LIST";
            this.groupBox_Side.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshButton.Location = new System.Drawing.Point(210, 680);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(185, 46);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Retrieve list";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(6, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(389, 612);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 769);
            this.Controls.Add(this.groupBox_Main);
            this.Controls.Add(this.groupBox_Side);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Main.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox_Side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Side;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label portText;
        private System.Windows.Forms.Label ipText;
        private System.Windows.Forms.Button disconButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label logText;
        private System.Windows.Forms.RichTextBox logTextBox;
    }
}

