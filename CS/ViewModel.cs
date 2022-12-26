using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace AutoPopulateColumns {
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Source = DataModel.GetCustomers();
        }
        public ObservableCollection<Customer> Source { get; }
    }
}
