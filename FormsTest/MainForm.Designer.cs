namespace FormsTest
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TipsXLabel = new System.Windows.Forms.Label();
            this.NumberXText = new System.Windows.Forms.TextBox();
            this.TipsYLabel = new System.Windows.Forms.Label();
            this.NumberYText = new System.Windows.Forms.TextBox();
            this.caculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TipsXLabel
            // 
            this.TipsXLabel.AutoSize = true;
            this.TipsXLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TipsXLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipsXLabel.Location = new System.Drawing.Point(132, 97);
            this.TipsXLabel.Name = "TipsXLabel";
            this.TipsXLabel.Size = new System.Drawing.Size(159, 20);
            this.TipsXLabel.TabIndex = 0;
            this.TipsXLabel.Text = "Please input x:";
            // 
            // NumberXText
            // 
            this.NumberXText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberXText.Location = new System.Drawing.Point(299, 92);
            this.NumberXText.Name = "NumberXText";
            this.NumberXText.Size = new System.Drawing.Size(100, 30);
            this.NumberXText.TabIndex = 1;
            this.NumberXText.Text = "0";
            // TipsYLabel
            // 
            this.TipsYLabel.AutoSize = true;
            this.TipsYLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipsYLabel.Location = new System.Drawing.Point(132, 147);
            this.TipsYLabel.Name = "TipsYLabel";
            this.TipsYLabel.Size = new System.Drawing.Size(159, 20);
            this.TipsYLabel.TabIndex = 2;
            this.TipsYLabel.Text = "Please input y:";
            // 
            // NumberYText
            // 
            this.NumberYText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberYText.Location = new System.Drawing.Point(298, 144);
            this.NumberYText.Name = "NumberYText";
            this.NumberYText.Size = new System.Drawing.Size(100, 30);
            this.NumberYText.TabIndex = 3;
            this.NumberYText.Text = "0";
            // 
            // caculateButton
            // 
            this.caculateButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.caculateButton.Location = new System.Drawing.Point(225, 206);
            this.caculateButton.Name = "caculateButton";
            this.caculateButton.Size = new System.Drawing.Size(134, 35);
            this.caculateButton.TabIndex = 4;
            this.caculateButton.Text = "caculate";
            this.caculateButton.UseVisualStyleBackColor = true;
            this.caculateButton.Click += new System.EventHandler(this.caculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultLabel.Location = new System.Drawing.Point(132, 274);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 419);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.caculateButton);
            this.Controls.Add(this.NumberYText);
            this.Controls.Add(this.TipsYLabel);
            this.Controls.Add(this.NumberXText);
            this.Controls.Add(this.TipsXLabel);
            this.Name = "Form";
            this.Text = "MutiplicationForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipsXLabel;
        private System.Windows.Forms.TextBox NumberXText;
        private System.Windows.Forms.Label TipsYLabel;
        private System.Windows.Forms.TextBox NumberYText;
        private System.Windows.Forms.Button caculateButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

