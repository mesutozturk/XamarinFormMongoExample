using System;

namespace XamarinFormMongo.Models
{
    public class Gorev
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GorevAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
    }
}
