internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao StopWatch!!!");
        Console.WriteLine("");
        Console.WriteLine("Por favor,  digite o tempo que deseja cronometrar: ");
        int time = int.Parse(Console.ReadLine());

        Start(time);





    }


    static void Start(int time)
    {
        //int time = 10;
        int currentTime = 0;


        while (currentTime != time)
        {
            //Limpando para mostrar apenas o atual
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            //Thread Sleep para ele "dormir" por um certo tempo
            Thread.Sleep(1000);

            if(currentTime == time)
            {
                Console.WriteLine("SEU TEMPO ACABOU!!!!");
            }

        }


    }






}