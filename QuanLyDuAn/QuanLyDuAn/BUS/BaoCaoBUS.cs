using QuanLyDuAn.DAL;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.BUS
{
    public class BaoCaoBUS
    {
        private readonly BaoCaoDAL dal = new BaoCaoDAL();

        public List<CongViecTreHan> GetOverdue()
        {
            return dal.GetOverdue();
        }

        public List<ThongKeThanhVien> GetStatistics(int maDuAn)
        {
            if (maDuAn <= 0)
            {
                throw new Exception("Vui lòng chọn dự án cần thống kê.");
            }
            return dal.GetStatistics(maDuAn);
        }

        public decimal GetCompletionRate(int maDuAn)
        {
            if (maDuAn <= 0)
            {
                throw new Exception("Vui lòng chọn dự án cần thống kê.");
            }
            return dal.GetCompletionRate(maDuAn);
        }
    }
}
