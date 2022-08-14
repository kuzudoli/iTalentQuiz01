#region Dictionary Section
/*
Dictionary<string, string> commands = new();

//Create
commands.Add("/login", "Login command executed!");
commands.Add("/register", "Register command executed");
commands.Add("/logout", "..... command executed!");
commands.Add("/extra", "Extra command executed!");

foreach(var cmd in commands)
{
    Console.WriteLine($"Command: '{cmd.Key}' | Message: {cmd.Value}");
}

Console.WriteLine("==============================================================");

//Read
var registerCmd = commands.First(c => c.Key == "/register");
Console.WriteLine($"Command: '{registerCmd.Key}' | Message: {registerCmd.Value}");

Console.WriteLine("==============================================================");

//Update
commands["/logout"] = "Logout command executed!";

//Delete
commands.Remove("/extra");

foreach (var cmd in commands)
{
    Console.WriteLine($"Command: '{cmd.Key}' | Message: {cmd.Value}");
}
*/
#endregion

#region List Section
/*
List<string> players = new();

//Create
players.Add("enes");
players.Add("ahmet");
players.Add("mehmet");
players.Add("fatih");

foreach (var p in players)
{
    Console.WriteLine($"Player: {p}");
}

Console.WriteLine("=========================");

//Read
var player = players.Find(p => p.Equals("ahmet"));
Console.WriteLine($"Player: {player}");

Console.WriteLine("=========================");

//Update
var updateIndex = players.FindIndex(p => p.Equals("mehmet"));
players[updateIndex] = "mahmut";

//Delete
players.Remove("fatih");

foreach (var p in players)
{
    Console.WriteLine($"Player: {p}");
}
*/
#endregion

#region Queue Section
/*
Queue<string> queue = new();

//Create
queue.Enqueue("enes");
queue.Enqueue("ahmet");
queue.Enqueue("mehmet");
queue.Enqueue("fatih");

foreach (var q in queue)
{
    Console.WriteLine($"Waiters: {q}");
}

Console.WriteLine("=========================");

//Read
var waiter = queue.First();
Console.WriteLine($"Waiter: {waiter}");

Console.WriteLine("=========================");

//Update
//It doesn't include update function

//Delete
queue.Dequeue();

foreach (var q in queue)
{
    Console.WriteLine($"Waiter: {q}");
}
*/
#endregion

#region Sorted List Section
/*
SortedList<string, string> commands = new();

//Create
commands.Add("/login", "Login command executed!");
commands.Add("/register", "Register command executed");
commands.Add("/logout", "..... command executed!");
commands.Add("/extra", "Extra command executed!");

foreach (var cmd in commands)
{
    Console.WriteLine($"Command: '{cmd.Key}' | Message: {cmd.Value}");
}

Console.WriteLine("==============================================================");

//Read
var registerCmd = commands.First(c => c.Key == "/register");
Console.WriteLine($"Command: '{registerCmd.Key}' | Message: {registerCmd.Value}");

Console.WriteLine("==============================================================");

//Update
commands["/logout"] = "Logout command executed!";

//Delete
commands.Remove("/extra");

foreach (var cmd in commands)
{
    Console.WriteLine($"Command: '{cmd.Key}' | Message: {cmd.Value}");
}
*/
#endregion

#region Stack Section
/*
Stack<string> processStack = new();

//Create
processStack.Push("/delete");
processStack.Push("/update");
processStack.Push("/read");
processStack.Push("/create");

foreach (var p in processStack)
{
    Console.WriteLine($"Process: {p}");
}

Console.WriteLine("=========================");

//Read
var process = processStack.Peek();
Console.WriteLine($"Top of the stack: {process}");

Console.WriteLine("=========================");

//Update
//

//Delete
processStack.Pop();

foreach (var p in processStack)
{
    Console.WriteLine($"Process: {p}");
}
*/
#endregion