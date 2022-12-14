/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите Х1:");
int Xa = int.Parse (Console.ReadLine());

 Console.Write("Введите Y1:");
int Ya = int.Parse (Console.ReadLine());

 Console.Write("Введите Х2:");
int Xb = int.Parse (Console.ReadLine());

 Console.Write("Введите Y2:");
int Yb = int.Parse (Console.ReadLine());

Console.Write("Введите Z1:");
int Za = int.Parse (Console.ReadLine());

Console.Write("Введите Z2:");
int Zb = int.Parse (Console.ReadLine());

double AC = (Xb-Xa);
double BC = (Yb-Ya);
double CC = (Zb-Za);

double ABC = Math.Pow (AC,3) + Math.Pow(BC,3)+ Math.Pow(CC,3) ;

double result = Math.Cbrt(ABC);

Console.WriteLine(result);