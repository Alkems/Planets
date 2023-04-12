using SolarPlanets.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Microsoft.Maui.Graphics.Color;

namespace Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "  Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "Mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg"

                }

            },

            new()
            {
                Name = "  Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is sometimes called Earth's \"sister\" or \"twin\" planet as it is almost as large and has a similar composition.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg"

                },

            },

            new()
            {
                Name = "  Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun. It is the only place that we know of that has life.",
                AccentColorStart = Color.FromArgb("#4BA1BC"),
                AccentColorEnd = Color.FromArgb("#4BA1BC"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"

                }

            },

            new()
            {
                Name = "  Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"

                }

            },

            new()
            {
                Name = "  Saturn",
                Subtitle = "The planet with a ring",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the sun and is the second largest. Saturn is 9 times the size of earth and has a ring around it.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#E2E263"),
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
                Name = "  Uranus",
                Subtitle = "The cold ball",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun, and has the third-largest diameter in our solar system.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"

                }

            },

            new()
            {
                Name = "  Neptune",
                Subtitle = "The furthest",
                HeroImage = "neptune.png",
                Description = "Neptune is dark, cold, and very windy. It's the last of the planets in our solar system. It's more than 30 times as far from the Sun as Earth is.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#4161FF"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"

                }

            },

            new()
            {
                Name = "  Pluto",
                Subtitle = "The forgotten child",
                HeroImage = "pluto.jpg",
                Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#7D4B19"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBam9GIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--41f1ace6d54260ea40a3ac78fa92e5d997c2dce5/pluto_natural_color_20150714_detail.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Internal_Structure_of_Pluto.jpg/1200px-Internal_Structure_of_Pluto.jpg",
                    "https://th-thumbnailer.cdn-si-edu.com/2pqnNiTDB4QXA4LGt9dzZj6wyS4=/fit-in/1600x0/https://tf-cmsv2-smithsonianmag-media.s3.amazonaws.com/filer/9a/91/9a915e4d-0f04-4070-a23a-14acbf3351ed/jun2015_g01_pluto.jpg"

                }

            },

            new()
            {
                Name = "  Ceres",
                Subtitle = "The smallest dwarf",
                HeroImage = "ceres.jpg",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. Classified as a dwarf planet in 2006.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#FFFFFF"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://f11.pmo.ee/uIZrrmNtBz79aVdPeYNYMymFCI0=/685x0/nginx/o/2015/01/21/3697789t1h6092.jpg",
                    "https://media-cldnry.s-nbcnews.com/image/upload/t_fit-760w,f_auto,q_auto:best/MSNBC/Components/Photo/_new/090305_ceres_layer_02.jpg"

                }

            },

            new()
            {
                Name = "  Makemake",
                Subtitle = "The red dwarf",
                HeroImage = "makemake.jpg",
                Description = "Makemake is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdGdRIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--bafc1c2e2e76668d8d156de3505a8f7e472e790a/makemake_th.jpg",
                    "https://cdn.eso.org/images/screen/eso1246a.jpg"

                }

            },

            new()
            {
                Name = "  Haumea",
                Subtitle = "The oval dwarf",
                HeroImage = "haumea.jpg",
                Description = "Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#FFFFFF"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Haumea%2C_Celestia.jpg/800px-Haumea%2C_Celestia.jpg",
                    "https://cdn.sci.news/images/enlarge10/image_11303e-Haumea.jpg"

                }

            },

            new()
            {
                Name = "  Eris",
                Subtitle = "The largest dwarf",
                HeroImage = "eris.png",
                Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/d/d4/Artist%27s_impression_dwarf_planet_Eris.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/18/Artist%E2%80%99s_impression_of_the_dwarf_planet_Eris.jpg"

                }

            }


        };

        public static List<Planet> GetAllPlanets()
            => planets;

        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizePlanets = planets.OrderBy(ItemDelegateList => rnd.Next());

            return randomizePlanets.Take(2).ToList();
        }
    }
}
