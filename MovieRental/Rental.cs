// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace MovieRental
{
    internal class Rental
    {
        internal const int ChildrenBaseAmount = 15;
        internal const int ChildrenBaseRentalDays = 3;
        
        internal const int RegularBaseAmount = 2;
        internal const int RegularBaseRentalDays = 2;

        internal const int NewReleaseBaseAmount = 0;

        internal Movie Movie { get; }
        internal int DaysRental { get; }

        public Rental(Movie movie, int daysRental)
        {
            Movie = movie;
            DaysRental = daysRental;
        }

        public void SetAmount() => Movie.SetAmount(DaysRental);

        public int Amount => Movie.Amount;

        public bool IsBonused => Movie.IsBonused;
    }
}