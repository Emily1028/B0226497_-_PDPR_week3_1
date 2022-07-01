
namespace B0226497_段昱如_PDPR_week3_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(57, 25);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(278, 19);
            this.label.TabIndex = 0;
            this.label.Text = "B0226497_段昱如_PDPR_week3_1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(61, 108);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 108);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(57, 201);
            this.lblresult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(68, 19);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "lblresult";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 390);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblresult;
    }
}

