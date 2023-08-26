using Balta.ContentContext;
using Balta.SubscriptionContext;

var courseOOP = new Course("Curso de OOP", "oop.com");
var cousrCSharp = new Course("Curso de C#", "csharp.com");
var courseSQL = new Course("Curso de SQL", "sql.com");


var careers = new List<Career>();
var careerDotNet = new Career("Especialista  em .net", ".net.com");
careers.Add(careerDotNet);
var careerItem = new CareerItem(1, "Comece por aqui", "", null);
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", cousrCSharp);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);
careerDotNet.Items.Add(careerItem);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Mensage}");
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);