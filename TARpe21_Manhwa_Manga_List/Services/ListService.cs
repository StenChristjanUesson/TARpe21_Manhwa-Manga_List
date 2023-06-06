
namespace TARpe21_Manhwa_Manga_List.Services
{
    internal static class ListService
    {
        private static List<ManhwaList> Manga = new()
        {
            new()
            {
                Name = " Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg"
                }
            },

            new()
            {
                Name = " Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Off all the planets, Venus is the most similar to Earth. In fact, venus is often  called Earth's sister planet. As similar as it in some ways, however, it is also very different in others.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = " Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only place known in the universe where life has originated and found habitability. While Earth may not contain the largest volumes of water in the Solar System, only Earth sustains liquid surface water, extending over 70.8% of the Earth with its ocean, making Earth an ocean world.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = " Mars",
                Subtitle = "  The red beauty",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, larger only than Mercury. In the English language, Mars is named for the Roman god of war. Mars is a terrestrial planet with a thin atmosphere and has a crust primarily composed of elements similar to Earth's crust, as well as a core made of iron and nickel.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = " Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius of about nine and a half times that of Earth.[23][24] It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The cold ball",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is named after Greek sky deity Uranus (Caelus), who in Greek mythology is the father of Cronus (Saturn), a grandfather of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus has the third-largest planetary radius and fourth-largest planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and the farthest known planet in the Solar System. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth, and slightly more massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Pluto",
                Subtitle = "  The Goofys best friend",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. There may be millions of these icy objects, collectively referred to as Kuiper Belt objects (KBOs) or trans-Neptunian objects (TNOs), in this distant region of our solar system.",
                AccentColorStart = Color.FromArgb("#894848"),
                AccentColorEnd = Color.FromArgb("#BF7A7A"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/krunmaculaunannotated2.jpg",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/nh-pluto-charon-v2-10-1-15.jpg",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/tn-p_lorri_fullframe_color.jpg"
                }
            },

            new()
            {
                Name = " Ceres",
                Subtitle = "  The first dwarf planet",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801.",
                AccentColorStart = Color.FromArgb("#894848"),
                AccentColorEnd = Color.FromArgb("#BF7A7A"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/krunmaculaunannotated2.jpg",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/nh-pluto-charon-v2-10-1-15.jpg",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/tn-p_lorri_fullframe_color.jpg"
                }
            },

            new()
            {
                Name = " Haumea",
                Subtitle = "  The fast spinner",
                HeroImage = "haumea.png",
                Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. The other known dwarf planets in the Kuiper Belt are Pluto, Eris, and Makemake (dwarf planet Ceres is located in the main asteroid belt between Mars and Jupiter).",
                AccentColorStart = Color.FromArgb("#894848"),
                AccentColorEnd = Color.FromArgb("#BF7A7A"),
                Images = new()
                {
                    "",
                    "",
                    ""
                }
            },

            new()
            {
                Name = " Eris",
                Subtitle = "  The largest dwarfplanet",
                HeroImage = "eris.jpg",
                Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.\r\n\r\nAt first, Eris appeared to be larger than Pluto. This triggered a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet.",
                AccentColorStart = Color.FromArgb("#894848"),
                AccentColorEnd = Color.FromArgb("#BF7A7A"),
                Images = new()
                {
                    "",
                    "",
                    ""
                }
            },

        };

        public static List<ManhwaList> GetAllManhwaLists()
            => ManhwaLists;


        public static List<ManhwaList> GetFeaturedManhwa()
        {
            var rnd = new Random();
            var randomizedManwha = ManhwaLists.OrderBy(item => rnd.Next());

            return randomizedManwha.Take(2).ToList();
        }
    }
}