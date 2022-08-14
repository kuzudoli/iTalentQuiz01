using Abstraction_Polymorphism_Interface_Encapsulation;

#region Abstraction Section
/*
List<Employee> employees = new();
List<Manager> managers = new();

Employee e1 = new() { Id = 1, Name = "Enes Cakir", Salary = 5500 };
Employee e2 = new() { Id = 2, Name = "Ahmet Gündüz", Salary = 5500 };

employees.Add(e1);
employees.Add(e2);

Manager m1 = new() { Id = 1, Name = "Hüsnü Çoban", Salary = 12500 };
Manager m2 = new() { Id = 2, Name = "İlkkan Yılmaz", Salary = 12500 };

managers.Add(m1);
managers.Add(m2);

Console.WriteLine("=============Employees================\n");
employees.ForEach(e =>
{
    Console.WriteLine($"ID: {e.Id} | {e.Name} | {e.Salary}");
});

Console.WriteLine("\n=============Managers================\n");
managers.ForEach(m =>
{
    Console.WriteLine($"ID: {m.Id} | {m.Name} | {m.Salary}");
});

Console.WriteLine("\n=====================================\n");

m1.SignDocument();

e2.CountStock();
*/
#endregion

#region Polymorphism Section
/*
Player player = new() { Id=1, Nickname="enesckr28"};
GameManager gm = new() { Id = 1, Nickname = "[GM]kuzudoli" }; 

Console.WriteLine($"Nickname: {player.Nickname}| Level: {player.Level} | Power: {player.PowerCalculation()}\n");
Console.WriteLine($"Nickname: {gm.Nickname}| Level: {gm.Level} | Power: {gm.PowerCalculation()}");
*/
#endregion

#region Interface Section
/*
BLL bll = new(new SQLRepository());
bll.Create();
bll.Update();
bll.Read();
bll.Delete();

Console.WriteLine("===================================");

bll = new(new MongoDBRepository());
bll.Create();
bll.Update();
bll.Read();
bll.Delete();
*/
#endregion

#region Encapsulation Section
/*
User user1 = new() { name = "Ahmet", Gender = true };
User user2 = new() { name = "Leyla", Gender = false };

Console.WriteLine(user1.name);
Console.WriteLine(user2.name);
*/
#endregion