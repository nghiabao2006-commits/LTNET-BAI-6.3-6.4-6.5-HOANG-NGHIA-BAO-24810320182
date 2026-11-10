namespace QuanLyDuAn.GUI
{
    partial class FormPhanCong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTask = new System.Windows.Forms.Label();
            this.checkedListBoxThanhVien = new System.Windows.Forms.CheckedListBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTask.Location = new System.Drawing.Point(0, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.lblTask.Size = new System.Drawing.Size(434, 48);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Công việc:";
            // 
            // checkedListBoxThanhVien
            // 
            this.checkedListBoxThanhVien.CheckOnClick = true;
            this.checkedListBoxThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxThanhVien.FormattingEnabled = true;
            this.checkedListBoxThanhVien.IntegralHeight = false;
            this.checkedListBoxThanhVien.Location = new System.Drawing.Point(0, 48);
            this.checkedListBoxThanhVien.Name = "checkedListBoxThanhVien";
            this.checkedListBoxThanhVien.Size = new System.Drawing.Size(434, 329);
            this.checkedListBoxThanhVien.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnLuu);
            this.panelBottom.Controls.Add(this.btnDong);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 377);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(434, 56);
            this.panelBottom.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(202, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 32);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(312, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 433);
            this.Controls.Add(this.checkedListBoxThanhVien);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "FormPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phân công công việc";
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.CheckedListBox checkedListBoxThanhVien;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}
