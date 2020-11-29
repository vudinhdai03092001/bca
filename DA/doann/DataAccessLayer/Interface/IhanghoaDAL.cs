using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using doann.Entities;

namespace doann.DataAccessLayer.Interface
{ //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    interface IhanghoaDAL
    {
        List<hanghoa> GetAllhanghoa();
        void themhanghoa(hanghoa hh);
        void update(List<hanghoa> list);

    }
}
