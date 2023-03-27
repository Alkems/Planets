﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
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

            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizePlanets = planets.OrderBy(ItemDelegateList => rnd.Next());

            return randomizePlanets.Take(2).ToList();
        }
    }
}