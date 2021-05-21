// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

namespace MovieRental
{
    public class RegularMovie : Movie
    {
        public RegularMovie(string title, int baseAmount)
           : base(title, baseAmount, false)
        {
        }

        public override void SetAmount(int daysRented)
        {
            if (daysRented > Rental.RegularBaseRentalDays)
                Amount += (daysRented - Rental.RegularBaseRentalDays) * 15;
        }
    }
}