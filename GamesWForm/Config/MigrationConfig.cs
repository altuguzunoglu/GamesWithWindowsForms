using GamesWForm.Context;
using GamesWForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesWForm.Config
{
    class MigrationConfig
    {
        public static void Seed(OyunlarContext context, bool deleteFromTables = true)
        {
            if (deleteFromTables)
            {
                context.Database.ExecuteSqlCommand("delete from [OyunTur]");
                context.Database.ExecuteSqlCommand("delete from [Tur]");
                context.Database.ExecuteSqlCommand("delete from [Oyun]");
                context.Database.ExecuteSqlCommand("delete from [Yil]");
            }

            List<Yil> yilList = new List<Yil>()
            {
                new Yil()
                {
                    Id = 1, Degeri = "2015", Oyunlar = new List<Oyun>()
                },
                new Yil()
                {
                    Id = 2, Degeri = "2016", Oyunlar = new List<Oyun>()
                },
                new Yil()
                {
                    Id = 3, Degeri = "2017", Oyunlar = new List<Oyun>()
                },
                new Yil()
                {
                    Id = 4, Degeri = "2018", Oyunlar = new List<Oyun>()
                },
                new Yil()
                {
                    Id = 5, Degeri = "2019", Oyunlar = new List<Oyun>()
                }
            };

            List<Oyun> oyunList = new List<Oyun>()
            {
                new Oyun()
                {
                    Id = 1, Adi = "GTA5", Maliyeti = 1000000.0000, Kazanci = 2000000.0000, YilId = 1
                },
                new Oyun()
                {
                    Id = 2, Adi = "Doom", Maliyeti = 500000.0000, Kazanci = 300000.0000, YilId = 2
                },
                new Oyun()
                {
                    Id = 3, Adi = "Dishonored", Maliyeti = 100000.0000, Kazanci = 300000.0000, YilId = 4
                }
            };

            foreach (var yil in yilList)
            {
                var oyunlar = oyunList.Where(e => e.YilId == yil.Id).ToList();
                foreach (var oyun in oyunlar)
                {
                    yil.Oyunlar.Add(oyun);
                }
            }

            List<Tur> turList = new List<Tur>()
            {
                new Tur()
                {
                    Id = 1, Adi = "FPS", OyunTurleri = new List<OyunTur>()
                },
                new Tur()
                {
                    Id = 2, Adi = "RPG", OyunTurleri = new List<OyunTur>()
                },
                new Tur()
                {
                    Id = 3, Adi = "Open World", OyunTurleri = new List<OyunTur>()
                }
            };

            List<OyunTur> oyunTurList = new List<OyunTur>()
            {
                new OyunTur()
                {
                    Id = 1, OyunId = 1, TurId = 1
                },
                new OyunTur()
                {
                    Id = 2, OyunId = 1, TurId = 2
                },
                new OyunTur()
                {
                    Id = 3, OyunId = 1, TurId = 3
                },
                new OyunTur()
                {
                    Id = 4, OyunId = 2, TurId = 1
                },
                new OyunTur()
                {
                    Id = 5, OyunId = 3, TurId = 1
                },
                new OyunTur()
                {
                    Id = 6, OyunId = 3, TurId = 2
                }
            };
            foreach (var tur in turList)
            {
                var oyunTurler = oyunTurList.Where(e => e.TurId == tur.Id).ToList();
                foreach (var oyunTur in oyunTurler)
                {
                    tur.OyunTurleri.Add(oyunTur);
                }
            }
            // context update:
            foreach (var yil in yilList)
            {
                context.Yillar.Add(new Yil()
                {
                    Degeri = yil.Degeri,
                    Oyunlar = yil.Oyunlar
                });
            }

            foreach (var tur in turList)
            {
                context.Turler.Add(new Tur()
                {
                    Adi = tur.Adi,
                    OyunTurleri = tur.OyunTurleri
               });
            }
        }
    }
}
