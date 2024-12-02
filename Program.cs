
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

List<double> flyttalslista = new List<double> ();
flyttalslista.Add(3.2);
flyttalslista.Add(4.2);
flyttalslista.Add(1.2);
flyttalslista.Add(5.2);
flyttalslista.Add(2.2);
flyttalslista.RemoveAt(3);

foreach(double element in flyttalslista)
{
    Console.WriteLine(element); 
}


{
  
    double summa = flyttalslista[0]+flyttalslista[1]+flyttalslista[2]+flyttalslista[3];
// hur skriver man utrycket för summan enklare??
    Console.Write("Medelvärdet är: ");
    Console.WriteLine(Medelvärde(summa)); 
}

 double Medelvärde(double s)
{
    double M = s/flyttalslista.Count ;
    return M;
}