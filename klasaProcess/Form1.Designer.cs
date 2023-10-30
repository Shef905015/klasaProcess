namespace klasaProcess
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
            this.btnEdge = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnStartInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdge
            // 
            this.btnEdge.Location = new System.Drawing.Point(41, 40);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(169, 23);
            this.btnEdge.TabIndex = 0;
            this.btnEdge.Text = "Pokrenite Microsoft Edge";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(41, 79);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(169, 23);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Pokrenite Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(216, 40);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(182, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Pokrenite Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnStartInfo
            // 
            this.btnStartInfo.Location = new System.Drawing.Point(216, 79);
            this.btnStartInfo.Name = "btnStartInfo";
            this.btnStartInfo.Size = new System.Drawing.Size(182, 23);
            this.btnStartInfo.TabIndex = 3;
            this.btnStartInfo.Text = "StartInfo";
            this.btnStartInfo.UseVisualStyleBackColor = true;
            this.btnStartInfo.Click += new System.EventHandler(this.btnStartInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 134);
            this.Controls.Add(this.btnStartInfo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnEdge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnStartInfo;
    }
}

