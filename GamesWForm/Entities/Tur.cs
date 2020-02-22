using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWForm.Entities
{
    class Tur
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public ICollection<OyunTur> OyunTurleri { get; set; }
    }
}
