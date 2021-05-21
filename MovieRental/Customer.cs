// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRental
{
    public class Customer
    {
        private readonly List<Rental> rentals = new List<Rental>();

        internal string Name { get; }

        internal Customer(string name)
        {
            Name = name;
        }

        internal void AddRental(Rental rental)
        {
           rentals.Add(rental);
        }

        internal string Statement()
        {
            StringBuilder report = new StringBuilder();
            report.Append($"учет аренды для {Name}\n");
            
            double totalAmount = rentals.Select(r => 
            {
                r.SetAmount();
                report.Append($"\t{r.Movie}\t{r.Amount}\n");
                return r.Amount;
            }).Sum();

            //добавить очки для активного арендатора
            int frequentRenterPoints = rentals.Count;
            
            //бонус за аренду новинки на два дня
            frequentRenterPoints += rentals.Where(r => r.IsBonused && r.DaysRental > 1).Count();

            report.Append($"Сумма задолженности составляет {totalAmount}\nВы заработали {frequentRenterPoints} очков за активность");
            return report.ToString();
        }
    }
}