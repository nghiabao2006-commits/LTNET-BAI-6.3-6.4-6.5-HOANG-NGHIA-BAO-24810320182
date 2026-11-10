using QuanLyKaraoke.DAL;
using QuanLyKaraoke.GUI;

namespace QuanLyKaraoke
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                DatabaseInitializer.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi tạo cơ sở dữ liệu.\n" + ex.Message,
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
