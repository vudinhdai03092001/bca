using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;

namespace doann.DataAccessLayer
{ //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public interface IhoadonbanDAL
    {
        List<hoadonban> GetAllhoadonban();
        void themhoadonban(hoadonban hd);
        void update(List<hoadonban> list);

    }
}
