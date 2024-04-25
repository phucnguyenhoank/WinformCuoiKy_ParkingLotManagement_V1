using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class SharedConnectionString
    {
        public static string ConnectionString = "Server=xichxo\\SQLEXPRESS;Database=ParkingLotManagement;Integrated Security=True;";
        // Chuỗi dưới sẽ được dùng nếu muốn các kết bị cùng mạng chạy code này kết nối được với CSDL
        // public static string ConnectionString="Server=192.168.209.230,1433;Database=ParkingLotManagement;User Id=sa;Password=12345;";

    }
}
