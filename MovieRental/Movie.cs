// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace MovieRental
{
    public abstract class Movie
    {
        public bool IsBonused { get; }

        public int Amount { get; protected set; }

        public string Title { get; }

        public Movie(string title, int baseAmount, bool isBonused)
        {
            Title = title;
            Amount = baseAmount;
            IsBonused = isBonused;
        }

        public abstract void SetAmount(int daysRented);

        public override string ToString()
        {
            return Title;
        }
    }
}