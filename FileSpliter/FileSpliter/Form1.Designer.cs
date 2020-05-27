namespace jp.mn.jp.uk.FileSpliter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lbl002 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lbl001 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(100, 53);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(625, 19);
            this.txtDest.TabIndex = 8;
            // 
            // lbl002
            // 
            this.lbl002.AutoSize = true;
            this.lbl002.Location = new System.Drawing.Point(18, 56);
            this.lbl002.Name = "lbl002";
            this.lbl002.Size = new System.Drawing.Size(41, 12);
            this.lbl002.TabIndex = 6;
            this.lbl002.Text = "保存先";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(100, 28);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(625, 19);
            this.txtTarget.TabIndex = 9;
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Location = new System.Drawing.Point(18, 31);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(76, 12);
            this.lbl001.TabIndex = 7;
            this.lbl001.Text = "検索先フォルダ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(365, 91);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(146, 58);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(731, 28);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(47, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "参照";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 176);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lbl002);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lbl001);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lbl002;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSet;
    }
}

