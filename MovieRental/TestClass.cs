// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace MovieRental
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void NameFilmShouldBeCorrect()
        {
	        var movie = new ChildrenMovie("Rio2", Rental.ChildrenBaseAmount);
            Assert.AreEqual("Rio2", movie.Title);
        }

        [Test]
        public void RentalShouldBeCorrectMovie()
        {
            var movie = new RegularMovie("Angry Birds", Rental.RegularBaseAmount);
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(movie, rental.Movie);
        }
        [Test]
        public void RentalShouldBeCorrectDayRented()
        {
            var movie = new RegularMovie("Angry Birds", Rental.RegularBaseAmount);
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(20, rental.DaysRental);
        }
        [Test]
        public void CustomerShouldBeCorrectName()
        {
            Customer customer = new Customer("Bug");
            Assert.AreEqual("Bug", customer.Name);
        }
        [Test]
        public void CustomerCreateCorrectStatement()
        {
            Customer customer = new Customer("Bug");
            var movie1 = new ChildrenMovie("Angry Birds", Rental.ChildrenBaseAmount);
            Rental rental1 = new Rental(movie1, 2);
            customer.AddRental(rental1);

	        var movie2 = new NewReleaseMovie("StarWar",Rental.NewReleaseBaseAmount);
            Rental rental2 = new Rental(movie2, 10);
            customer.AddRental(rental2);

	        var movie3 = new RegularMovie("Hatico", Rental.RegularBaseAmount);
            Rental rental3 = new Rental(movie3, 4);
            customer.AddRental(rental3);

        string actual = customer.Statement();
        Assert.AreEqual("учет аренды для Bug\n\tAngry Birds\t15\n\tStarWar\t30\n\tHatico\t32\nСумма задолженности составляет 77\nВы заработали 4 очков за активность", actual);
    }
}
}
