namespace C44_G02_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // part 1 
            #region Part 1

            // Question 1:
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance


            // Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private



            //Question 3:
            // Can an interface contain fields in C#?
            //b) No



            //Question 4:
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces


            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //d) implements


            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes


            // Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public


            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access

            //Question 9:
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors


            //Question 10:
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas



            #endregion

            #region Part 2

            #region Q1
            Console.WriteLine();
            Console.WriteLine("-------------Q1---------");

            Circle circle = new Circle(5);
            circle.DisplayShapeInfo();

            Rectangle rectangle = new Rectangle(2, 3);
            rectangle.DisplayShapeInfo();


            #endregion


            #region Q2
            Console.WriteLine();
            Console.WriteLine("-------------Q2---------");

            IAuthenticationService authenticationService = new BasicAuthenticationService();
            authenticationService.AuthenticateUser("ahmed", "123");
            authenticationService.AuthorizeUser("ali", "admin");

            #endregion


            #region Q3
            Console.WriteLine();
            Console.WriteLine("-------------Q3---------");
            INotificationService notification1 = new EmailNotificationService();
            notification1.SendNotification("Email : kerouls1993@gmail.com" , "thank you from Email"  );
            Console.WriteLine();
            INotificationService notification2 = new SmsNotificationService();
            notification1.SendNotification("SMS : 01282370122", "thank you from mobile");
            Console.WriteLine();
            INotificationService notification3 = new PushNotificationService();
            notification1.SendNotification("push to : kerouls ", "thank you");

            #endregion










            #endregion
            Console.ReadLine();
       

        }
    }
}
