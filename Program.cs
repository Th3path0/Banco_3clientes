using System;


namespace Banco_practica_Progr
{
    class Cliente
    {
        private string nombre;
        private int monto;
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }
        public void Depositar(int m)
        {
            monto = monto + m;
        }
        public void Extraer(int m)
        {
            monto = monto - m;
        }
        public int RetornarMonto()
        {
            return monto;
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }
    class Banco{ 
 private Cliente cliente1, cliente2, cliente3;
public Banco()
        {
            
            cliente1 = new Cliente("Jose");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("Marcus");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
 Program hola= new Program();

          int m1,m2,m3,m4,m5;
          m1=0; m2=0;m3=0;m4=0;m5=0;
          string salir;
           int Result;
           int Result2;
           int Result3;
          int resolt=0;
           int resolt2=0;
            int resolt3=0;
          int formato;
           
          int a =0;
int b =0;
int c =0;


Console.Clear();
Console.WriteLine("Hola");


Console.Clear();
Console.WriteLine("Banco FDPinverstment");
      
            do{ 
            Console.WriteLine("Bienvenid@ {0}"); Console.WriteLine("El saldo de Ana es de un monto de:" + a ); Console.WriteLine("El saldo de Jose es de un monto de:" + b); Console.WriteLine("El saldo de Marcus es de un monto de:" + c +"\n");
            
               Console.WriteLine("Marque 1, para depositar");
            Console.WriteLine("Marque 2, para retirar");
            formato=int.Parse(Console.ReadLine());

            switch(formato) {  
case 1:


         
Console.WriteLine("Usted ha elegido deposito, cuanto desea depositar para Ana?");
Result=int.Parse(Console.ReadLine());
Console.WriteLine("Usted ha elegido deposito, cuanto desea depositar para Jose?");
Result2=int.Parse(Console.ReadLine());
Console.WriteLine("Usted ha elegido deposito, cuanto desea depositar para Marcus?");
Result3=int.Parse(Console.ReadLine());

a= a+Result;
b= b+Result2;
c= c+Result3;
break;

case 2:
       
do{ 
    Console.WriteLine("Recuerde que el maximo de retiro es de 20,000 pesos");
Console.WriteLine("Ha elegido retiro, cuanto desea retirar para Ana?");
resolt=int.Parse(Console.ReadLine());
Console.WriteLine("Ha elegido retiro, cuanto desea retirar para Jose?");
resolt2=int.Parse(Console.ReadLine());
Console.WriteLine("Ha elegido retiro, cuanto desea retirar para Marcus?");
resolt3=int.Parse(Console.ReadLine());


Console.Clear();
}while(resolt>20000);


a = a-resolt;
Console.WriteLine("El retiro de Ana es de un monto de:" + resolt);



if(resolt % 5 == 0){
    
m1= resolt / 1000;
resolt= resolt % 1000;
m2= resolt / 500;
resolt= resolt % 500;
m3= resolt / 200;
resolt= resolt % 200;
m4= resolt / 100;
resolt= resolt % 100;
m5= resolt / 50;
resolt= resolt % 50;

}


Console.WriteLine("Billetes de 1000 pesos:" +m1 );
Console.WriteLine("Billetes de 500 pesos: " + m2);
Console.WriteLine("Billetes de 200 pesos: " + m3);
Console.WriteLine("Billetes de 100 pesos: " + m4);
Console.WriteLine("Billetes de 50 pesos: " + m5);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("El retiro de Jose es de un monto de:" + resolt2);



if(resolt % 5 == 0){
    
m1= resolt / 1000;
resolt= resolt % 1000;
m2= resolt / 500;
resolt= resolt % 500;
m3= resolt / 200;
resolt= resolt % 200;
m4= resolt / 100;
resolt= resolt % 100;
m5= resolt / 50;
resolt= resolt % 50;

}


Console.WriteLine("Billetes de 1000 pesos:" +m1 );
Console.WriteLine("Billetes de 500 pesos: " + m2);
Console.WriteLine("Billetes de 200 pesos: " + m3);
Console.WriteLine("Billetes de 100 pesos: " + m4);
Console.WriteLine("Billetes de 50 pesos: " + m5);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("El retiro de Marcus es de un monto de:" + resolt);



if(resolt % 5 == 0){
    
m1= resolt / 1000;
resolt= resolt % 1000;
m2= resolt / 500;
resolt= resolt % 500;
m3= resolt / 200;
resolt= resolt % 200;
m4= resolt / 100;
resolt= resolt % 100;
m5= resolt / 50;
resolt= resolt % 50;

}


Console.WriteLine("Billetes de 1000 pesos:" +m1 );
Console.WriteLine("Billetes de 500 pesos: " + m2);
Console.WriteLine("Billetes de 200 pesos: " + m3);
Console.WriteLine("Billetes de 100 pesos: " + m4);
Console.WriteLine("Billetes de 50 pesos: " + m5);




Console.ReadLine();

break;

            }
         
 



    
    
      Console.WriteLine("¿Desea continuar usando el programa y volver al menu? SI/NO)");
                  salir = Console.ReadLine();
                  Console.Clear();
                } while (salir == "SI"|| salir == "si");
                Console.Clear();


            

            Console.ReadKey();



    



}
    
     

  

 
        }

}

        
