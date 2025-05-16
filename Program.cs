// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Thomas";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine("The lyrics contain the word goodbye:" + songLyrics.Contains("goodbye"));
Console.WriteLine("The lyrics contain the word greeting:" + songLyrics.Contains("greetings"));

//Challenge
Console.WriteLine("");
Console.WriteLine("They lyrics to a song are:  " + songLyrics);
Console.WriteLine("The lyrics start with You: " + songLyrics.StartsWith("You"));
Console.WriteLine("The lyrics start with goodbye: " + songLyrics.StartsWith("goodbye"));
Console.WriteLine("The lyrics end with hello: " + songLyrics.EndsWith("hello"));
Console.WriteLine("The lyrics end with goodbye: " + songLyrics.EndsWith("goodbye"));