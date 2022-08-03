using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_TRACNGHIEM
{
    class CauHoi
    {
        private Int32 cauHoiID;
        private String noiDung = "";
        private String a = "";
        private String b = "";
        private String c = "";
        private String d = "";
        private String dapAn = "";
        private String chon = "";

        public CauHoi() { }

        public CauHoi(int cauHoi, String noiDung, String A, String B, String C, String D, String dapAn, String chon)
        {
            this.cauHoiID = cauHoi;
            this.noiDung = noiDung;
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.dapAn = dapAn;
            this.chon = chon; 
        }

        public Int32 CauHoiID
        {
            get { return cauHoiID; }
            set { cauHoiID = value; }
        }

        public String NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }

        public String A
        {
            get { return a; }
            set { a = value; }
        }

        public String B
        {
            get { return b; }
            set { b = value; }
        }

        public String C
        {
            get { return c; }
            set { c = value; }
        }

        public String D
        {
            get { return d; }
            set { d = value; }
        }

        public String DapAn 
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        public String Chon
        {
            get { return chon; }
            set { chon = value; }
        }

    }
}
