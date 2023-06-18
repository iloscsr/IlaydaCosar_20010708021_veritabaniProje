using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlaydaCosar_20010708021_veritabaniProje
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return $"{AD} {Soyad}";
        }
    }
    public class Urun
    {
        public Guid ID { get; set; }
        public string AD { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return $"{AD}";
        }

    }
    public class Satis
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid UrunID { get; set; }
        public DateTime Tarih { get; set; }
        public double Fiyat { get; set; }

    }
    public class Odeme
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }

    }

}
