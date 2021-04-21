using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation.Classes
{
    class Ogrenci
    {

        int _okulNo;
        public void SetOkulNo(int okulNo)
        {
            if (okulNo.ToString().Length==3)
            {
                _okulNo = okulNo;
            }
            else
            {
                throw new Exception("okul no 3 harfli olmalıdır");
            }
        }
        public int GetOkulNo()
        {
            return _okulNo;
        }
        string _isim;
        public void SetIsim(string isim)
        {
            if (isim.Length>2&&isim.Length<=15)
            {
                _isim = isim;
            }
            else
            {
                throw new Exception("isim en az 3 karakter ve en fazla 15 karakter olmalıdır");
            }
        }

        public string GetIsim()
        {
            return _isim;
        }

        DateTime _dogumTarihi;

        public void SetDogumTarihi(DateTime dogumTarihi)
        {
            if (dogumTarihi<DateTime.Now)
            {
                _dogumTarihi = dogumTarihi;
            }
            else
            {
                throw new Exception("dogum tarihi bugünden önce olmaldıır");
            }
        }

        public DateTime GetDogumTarihi()
        {
            return _dogumTarihi;
        }

    }
}
