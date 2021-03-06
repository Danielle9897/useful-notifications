﻿using CoreDdd.Domain;
using UsefulNotifications.Shared.FilmsWithGoodRatingNotifications;

namespace UsefulNotifications.Domain.FilmsWithGoodRatingNotifications
{
    public class FilmRating : Entity
    {
        protected FilmRating() {}

        public FilmRating(Film film, FilmRatingArgs filmRatingArgs)
        {
            Film = film;
            Source = filmRatingArgs.Source;
            Rating = filmRatingArgs.Rating;
            Url = filmRatingArgs.Url;
        }

        public virtual Film Film { get; protected set; }
        public virtual RatingSource Source { get; protected set; }
        public virtual decimal Rating { get; protected set; }
        public virtual string Url { get; protected set; }
    }
}