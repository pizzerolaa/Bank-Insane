namespace Bank_Insane
{
    partial class Loans
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loans));
            this.welcome = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perInfo = new System.Windows.Forms.Panel();
            this.countriesCB = new System.Windows.Forms.ComboBox();
            this.sexCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loansDet = new System.Windows.Forms.Panel();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.feesCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.perInfo.SuspendLayout();
            this.loansDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.welcome.Location = new System.Drawing.Point(52, 50);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(114, 29);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome, ";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Navy;
            this.backBtn.Font = new System.Drawing.Font("Minecraft", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Location = new System.Drawing.Point(676, 399);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 41);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.confirmBtn.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(339, 329);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(142, 70);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm request";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(137, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(560, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loans details";
            // 
            // perInfo
            // 
            this.perInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.perInfo.Controls.Add(this.countriesCB);
            this.perInfo.Controls.Add(this.sexCB);
            this.perInfo.Controls.Add(this.label4);
            this.perInfo.Controls.Add(this.label3);
            this.perInfo.Location = new System.Drawing.Point(57, 168);
            this.perInfo.Name = "perInfo";
            this.perInfo.Size = new System.Drawing.Size(293, 139);
            this.perInfo.TabIndex = 5;
            // 
            // countriesCB
            // 
            this.countriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesCB.FormattingEnabled = true;
            this.countriesCB.Location = new System.Drawing.Point(123, 85);
            this.countriesCB.Name = "countriesCB";
            this.countriesCB.Size = new System.Drawing.Size(121, 21);
            this.countriesCB.TabIndex = 3;
            // 
            // sexCB
            // 
            this.sexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexCB.FormattingEnabled = true;
            this.sexCB.Location = new System.Drawing.Point(123, 27);
            this.sexCB.Name = "sexCB";
            this.sexCB.Size = new System.Drawing.Size(121, 21);
            this.sexCB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Place of origin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(68, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sex:";
            // 
            // loansDet
            // 
            this.loansDet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loansDet.Controls.Add(this.amountBox);
            this.loansDet.Controls.Add(this.feesCB);
            this.loansDet.Controls.Add(this.label6);
            this.loansDet.Controls.Add(this.label5);
            this.errorProvider1.SetIconAlignment(this.loansDet, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.loansDet.Location = new System.Drawing.Point(457, 168);
            this.loansDet.Name = "loansDet";
            this.loansDet.Size = new System.Drawing.Size(293, 139);
            this.loansDet.TabIndex = 6;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(148, 24);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(121, 20);
            this.amountBox.TabIndex = 4;
            // 
            // feesCB
            // 
            this.feesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesCB.FormattingEnabled = true;
            this.feesCB.Location = new System.Drawing.Point(148, 82);
            this.feesCB.Name = "feesCB";
            this.feesCB.Size = new System.Drawing.Size(121, 21);
            this.feesCB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(101, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loan amount (s):";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.loansDet);
            this.Controls.Add(this.perInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            this.perInfo.ResumeLayout(false);
            this.perInfo.PerformLayout();
            this.loansDet.ResumeLayout(false);
            this.loansDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel perInfo;
        private System.Windows.Forms.Panel loansDet;
        private System.Windows.Forms.ComboBox countriesCB;
        private System.Windows.Forms.ComboBox sexCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.ComboBox feesCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}