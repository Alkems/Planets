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
                Description = "Mercury is the smallest planet (CAP, its pretty huge) in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest (Its not about the time, its about the flow) of all the Sun's planets.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMercury_%2528planet%2529&psig=AOvVaw0O8-GYqbAN0sJQrukfzbGe&ust=1680003136936000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCOiz5sWB_P0CFQAAAAAdAAAAABAI",
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
                    "https://www.google.com/url?sa=i&url=https%3A%2F%2Fphys.org%2Fnews%2F2022-12-venus-earth-like-lithospheric-thickness.html&psig=AOvVaw2yn1AapaDz2rjZrrYorzdJ&ust=1680183346110000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCPDtiPGggf4CFQAAAAAdAAAAABAD",
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
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778",
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
                Description = "Saturn on kuues planeet Päikesest ja Päikesesüsteemi suuruselt teine planeet. See on hiidplaneet, mis on Maast üheksa korda suurema läbimõõduga.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
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
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"

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
