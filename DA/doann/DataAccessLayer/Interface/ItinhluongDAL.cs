using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;


namespace doann.DataAccessLayer.Interface
{ //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    interface ItinhluongDAL
    {
        List<tinhluong> GetAlltinhluong();
        void themtinhluong(tinhluong tl);

        void update(List<tinhluong> list);
    }
}
