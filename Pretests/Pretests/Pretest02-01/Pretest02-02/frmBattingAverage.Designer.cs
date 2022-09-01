namespace Pretest02_02
{
    partial class frmBattingAverage
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHighestAverage = new System.Windows.Forms.TextBox();
            this.txtLowestAverage = new System.Windows.Forms.TextBox();
            this.txtlTotalNumberAverages = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.txtAtBats = new System.Windows.Forms.TextBox();
            this.lblAtBats = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblHighestAverage = new System.Windows.Forms.Label();
            this.lblLowestAverage = new System.Windows.Forms.Label();
            this.lblTotalNumberAverages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(197, 310);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 67);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(445, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 67);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(681, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHighestAverage
            // 
            this.txtHighestAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighestAverage.Location = new System.Drawing.Point(827, 41);
            this.txtHighestAverage.Name = "txtHighestAverage";
            this.txtHighestAverage.ReadOnly = true;
            this.txtHighestAverage.Size = new System.Drawing.Size(194, 38);
            this.txtHighestAverage.TabIndex = 6;
            this.txtHighestAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLowestAverage
            // 
            this.txtLowestAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowestAverage.Location = new System.Drawing.Point(827, 124);
            this.txtLowestAverage.Name = "txtLowestAverage";
            this.txtLowestAverage.ReadOnly = true;
            this.txtLowestAverage.Size = new System.Drawing.Size(194, 38);
            this.txtLowestAverage.TabIndex = 7;
            this.txtLowestAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlTotalNumberAverages
            // 
            this.txtlTotalNumberAverages.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlTotalNumberAverages.Location = new System.Drawing.Point(827, 201);
            this.txtlTotalNumberAverages.Name = "txtlTotalNumberAverages";
            this.txtlTotalNumberAverages.ReadOnly = true;
            this.txtlTotalNumberAverages.Size = new System.Drawing.Size(194, 38);
            this.txtlTotalNumberAverages.TabIndex = 8;
            this.txtlTotalNumberAverages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(336, 201);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(194, 38);
            this.txtAverage.TabIndex = 5;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHits
            // 
            this.txtHits.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHits.Location = new System.Drawing.Point(336, 124);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(194, 38);
            this.txtHits.TabIndex = 1;
            this.txtHits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtBats
            // 
            this.txtAtBats.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtBats.Location = new System.Drawing.Point(336, 41);
            this.txtAtBats.Name = "txtAtBats";
            this.txtAtBats.Size = new System.Drawing.Size(194, 38);
            this.txtAtBats.TabIndex = 0;
            this.txtAtBats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAtBats
            // 
            this.lblAtBats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAtBats.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtBats.Location = new System.Drawing.Point(51, 41);
            this.lblAtBats.Name = "lblAtBats";
            this.lblAtBats.Size = new System.Drawing.Size(242, 34);
            this.lblAtBats.TabIndex = 9;
            this.lblAtBats.Text = "At Bats:";
            this.lblAtBats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHits
            // 
            this.lblHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHits.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHits.Location = new System.Drawing.Point(51, 124);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(242, 34);
            this.lblHits.TabIndex = 10;
            this.lblHits.Text = "Hits:";
            this.lblHits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(51, 204);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(242, 34);
            this.lblAverage.TabIndex = 11;
            this.lblAverage.Text = "Average::";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighestAverage
            // 
            this.lblHighestAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighestAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestAverage.Location = new System.Drawing.Point(565, 41);
            this.lblHighestAverage.Name = "lblHighestAverage";
            this.lblHighestAverage.Size = new System.Drawing.Size(242, 34);
            this.lblHighestAverage.TabIndex = 12;
            this.lblHighestAverage.Text = "Highest Average:";
            this.lblHighestAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowestAverage
            // 
            this.lblLowestAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLowestAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestAverage.Location = new System.Drawing.Point(565, 124);
            this.lblLowestAverage.Name = "lblLowestAverage";
            this.lblLowestAverage.Size = new System.Drawing.Size(242, 34);
            this.lblLowestAverage.TabIndex = 13;
            this.lblLowestAverage.Text = "Lowest Average:";
            this.lblLowestAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNumberAverages
            // 
            this.lblTotalNumberAverages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalNumberAverages.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberAverages.Location = new System.Drawing.Point(565, 201);
            this.lblTotalNumberAverages.Name = "lblTotalNumberAverages";
            this.lblTotalNumberAverages.Size = new System.Drawing.Size(242, 34);
            this.lblTotalNumberAverages.TabIndex = 14;
            this.lblTotalNumberAverages.Text = "Total # Averages:";
            this.lblTotalNumberAverages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBattingAverage
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1123, 416);
            this.Controls.Add(this.lblTotalNumberAverages);
            this.Controls.Add(this.lblLowestAverage);
            this.Controls.Add(this.lblHighestAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.lblAtBats);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtHits);
            this.Controls.Add(this.txtAtBats);
            this.Controls.Add(this.txtlTotalNumberAverages);
            this.Controls.Add(this.txtLowestAverage);
            this.Controls.Add(this.txtHighestAverage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmBattingAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batting Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHighestAverage;
        private System.Windows.Forms.TextBox txtLowestAverage;
        private System.Windows.Forms.TextBox txtlTotalNumberAverages;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.TextBox txtAtBats;
        private System.Windows.Forms.Label lblAtBats;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblHighestAverage;
        private System.Windows.Forms.Label lblLowestAverage;
        private System.Windows.Forms.Label lblTotalNumberAverages;
    }
}

