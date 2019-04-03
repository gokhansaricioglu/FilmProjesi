using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public static class ValidationCheck
    {
            public static bool SifreGecerliMi(string sifre)
            {
                if (sifre.Length < 6)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static bool MailGecerliMi(string eMail)
            {
                if (eMail.IndexOf('@') == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static bool TelefonGecerliMi(string telefon)
            {
                if (telefon.Length != 10)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static bool DoğumTarihiGelecekteMi(DateTime dogumTarihi)
            {
                if (dogumTarihi > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool DoğumTarihiGecerliMi(DateTime dogumTarihi)
            {
                if (DateTime.Now.Year - dogumTarihi.Year < 13)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static bool SifreTekrarGecerliMi(string sifreTekrar, string sifre)
            {
                if (sifreTekrar.Equals(sifre) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool TextBosMu(string text)
            {
                if (string.IsNullOrWhiteSpace(text) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
