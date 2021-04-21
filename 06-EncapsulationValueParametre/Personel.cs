using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EncapsulationValueParametre
{
    class Personel
    {
        //Ad Soyad metinsel ve en az iki karakterli olmalı

        string _ad;
        public string Ad
        {
            get
            {

                return _ad;
            }
            set
            {
                foreach (char item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        throw new Exception("isim metinsel değerlerle oluşmalıdır");
                    }
                }
                if (value.Length < 3)
                {
                    throw new Exception("İsim en az 3 karakterden oluşmalıdır.");
                }
                else
                {
                    _ad = value;
                }


            }
        }

        //Ad Soyad metinsel ve en az iki karakterli olmalı

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set
            {

                foreach (char item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        throw new Exception("Soyisim metinsel karakterlerden oluşmalıdır");
                    }
                }
                if (value.Length >= 2)
                {
                    _soyad = value;
                }
                else
                {
                    throw new Exception("Personel Soyad en az iki karakterden oluşmalıdır");
                }


            }
        }


        //tc 11 karakterli son karakteri çift olmalı
        private string _tc;

        public string TCKimlikNo
        {
            get { return _tc; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("Tc Kimlik Numarası 11 Haneli olmaldıır ");
                }

                if (!long.TryParse(value, out long tc))
                {
                    throw new Exception("tc kimlik sayılardan oluşmalıdır");
                }
                if (tc % 2 != 0)
                {
                    throw new Exception("Tc kimlik numrası çift sayı olmalıdır");
                }
                _tc = value;

            }

        }

        //personelNumarası 
        //AdınBaşHarfi + SoyadınBasHarfi+tcson3harfi olmalı
        //Bilal Kırkgül 12345678910 BK910 

        private string _personelNo;

        public string PersonelNo
        {
            get { return _personelNo; }
            set
            {

                string SifreliNo = _ad.Substring(0, 1).ToUpper() + _soyad.Substring(0, 1).ToUpper() + _tc.Substring(8, 3);

                if (SifreliNo != value)
                {
                    throw new Exception("Personel No hatalı giriş yapıldı");
                }
                _personelNo = value;
            }
        }


        //email adresinde @ bulunup .com ile bitmeli

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set
            {

                if (value.Contains("@") && value.EndsWith(".com"))
                {
                    _mail = value;
                }
                else
                {
                    throw new Exception("Hatalı formatta mail adresi girildi");
                }
            }
        }



        public string MedeniHal { get; set; }
    }




}
