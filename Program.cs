using System;

namespace PatronesdeDiseño
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string dato = string.Empty;
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = string.Empty;

            Ioperacion Opr = new CSuma();

            while (opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicación, 4-Division, 5-Salir ");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break;

                Console.WriteLine("Ingresa el valir de A");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Ingresa el valir de B");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);


                switch (opcion)
                {
                    case "1":
                        Opr = new CSuma();
                        r = Opr.Operacion(x, y);
                        break;
                    case "2":
                        Opr = new CResta();
                        r = Opr.Operacion(x, y);
                        break;
                    case "3":
                        Opr = new CMultipli();
                        r = Opr.Operacion(x, y);
                        break;
                    case "4":
                        Opr = new CDivi();
                        r = Opr.Operacion(x, y);
                        break;
                 
                    default:
                        break;
                }

                Console.WriteLine("El resultado es: " + r);

            }





            Console.WriteLine("Hello World!");
        }
    }
}
