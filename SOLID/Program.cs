using SOLID.SOLID;

#region SRP Section
/*
var userRepository = new UserRepository();
var userActions = new UserActions();

//User1
User user = new() { id = 1, username = "enes", password = "111" };
userRepository.Add(user);
userActions.Login(user);

//User2
User user2 = new() { id = 2, username = "ahmet", password = "222" };
userRepository.Add(user2);
userActions.Login(user2);

//User3
User user3 = new() { id = 3, username = "mehmet", password = "333" };
userRepository.Add(user3);
userActions.Login(user3);

//Users Info's writing console
var userPresenter = new UserPresenter();
Console.WriteLine("-----------------------------");
userPresenter.WriteUserInfo(userRepository.Users);
Console.WriteLine("-----------------------------");

//Users log out
foreach (var usr in userRepository.Users)
{
    userActions.Logout(usr);
}
*/
#endregion

#region OCP Section
/*
LoggerBLL logger = new LoggerBLL(new FileLogger());//or "new DBLogger()"
logger.WriteLog();
*/
#endregion

#region LSP Section
/*
Tofas tofas = new();
tofas.Start();
tofas.GearUp();
tofas.GearDown();

Console.WriteLine("---------------------------");

Tesla tesla = new();
tesla.Start();
//Can't reach no more manuel functions
*/
#endregion

#region ISP Section
/*
EmployeeRepository employeeRepository = new();

Employee employee = new Employee() { Id=1,Name="Enes"};
employeeRepository.Add(employee);

Employee employee2 = new Employee() { Id=2,Name="Ahmet"};
employeeRepository.Add(employee2);

Employee employee3 = new Employee() { Id=3,Name="Mehmet"};
employeeRepository.Add(employee3);

employeeRepository.GetAll().ForEach(e =>
{
    Console.WriteLine($"{e.Id} | Employee Name: " + e.Name);
});

Console.WriteLine("---------------------------");

employeeRepository.Update(2, new() { Id = 2, Name = "Fatih" });
employeeRepository.Delete(1);

employeeRepository.GetAll().ForEach(e =>
{
    Console.WriteLine($"{e.Id} | Employee Name: " + e.Name);
});
*/
#endregion

#region DIP Section
/*
var subscriptionManager = new SubscriptionManager(new Bloomberg());//or "new NYTimes()"
subscriptionManager.SendNewspaper();
*/
#endregion