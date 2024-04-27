namespace CalculadoraTarea1.Class


{
   public class Calcular
    {
        public void CalculadoraTarea1()
        {
            //Declarar valores a sumar y calcular
            int suma1 = 0;
            int suma2 = 0;
            int valortotal1 = 0;
            int valortotal2 = 0;
            Console.WriteLine("Ingrese el primer valor que desea sumar y multiplicar ");
            suma1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor ");
            suma2 = Convert.ToInt32(Console.ReadLine());

            valortotal1 = (suma1 + suma2);
            Console.WriteLine($"La sumatoria de sus valores es: {valortotal1} ");

            valortotal2 = (suma1 * suma2);
            Console.WriteLine($"El producto de sus valores es: {valortotal2} ");

            
        }

    }
}
