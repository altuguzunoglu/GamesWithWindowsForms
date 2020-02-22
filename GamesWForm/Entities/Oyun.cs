using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWForm.Entities
{
    class Oyun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double? Maliyeti { get; set; }
        public double? Kazanci { get; set; }
        public int YilId { get; set; }
        public Yil Yil { get; set; }
        public ICollection<OyunTur> OyunTurleri { get; set; }
    }
}
