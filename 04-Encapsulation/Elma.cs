﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation
{
    class Elma
    {
        decimal _agirlik;

        public void SetAgirlik(decimal agirlik)
        {
            if (agirlik>0 && agirlik<10)
            {
                _agirlik = agirlik;
            }
            else
            {
                throw new Exception("Ağırlı verisi Hatalı girildi");
            }
        }

        public decimal GetAgirlik()
        {
            return _agirlik;
        }

        decimal _fiyat;

        public void SetFiyat(decimal fiyat)
        {
            if (fiyat>0&&fiyat<2.5m)
            {
                _fiyat = fiyat;
            }
        }

        public decimal GetFiyat()
        {
           return _fiyat;
        }
    }
}
