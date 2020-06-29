namespace SullivanBankAccount
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtATMPIN = new System.Windows.Forms.TextBox();
            this.txtATMAcctNum = new System.Windows.Forms.TextBox();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblATMPIN = new System.Windows.Forms.Label();
            this.lblATMAcctNum = new System.Windows.Forms.Label();
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAcctType = new System.Windows.Forms.Label();
            this.tabDepositWithdraw = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lbTransactions = new System.Windows.Forms.ListBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabDepositWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabDepositWithdraw);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.Tan;
            this.tabWelcome.Controls.Add(this.txtWelcome);
            this.tabWelcome.Controls.Add(this.lblTitle);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(574, 340);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.Color.Tan;
            this.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWelcome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(7, 171);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.ReadOnly = true;
            this.txtWelcome.Size = new System.Drawing.Size(561, 96);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Welcome to the C# Banking Center";
            this.txtWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(561, 93);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "C# Banking Center";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.Tan;
            this.tabAccount.Controls.Add(this.btnUpdate);
            this.tabAccount.Controls.Add(this.lblInfo);
            this.tabAccount.Controls.Add(this.txtPercent);
            this.tabAccount.Controls.Add(this.txtATMPIN);
            this.tabAccount.Controls.Add(this.txtATMAcctNum);
            this.tabAccount.Controls.Add(this.txtAcctNum);
            this.tabAccount.Controls.Add(this.txtName);
            this.tabAccount.Controls.Add(this.cmbxType);
            this.tabAccount.Controls.Add(this.lblPercent);
            this.tabAccount.Controls.Add(this.lblATMPIN);
            this.tabAccount.Controls.Add(this.lblATMAcctNum);
            this.tabAccount.Controls.Add(this.lblAcctNum);
            this.tabAccount.Controls.Add(this.lblName);
            this.tabAccount.Controls.Add(this.lblAcctType);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(574, 340);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Account";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(240, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 27);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(561, 60);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Account Information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(293, 241);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(209, 20);
            this.txtPercent.TabIndex = 11;
            this.txtPercent.Visible = false;
            // 
            // txtATMPIN
            // 
            this.txtATMPIN.Location = new System.Drawing.Point(293, 212);
            this.txtATMPIN.MaxLength = 4;
            this.txtATMPIN.Name = "txtATMPIN";
            this.txtATMPIN.Size = new System.Drawing.Size(209, 20);
            this.txtATMPIN.TabIndex = 10;
            this.txtATMPIN.Visible = false;
            // 
            // txtATMAcctNum
            // 
            this.txtATMAcctNum.Location = new System.Drawing.Point(293, 183);
            this.txtATMAcctNum.Name = "txtATMAcctNum";
            this.txtATMAcctNum.Size = new System.Drawing.Size(209, 20);
            this.txtATMAcctNum.TabIndex = 9;
            this.txtATMAcctNum.Visible = false;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Location = new System.Drawing.Point(293, 154);
            this.txtAcctNum.MaxLength = 5;
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(209, 20);
            this.txtAcctNum.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(293, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 7;
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Items.AddRange(new object[] {
            "Bank",
            "Silver",
            "Gold"});
            this.cmbxType.Location = new System.Drawing.Point(293, 95);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(209, 21);
            this.cmbxType.TabIndex = 6;
            this.cmbxType.Text = "Bank";
            this.cmbxType.SelectedIndexChanged += new System.EventHandler(this.cmbxType_SelectedIndexChanged);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(63, 243);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(181, 18);
            this.lblPercent.TabIndex = 5;
            this.lblPercent.Text = "Percent Rate in Percent(5%)";
            this.lblPercent.Visible = false;
            // 
            // lblATMPIN
            // 
            this.lblATMPIN.AutoSize = true;
            this.lblATMPIN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMPIN.Location = new System.Drawing.Point(63, 214);
            this.lblATMPIN.Name = "lblATMPIN";
            this.lblATMPIN.Size = new System.Drawing.Size(60, 18);
            this.lblATMPIN.TabIndex = 4;
            this.lblATMPIN.Text = "ATM PIN";
            this.lblATMPIN.Visible = false;
            // 
            // lblATMAcctNum
            // 
            this.lblATMAcctNum.AutoSize = true;
            this.lblATMAcctNum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMAcctNum.Location = new System.Drawing.Point(63, 185);
            this.lblATMAcctNum.Name = "lblATMAcctNum";
            this.lblATMAcctNum.Size = new System.Drawing.Size(121, 18);
            this.lblATMAcctNum.TabIndex = 3;
            this.lblATMAcctNum.Text = "ATM Account Num";
            this.lblATMAcctNum.Visible = false;
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum.Location = new System.Drawing.Point(61, 156);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(67, 18);
            this.lblAcctNum.TabIndex = 2;
            this.lblAcctNum.Text = "Acct Num";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAcctType
            // 
            this.lblAcctType.AutoSize = true;
            this.lblAcctType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctType.Location = new System.Drawing.Point(61, 98);
            this.lblAcctType.Name = "lblAcctType";
            this.lblAcctType.Size = new System.Drawing.Size(66, 18);
            this.lblAcctType.TabIndex = 0;
            this.lblAcctType.Text = "Acct Type";
            // 
            // tabDepositWithdraw
            // 
            this.tabDepositWithdraw.BackColor = System.Drawing.Color.Tan;
            this.tabDepositWithdraw.Controls.Add(this.btnClear);
            this.tabDepositWithdraw.Controls.Add(this.lblTransactions);
            this.tabDepositWithdraw.Controls.Add(this.lbTransactions);
            this.tabDepositWithdraw.Controls.Add(this.txtResults);
            this.tabDepositWithdraw.Controls.Add(this.btnProcess);
            this.tabDepositWithdraw.Controls.Add(this.rbWithdraw);
            this.tabDepositWithdraw.Controls.Add(this.rbDeposit);
            this.tabDepositWithdraw.Controls.Add(this.txtAmount);
            this.tabDepositWithdraw.Controls.Add(this.lblResults);
            this.tabDepositWithdraw.Controls.Add(this.lblAmount);
            this.tabDepositWithdraw.Location = new System.Drawing.Point(4, 22);
            this.tabDepositWithdraw.Name = "tabDepositWithdraw";
            this.tabDepositWithdraw.Size = new System.Drawing.Size(574, 340);
            this.tabDepositWithdraw.TabIndex = 2;
            this.tabDepositWithdraw.Text = "Deposit/Withdraw";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(132, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 36);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTransactions
            // 
            this.lblTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactions.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(6, 0);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(561, 58);
            this.lblTransactions.TabIndex = 13;
            this.lblTransactions.Text = "Transactions";
            this.lblTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransactions
            // 
            this.lbTransactions.FormattingEnabled = true;
            this.lbTransactions.Location = new System.Drawing.Point(320, 75);
            this.lbTransactions.Name = "lbTransactions";
            this.lbTransactions.Size = new System.Drawing.Size(217, 251);
            this.lbTransactions.TabIndex = 7;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResults.Location = new System.Drawing.Point(132, 185);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(169, 99);
            this.txtResults.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProcess.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcess.Location = new System.Drawing.Point(130, 139);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(171, 36);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process Transaction";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWithdraw.Location = new System.Drawing.Point(212, 102);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(87, 22);
            this.rbWithdraw.TabIndex = 4;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposit.Location = new System.Drawing.Point(132, 102);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(74, 22);
            this.rbDeposit.TabIndex = 3;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 75);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(44, 185);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(53, 18);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(39, 75);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 18);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank Account";
            this.tabControl1.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabDepositWithdraw.ResumeLayout(false);
            this.tabDepositWithdraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabDepositWithdraw;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtATMPIN;
        private System.Windows.Forms.TextBox txtATMAcctNum;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblATMPIN;
        private System.Windows.Forms.Label lblATMAcctNum;
        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAcctType;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ListBox lbTransactions;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
    }
}

