using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Utility;
using doann.Entities;

namespace doann.DataAccessLayer.Interface
{
    interface IhoadonbanDAL
    {
        List<hoadonban> GetAllhoadonban();
        void themhoadonban(hoadonban hd);
        void update(List<hoadonban> list);

    }
}
