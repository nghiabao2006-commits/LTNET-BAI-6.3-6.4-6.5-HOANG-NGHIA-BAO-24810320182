using QuanLyDuAn.BUS;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.GUI
{
    public partial class FormPhanCong : Form
    {
        private readonly PhanCongBUS phanCongBUS = new PhanCongBUS();
        private readonly int maTask;

        public FormPhanCong(int maTask, string tenTask)
        {
            InitializeComponent();
            this.maTask = maTask;
            lblTask.Text = "Công việc: " + tenTask + "\nChọn thành viên tham gia (có thể chọn nhiều người).";
            LoadThanhVien();
        }

        private void LoadThanhVien()
        {
            try
            {
                List<ThanhVien> danhSach = phanCongBUS.GetAllMembers();
                List<int> daPhanCong = phanCongBUS.GetMemberIds(maTask);

                checkedListBoxThanhVien.DisplayMember = "HoTen";
                checkedListBoxThanhVien.ValueMember = "MaThanhVien";
                checkedListBoxThanhVien.DataSource = danhSach;

                for (int i = 0; i < checkedListBoxThanhVien.Items.Count; i++)
                {
                    ThanhVien tv = checkedListBoxThanhVien.Items[i] as ThanhVien;
                    if (tv != null && daPhanCong.Contains(tv.MaThanhVien))
                    {
                        checkedListBoxThanhVien.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> danhSach = new List<int>();
                foreach (object item in checkedListBoxThanhVien.CheckedItems)
                {
                    ThanhVien tv = item as ThanhVien;
                    if (tv != null)
                    {
                        danhSach.Add(tv.MaThanhVien);
                    }
                }

                phanCongBUS.SaveAssignments(maTask, danhSach);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
