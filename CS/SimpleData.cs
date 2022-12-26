using System.Collections.ObjectModel;

namespace AutoPopulateColumns {
    public class Customer {
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class DataModel {
        public static ObservableCollection<Customer> GetCustomers() {
            ObservableCollection<Customer> people = new ObservableCollection<Customer>();
            people.Add(new Customer() { Name = "Gregory S. Price", City = "Hong Kong" });
            people.Add(new Customer() { Name = "Irma R. Marshall", City = "Madrid" });
            people.Add(new Customer() { Name = "John C. Powell", City = "Los Angeles" });
            people.Add(new Customer() { Name = "Christian P. Laclair", City = "London" });
            people.Add(new Customer() { Name = "Karen J. Kelly", City = "Hong Kong" });
            people.Add(new Customer() { Name = "Brian C. Cowling", City = "Los Angeles" });
            people.Add(new Customer() { Name = "Thomas C. Dawson", City = "Madrid" });
            people.Add(new Customer() { Name = "Angel M. Wilson", City = "Los Angeles" });
            people.Add(new Customer() { Name = "Winston C. Smith", City = "London" });
            people.Add(new Customer() { Name = "Harold S. Brandes", City = "Bangkok" });
            people.Add(new Customer() { Name = "Michael S. Blevins", City = "Hong Kong" });
            people.Add(new Customer() { Name = "Jan K. Sisk", City = "Bangkok" });
            people.Add(new Customer() { Name = "Sidney L. Holder", City = "London" });
            return people;
        }
    }
}
