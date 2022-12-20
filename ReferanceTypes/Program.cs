// See https://aka.ms/new-console-template for more information
int sayi1 = 10;
int sayi2 = 20;

////nt-decimal-float-enum-boolen = value typedır.
sayi1 = sayi2;

sayi2 = 100;

Console.WriteLine("sayi1 : " + sayi1);


////array-class-interface... = referans type
int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;
sayilar2[0] = 1000;

Console.WriteLine("sayilar1[0] : " + sayilar1[0]);


Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Engin";

person2 = person1;
Console.WriteLine(person2.FirstName);

person1.FirstName = "Büşra";
Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "Yaser";
Console.WriteLine(customer.FirstName);

Employee employee = new Employee();
employee.FirstName = "Yiğit Kartal";
Console.WriteLine(employee.FirstName);

Person person3 = customer;
customer.FirstName= "Fatma";
Console.WriteLine(person3.FirstName);

//Person person4 = employee;
//Console.WriteLine(person4.FirstName);

Console.WriteLine(((Customer)person3).CrediCardNumber); // person3 . yazınca credicardı çıkmaz o zaman bu şekilde de yazılabilir.

PersonManager personmanager = new PersonManager();
//personmanager.Add(employee);




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person //customer : müşteri
{
    public string CrediCardNumber { get; set; }
}
class Employee:Person  //Employee : çalışan
{
    public int EmployeeNumber { get; set; }
}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}
