using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWForm.Entities
{
    class OyunTur
    {
        public int Id { get; set; }
        public int OyunId { get; set; }
        public int TurId { get; set; }
        public Oyun Oyun { get; set; }
        public Tur Tur { get; set; }
    }
}
