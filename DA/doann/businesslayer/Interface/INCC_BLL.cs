using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;


namespace doann.businesslayer.Interface
{
   public interface INCC_BLL
    {
        List<NCC> GetAllNCC();
        void themhangncc(NCC ncc);
        void xoancc(NCC mancc);
        void suancc(NCC ncc);
        List<NCC> timncc(NCC ncc);
    }
    


}
