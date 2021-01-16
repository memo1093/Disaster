using System.Linq;
using disaster.entity;
using Microsoft.EntityFrameworkCore;

namespace disaster.data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {

            using (var context = new DisasterContext())
            {
                if (context.Database.GetPendingMigrations().Count() == 0)
                {

                    if (context.Cities.Count()<=0)
                    {
                        context.Cities.AddRange(cities);
                    }
                    if (context.Towns.Count()<=0)
                    {
                        context.Towns.AddRange(towns);
                    }
                   
                    
                    context.SaveChanges();


                };
            }
        }



        private static City[] cities =
            {
                new City(){CityId=1,CityName="Adana"},
                new City(){CityId=2,CityName="Adıyaman"},
                new City(){CityId=3,CityName="Afyon"},
                new City(){CityId=4,CityName="Ağrı"},
                new City(){CityId=5,CityName="Amasya"},
                new City(){CityId=6,CityName="Ankara"},

            };


        private static Town[] towns =
            {
                new Town(){TownId=1,TownName="Aladağ",CityId=1,Latitute=37.549481310676086f,Longtitute=35.39337166632859f},
                new Town(){TownId=2,TownName="Ceyhan",CityId=1,Latitute=37.02976104489356f,Longtitute=35.82037382423658f},
                new Town(){TownId=3,TownName="Çukurova",CityId=1,Latitute=37.08954509927653f,Longtitute=35.15016549065883f},
                new Town(){TownId=4,TownName="Feke",CityId=1,Latitute=37.870989585778844f,Longtitute=35.81960780928776f},
                new Town(){TownId=5,TownName="İmamoğlu",CityId=1,Latitute=37.25745279405041f,Longtitute=35.65970906111409f},
                new Town(){TownId=6,TownName="Karaisalı",CityId=1,Latitute=37.253444893932276f,Longtitute=35.06268893493973f},
                new Town(){TownId=7,TownName="Karataş",CityId=1,Latitute=36.564720375253216f,Longtitute=35.38181439026124f},
                new Town(){TownId=8,TownName="Kozan",CityId=1,Latitute=37.455742716018904f,Longtitute=35.81415875473833f},
                new Town(){TownId=9,TownName="Pozantı",CityId=1,Latitute=37.42894928571211f,Longtitute=34.87337084142227f},
                new Town(){TownId=10,TownName="Saimbeyli",CityId=1,Latitute=37.98693340782328f,Longtitute=36.09079995323518f},
                new Town(){TownId=11,TownName="Sarıçam",CityId=1,Latitute=37.14976492613003f, Longtitute=35.50993871440443f},
                new Town(){TownId=12,TownName="Seyhan",CityId=1,Latitute=37.028389f,Longtitute=35.267200f},
                new Town(){TownId=13,TownName="Tufanbeyli",CityId=1,Latitute=38.26135164442713f,Longtitute=36.219645910298176f},
                new Town(){TownId=14,TownName="Yumurtalık",CityId=1,Latitute=36.76742291051409f,Longtitute=35.72991706959384f},
                new Town(){TownId=15,TownName="Yüreğir",CityId=1,Latitute=36.87016057723209f,Longtitute=35.452149499332286f},

                new Town(){TownId=16,TownName="Adıyaman",CityId=2,Latitute=37.76385252001859f,Longtitute=38.268015737962976f},
                new Town(){TownId=17,TownName="Besni",CityId=2,Latitute=37.6961961f,Longtitute=37.8485959f},
                new Town(){TownId=18,TownName="Çelikhan",CityId=2,Latitute=38.0585966f,Longtitute=38.015644f},
                new Town(){TownId=19,TownName="Gerger",CityId=2,Latitute=38.0272426f,Longtitute=39.0230163f},
                new Town(){TownId=20,TownName="Gölbaşı",CityId=2,Latitute=37.7855416f,Longtitute=37.6263408f},
                new Town(){TownId=21,TownName="Kahta",CityId=2,Latitute=37.7831226f,Longtitute=38.6070314f},
                new Town(){TownId=22,TownName="Samsat",CityId=2,Latitute=37.5785321f,Longtitute=38.4727177f},
                new Town(){TownId=23,TownName="Sincik",CityId=2,Latitute=38.0337154f,Longtitute=38.2969065f},
                new Town(){TownId=24,TownName="Tut",CityId=2,Latitute=37.8210208f,Longtitute=37.7940295f},

                new Town(){TownId=25,TownName="Afyonkarahisar",CityId=3,Latitute=38.7566529f,Longtitute=30.4849948f},
                new Town(){TownId=26,TownName="Başmakçı",CityId=3,Latitute=37.888169f,Longtitute=29.9889649f},
                new Town(){TownId=27,TownName="Bayat",CityId=3,Latitute=39.0097991f,Longtitute=30.7640261f},
                new Town(){TownId=28,TownName="Bolvadin",CityId=3,Latitute=38.7153197f,Longtitute=31.0194862f},
                new Town(){TownId=29,TownName="Çay",CityId=3,Latitute=38.5923364f,Longtitute=30.9900356f},
                new Town(){TownId=30,TownName="Çobanlar",CityId=3,Latitute=38.7008057f,Longtitute=30.7439082f},
                new Town(){TownId=31,TownName="Dazkırı",CityId=3,Latitute=37.9259465f,Longtitute=29.5198069f},
                new Town(){TownId=32,TownName="Dinar",CityId=3,Latitute=38.1520387f,Longtitute=29.7206658f},
                new Town(){TownId=33,TownName="Emirdağ",CityId=3,Latitute=39.0126422f,Longtitute=30.7853008f},
                new Town(){TownId=34,TownName="Evciler",CityId=3,Latitute=38.0389365f,Longtitute=29.8738874f},
                new Town(){TownId=35,TownName="Hocalar",CityId=3,Latitute=38.577949f,Longtitute=29.9580938f},
                new Town(){TownId=36,TownName="İhsaniye",CityId=3,Latitute=39.0290868f,Longtitute=30.4076052f},
                new Town(){TownId=37,TownName="İscehisar",CityId=3,Latitute=38.8623366f,Longtitute=30.7355429f},
                new Town(){TownId=38,TownName="Kızılören",CityId=3,Latitute=38.2703783f,Longtitute=30.0333015f},
                new Town(){TownId=39,TownName="Sandıklı",CityId=3,Latitute=38.4562243f,Longtitute=30.2509429f},
                new Town(){TownId=40,TownName="Sinanpaşa",CityId=3,Latitute=38.7442314f,Longtitute=30.2328212f},
                new Town(){TownId=41,TownName="Sultandağı",CityId=3,Latitute=38.5292567f,Longtitute=31.212239f},
                new Town(){TownId=42,TownName="Şuhut",CityId=3,Latitute=38.5331328f,Longtitute=30.5333539f},

                new Town(){TownId=43,TownName="Ağrı",CityId=4,Latitute=39.722084f,Longtitute=42.9651029f},
                new Town(){TownId=44,TownName="Diyadin",CityId=4,Latitute=39.5440164f,Longtitute=43.6368541f},
                new Town(){TownId=45,TownName="Doğubayazıt",CityId=4,Latitute=39.5551004f,Longtitute=44.0364135f},
                new Town(){TownId=46,TownName="Eleşkirt",CityId=4,Latitute=39.8019041f,Longtitute=42.660598f},
                new Town(){TownId=47,TownName="Hamur",CityId=4,Latitute=39.4954252f,Longtitute=42.799895f},
                new Town(){TownId=48,TownName="Patnos",CityId=4,Latitute=39.2328811f,Longtitute=42.82282f},
                new Town(){TownId=49,TownName="Taşlıçay",CityId=4,Latitute=39.6353082f,Longtitute=43.3674457f},
                new Town(){TownId=50,TownName="Tutak",CityId=4,Latitute=39.5439697f,Longtitute=42.7512769f},

                new Town(){TownId=51,TownName="Amasya",CityId=5,Latitute=40.6562878f,Longtitute=35.7870696f},
                new Town(){TownId=52,TownName="Göynücek",CityId=5,Latitute=40.3769895f,Longtitute=35.2732144f},
                new Town(){TownId=53,TownName="Gümüşhacıköy",CityId=5,Latitute=40.8762926f,Longtitute=35.1976039f},
                new Town(){TownId=54,TownName="Hamamözü",CityId=5,Latitute=40.7886468f,Longtitute=34.9404172f},
                new Town(){TownId=55,TownName="Merzifon",CityId=5,Latitute=40.8749941f,Longtitute=35.4222202f},
                new Town(){TownId=56,TownName="Suluova",CityId=5,Latitute=40.8416621f,Longtitute=35.6160671f},
                new Town(){TownId=57,TownName="Taşova",CityId=5,Latitute=40.7600292f,Longtitute=36.310533f},

                new Town(){TownId=58,TownName="Akyurt",CityId=6,Latitute=40.1253515f,Longtitute=32.8552016f},
                new Town(){TownId=59,TownName="Altındağ",CityId=6,Latitute=39.9929038f,Longtitute=32.8339427f},
                new Town(){TownId=60,TownName="Ayaş",CityId=6,Latitute=40.0262505f,Longtitute=31.9682652f},
                new Town(){TownId=61,TownName="Balâ",CityId=6,Latitute=39.5525252f,Longtitute=33.1109342f},
                new Town(){TownId=62,TownName="Beypazarı",CityId=6,Latitute=40.1624337f,Longtitute=31.8909752f},
                new Town(){TownId=63,TownName="Çamlıdere",CityId=6,Latitute=40.490784f,Longtitute=32.4644527f},
                new Town(){TownId=64,TownName="Çankaya",CityId=6,Latitute=39.7976893f,Longtitute=32.6025416f},
                new Town(){TownId=65,TownName="Çubuk",CityId=6,Latitute=40.2155977f,Longtitute=32.9967206f},
                new Town(){TownId=66,TownName="Elmadağ",CityId=6,Latitute=39.9210621f,Longtitute=33.2204049f},
                new Town(){TownId=67,TownName="Etimesgut",CityId=6,Latitute=39.8646861f,Longtitute=32.3598317f},
                new Town(){TownId=68,TownName="Evren",CityId=6,Latitute=39.0437519f,Longtitute=33.6291271f},
                new Town(){TownId=69,TownName="Gölbaşı",CityId=6,Latitute=39.7854257f,Longtitute=32.7698551f},
                new Town(){TownId=70,TownName="Güdül",CityId=6,Latitute=40.2122335f,Longtitute=32.231181f},
                new Town(){TownId=71,TownName="Haymana",CityId=6,Latitute=39.4352428f,Longtitute=32.4863203f},
                new Town(){TownId=72,TownName="Kalecik",CityId=6,Latitute=40.100805f,Longtitute=33.4006569f},
                new Town(){TownId=73,TownName="Kahramankazan",CityId=6,Latitute=40.2039406f,Longtitute=32.6667654f},
                new Town(){TownId=74,TownName="Keçiören",CityId=6,Latitute=40.0867034f,Longtitute=32.6802292f},
                new Town(){TownId=75,TownName="Kızılcahamam",CityId=6,Latitute=40.4724558f,Longtitute=32.6317709f},
                new Town(){TownId=76,TownName="Mamak",CityId=6,Latitute=39.9052561f,Longtitute=32.8816481f},
                new Town(){TownId=77,TownName="Nallıhan",CityId=6,Latitute=40.1829578f,Longtitute=31.3103781f},
                new Town(){TownId=78,TownName="Polatlı",CityId=6,Latitute=39.5786154f,Longtitute=32.1030401f},
                new Town(){TownId=79,TownName="Pursaklar",CityId=6,Latitute=40.0369809f,Longtitute=32.8670467f},
                new Town(){TownId=80,TownName="Sincan",CityId=6,Latitute=39.8886973f,Longtitute=32.1397521f},
                new Town(){TownId=81,TownName="Şereflikoçhisar",CityId=6,Latitute=38.9375841f,Longtitute=33.5111886f},
                new Town(){TownId=82,TownName="Yenimahalle",CityId=6,Latitute=40.0081747f,Longtitute=32.5650777f},


            };

    }
}