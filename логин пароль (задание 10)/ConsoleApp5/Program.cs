class Program
{
    static void Main(string[] args)
    {
        string login = "alimkq";
        string password = "123qwe";

        int count = 0;
        do
        {
            Console.WriteLine("\nВведите логин: ");
            string checkLogin = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string checkPassword = Console.ReadLine();


            if (login == checkLogin && password == checkPassword)
            {

                Console.WriteLine("Добро пожаловать");
                Console.ReadLine();
                break;
            }
            Console.WriteLine("Неверно введен логин или пароль");
            Console.ReadLine();
            ++count;
        } while (count < 3);



    }
}
