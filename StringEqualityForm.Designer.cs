namespace StringEqualityToluA
{
    partial class frmStringEquality
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtStringOne = new System.Windows.Forms.TextBox();
            this.txtStringTwo = new System.Windows.Forms.TextBox();
            this.lblStringOne = new System.Windows.Forms.Label();
            this.lblStringTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(11, 136);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(8, 9);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(418, 30);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Enter two strings in the Textbox to see if they are Equal\r\n(Cases Dont Matter)\r\n";
            // 
            // txtStringOne
            // 
            this.txtStringOne.Location = new System.Drawing.Point(122, 57);
            this.txtStringOne.Name = "txtStringOne";
            this.txtStringOne.Size = new System.Drawing.Size(181, 20);
            this.txtStringOne.TabIndex = 2;
            // 
            // txtStringTwo
            // 
            this.txtStringTwo.Location = new System.Drawing.Point(122, 97);
            this.txtStringTwo.Name = "txtStringTwo";
            this.txtStringTwo.Size = new System.Drawing.Size(181, 20);
            this.txtStringTwo.TabIndex = 3;
            // 
            // lblStringOne
            // 
            this.lblStringOne.AutoSize = true;
            this.lblStringOne.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringOne.Location = new System.Drawing.Point(8, 57);
            this.lblStringOne.Name = "lblStringOne";
            this.lblStringOne.Size = new System.Drawing.Size(89, 15);
            this.lblStringOne.TabIndex = 4;
            this.lblStringOne.Text = "String One:";
            // 
            // lblStringTwo
            // 
            this.lblStringTwo.AutoSize = true;
            this.lblStringTwo.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringTwo.Location = new System.Drawing.Point(8, 97);
            this.lblStringTwo.Name = "lblStringTwo";
            this.lblStringTwo.Size = new System.Drawing.Size(91, 15);
            this.lblStringTwo.TabIndex = 5;
            this.lblStringTwo.Text = "String Two:";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 175);
            this.Controls.Add(this.lblStringTwo);
            this.Controls.Add(this.lblStringOne);
            this.Controls.Add(this.txtStringTwo);
            this.Controls.Add(this.txtStringOne);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmStringEquality";
            this.Text = "String Equality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtStringOne;
        private System.Windows.Forms.TextBox txtStringTwo;
        private System.Windows.Forms.Label lblStringOne;
        private System.Windows.Forms.Label lblStringTwo;
    }
}

