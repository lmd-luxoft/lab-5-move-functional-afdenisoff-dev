// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

namespace MovieRental
{
    public class ChildrenMovie : Movie
    {
        public ChildrenMovie(string title, int baseAmount)
           : base(title, baseAmount, false)
        {
        }

        public override void SetAmount(int daysRented)
        {
            if (daysRented > Rental.ChildrenBaseRentalDays)
                Amount += (daysRented - Rental.ChildrenBaseRentalDays) * 15;
        }
    }
}