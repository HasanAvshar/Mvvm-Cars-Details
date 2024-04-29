using MvvmLesson.Models;
using System.Collections.ObjectModel;

namespace MvvmLesson.DataBases;

public static class CarDataBase
{
    public static ObservableCollection<Car>? CarsDB { get; set; } = new ObservableCollection<Car>();
    public static ObservableCollection<Person>? SellersDB { get; set; } = new ObservableCollection<Person>();

    static CarDataBase()
    {
        SellersDB = new ObservableCollection<Person>
        {
            new Person { Name = "Mark", Surname = "Zuckerberg", Age = 36 },
            new Person { Name = "Larry", Surname = "Ellison", Age = 76 },
            new Person { Name = "Michael", Surname = "Dell", Age = 55 },
            new Person { Name = "Steve", Surname = "Jobs", Age = 56 },
        };
    }
}
