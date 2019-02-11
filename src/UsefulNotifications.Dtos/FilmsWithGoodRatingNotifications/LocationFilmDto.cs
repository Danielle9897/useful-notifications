﻿using System.Collections.Generic;

namespace UsefulNotifications.Dtos.FilmsWithGoodRatingNotifications
{
    public class LocationFilmDto
    {
        public int Id { get; set; }
        public int LocationId { get; set; }

        public string FilmName { get; set; }
        public string FilmMainUrl { get; set; }
        public IEnumerable<FilmRatingDto> Ratings { get; set; }
        public IEnumerable<LocationFilmCinemaDto> Cinemas { get; set; }
    }
}