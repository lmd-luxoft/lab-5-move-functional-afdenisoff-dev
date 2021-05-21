// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace MovieRental
{
    public class NewReleaseMovie : Movie
    {
         public NewReleaseMovie(string title, int baseAmount)
            : base(title, baseAmount, true)
        {
        }

        public override void SetAmount(int daysRented)
        {
            Amount += daysRented * 3;
        }
    }
}