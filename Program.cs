// See https://aka.ms/new-console-template for more information

using C_11PdfBookTryOuts.ch5;

Console.WriteLine("Hello, World!");
ch5MethodsTryouts();

void ch5MethodsTryouts()
{
    // Create two PersonCh5 objects
    PersonCh5 person1 = new PersonCh5("John Doe", "Mars");
    PersonCh5 person2 = new PersonCh5("Jane Doe", "Venus");

    // Use the static Marry method to marry person1 and person2
    PersonCh5.Marry(person1, person2);

    // Use the instance Marry method to verify the marriage
    person1.Marry(person2);

    // Print the marital status and spouse details
    Console.WriteLine($"Person1: {person1.Name}, Married: {person1.Married}, Spouse: {(person1.Spouse?.Name ?? "None")}");
    Console.WriteLine($"Person2: {person2.Name}, Married: {person2.Married}, Spouse: {(person2.Spouse?.Name ?? "None")}");
}