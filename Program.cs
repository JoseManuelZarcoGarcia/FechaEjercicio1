namespace FechaEjercicio1
{

    class Program
    {

        static void Main(string[] args)
        {



            DateTime fecha4 = DateTime.Now;
            fecha4.ToString("yy - MM - ddThh:mm: ss.ms");
            Console.WriteLine("Formato fecha - tiempo: " + fecha4.ToString());


        }

    }

}