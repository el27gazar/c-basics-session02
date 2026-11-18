using System.Drawing;
using System.Runtime.Intrinsics.X86;
using CApp_1;

#region Question 1
// Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in avariable of type object. Print it.

//Book book1 = new Book();
//book1.Tittle = "elbutcher";
//book1.Pages = 300;
//Console.WriteLine(book1);

#endregion

#region Question 2
//Using the Book class above, print the result of calling ToString(), Equals() (compare book with
//itself), GetHashCode(), and GetType() on book.

//Book book1 = new Book() { Title = "superman", Pages = 180 };
//Book book2 = new Book() { Title = "batman", Pages = 260 };

//Console.WriteLine(book1.ToString());
//Console.WriteLine(book1.GetType());
//Console.WriteLine(book2.Equals(book1));
//Console.WriteLine(book1.GetHashCode());

#endregion

#region Question 3
//Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
//int pages = "464";

//int pages = int.Parse("464");
//Console.WriteLine(pages);
#endregion

#region Question 4
//Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
//zero", and then prints "Done" in a finally block.
//int number = 10;
//try
//{
//    int result = number / 0;
//}
//catch (Exception ex)
//{
//    Console.WriteLine( ex.Message);
//}
//finally
//{
//    Console.WriteLine("Done");
//}
#endregion

#region Question 5
//Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
//int pages = 300;
//double pagesDouble = pages;
//Console.WriteLine(pagesDouble);
#endregion

#region Question 6
//Declare a double price = 49.99; then convert it into an int using a cast.

//double price = 49.99;
////int priceInt = int.Parse(price.ToString());
//int priceInt = (int)price;
//Console.WriteLine(priceInt);

#endregion

#region Question 7
// Given string pagesText = "464";, convert it into an int using the Convert class
//string pagesText = "464";
//int pages = Convert.ToInt32(pagesText);
//Console.WriteLine(pages);
#endregion

#region Question 8
//Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
//use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
//string yearText = "2023";
//int year = int.Parse(yearText);
//string badText = "abc";
//int badNumber = int.TryParse(badText, out int result) ? result : throw new FormatException("Invalid number");
//Console.WriteLine(badNumber);
//Console.WriteLine(year);
#endregion

#region Question 9

//Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
//to prove it's now a string.

//int pages = 464;
//string pagesString = pages.ToString();
//Console.WriteLine(pagesString);
//Console.WriteLine(pagesString.GetType());
#endregion

#region Question 10
//Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
//variable, and print both.

//int copies = 100;
//object copiesObject = copies;
//int copiesUnboxed = (int)copiesObject;
//Console.WriteLine(copiesObject);
//Console.WriteLine(copiesUnboxed);
#endregion

#region Question 11
//Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value

//int? year = null;
//Console.WriteLine(year.HasValue);
//year = 2023;
//Console.WriteLine(year);

#endregion

#region Question 12
//Q12. Declare a string? reviewer = null;. Print whether it is null.

//string? reviewer = null;
//Console.WriteLine(reviewer is not null);
////Console.WriteLine(reviewer is null);
////Console.WriteLine(reviewer == null);
#endregion

#region Question 13
//Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
//print the result.

//Book? book = null;

//string? title = book?.Title;

//Console.WriteLine(title);

#endregion

#region Question 14
//Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to
//assign title the value "Untitled" only if it's still null
//Book? book = null;
//string? title = book?.Title ?? "Untitled";
//Console.WriteLine(title);
#endregion

#region Question 15
//Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
//confirmedName using the ! operator.

 //string? name = "Ahmed";
  string name = "Ahmed";
string confirmedName = name!;
Console.WriteLine(confirmedName);

#endregion