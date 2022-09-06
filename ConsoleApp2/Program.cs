using ConsoleApp2;

Console.WriteLine("Hello World");
var toDoItem = new ToDo();
toDoItem.Name = "ToDoItem1";
toDoItem.Description = "Description";
toDoItem.Date = DateTime.Now;

Console.WriteLine(toDoItem.Name);
Console.WriteLine(toDoItem.Description);
Console.WriteLine(toDoItem.Date);