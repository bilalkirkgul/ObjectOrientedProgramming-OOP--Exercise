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

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set
            {

                foreach (char item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        throw new Exception("İsim metinsel karakterlerden oluşmalıdır");
                    }
                }
                if (value.Length >= 3)
                {
                    _ad = value;

                }
                else
                {
                    throw new Exception("İsim en az 3 karakterden oluşmalıdır");
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
                        throw new Exception("Soyad metinsel karakterlerden oluşmalıdır");
                    }
                }
                if (value.Length >= 2)
                {
                    _soyad = value;

                }
                else
                {
                    throw new Exception("Soyad en az 2 karakterden oluşmalıdır");
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
                    throw new Exception("TC No 11 karakterli olmalıdır");
                }

                if (!long.TryParse(value, out long tcNo))
                {
                    throw new Exception("TC No sayılardan oluşmalıdır");
                }
                if (tcNo % 2 != 0)
                {
                    throw new Exception("Hatalı tc no girildi. Son hane çift sayı olmalıdır");
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

                string perNo = _ad.Substring(0, 1).ToUpper() + _soyad.Substring(90, 1).ToUpper() + _tc.Substring(8, 3);

                if (perNo != value)
                {
                    throw new Exception("Hatalı personel numrası girdiniz");
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
                    throw new Exception("Hatalı formatta mail adresi girdiniz");
                }
            }
        }




        public string MedeniHal { get; set; }
    }




}
