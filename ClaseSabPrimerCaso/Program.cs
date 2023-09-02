// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese numero de personas");
int NumPersonas=int.Parse(Console.ReadLine());

float TOT = 0;

if (NumPersonas > 300)
{
    TOT = NumPersonas * 75;

   // Console.WriteLine("MAYOR A 300 "+TOT);
}
else {
    if (NumPersonas > 200)
    {

        TOT = NumPersonas * 85;
    //    Console.WriteLine("200 "+TOT);
    }
    else {
        TOT = NumPersonas * 95;
    //    Console.WriteLine("SIN DESCEUNTO " +TOT);
    }

}
Console.WriteLine("El total es : " + TOT);