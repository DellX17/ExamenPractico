
namespace Servidor
{
    partial class Servidor
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.btnTXT = new System.Windows.Forms.Button();
            this.btnTEST = new System.Windows.Forms.Button();
            this.txtTEST = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 25;
            this.dgvInfo.Size = new System.Drawing.Size(687, 392);
            this.dgvInfo.TabIndex = 1;
            // 
            // btnTXT
            // 
            this.btnTXT.Location = new System.Drawing.Point(12, 423);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(192, 44);
            this.btnTXT.TabIndex = 2;
            this.btnTXT.Text = "Leer TXT";
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click_1);
            // 
            // btnTEST
            // 
            this.btnTEST.Location = new System.Drawing.Point(7, 60);
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.Size = new System.Drawing.Size(187, 23);
            this.btnTEST.TabIndex = 3;
            this.btnTEST.Text = "STRING a TXT";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // txtTEST
            // 
            this.txtTEST.Location = new System.Drawing.Point(7, 31);
            this.txtTEST.Name = "txtTEST";
            this.txtTEST.Size = new System.Drawing.Size(187, 23);
            this.txtTEST.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTEST);
            this.groupBox1.Controls.Add(this.btnTEST);
            this.groupBox1.Location = new System.Drawing.Point(710, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARA PROBAR";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.dgvInfo);
            this.Name = "Servidor";
            this.Text = "Servidor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button btnTEST;
        private System.Windows.Forms.TextBox txtTEST;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}