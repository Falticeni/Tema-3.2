using System;
using System.Collections.Generic;

namespace Proiect_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");

            //int number1;   //declar o variabila de tipul int,
            //int number2;    //scopul lui number2 este intre acolade
            //number1 = 10;   //oferim valoarea 10 varibile
            //Console.WriteLine(number1);
            //number2 = 20;
            //Console.WriteLine(number2);
            //int number3 = number1 + number2;
            //Console.WriteLine(number3);


            //int number;
            //string text;
            //number = 10;
            //text = "20";
            //Console.WriteLine("numarul este: " + number);
            //Console.WriteLine("textul este: " + text);
            //int number2 = Convert.ToInt32(text);
            //Console.WriteLine("numarul dupa conversie este: " + number2);
            //string text2 = Convert.ToString(number);
            //Console.WriteLine("numarul dupa conversie (in->string) este: " + number2);


            //string text = "hello world 123";
            //Console.WriteLine(text);
            //string text2;
            //text2 = Console.ReadLine();
            //Console.WriteLine(text2);


            //int number;
            //string text;
            //text = "introdu numarul";
            //Console.WriteLine(text);
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number > 100) Console.WriteLine("numarul " + number + " este mai mare ca 100");
            //else if (number == 100) Console.WriteLine(number + " este egal cu 100");
            //else Console.WriteLine("numarul " + number + " este mai mic ca 100");


            //int number1;
            //int number2;
            //int number3;
            //string text1;
            //string text2;
            //text1 = "introdu numarul 1";
            //Console.WriteLine(text1);
            //number1 = Convert.ToInt32(Console.ReadLine());
            //text2 = "introdu numarul 2";
            //Console.WriteLine(text2);
            //number2 = Convert.ToInt32(Console.ReadLine());
            //number3 = number1 + number2;
            //Console.WriteLine("suma numerelor este " + number3);


            //for (int number = 0; number <= 10; number++)
            //{
            //    if (number % 2 == 1) Console.WriteLine(number + " este impar");
            //    else Console.WriteLine(number + " este par");
            //    //Console.WriteLine(number + " , ");
            //}


            //int number;
            //string text;
            //text = "introdu numarul";
            //Console.WriteLine(text);
            //number = Convert.ToInt32(Console.ReadLine());
            //int number2 = number;
            //while (number >= 0)
            //{
            //    number = number - 2;
            //}
            //if (number == 1) Console.WriteLine("numarul " + number2 + " este impar");
            //else Console.WriteLine("numarul " + number2 + " este par");


            ////Tema 02 - Exercitiul 1

            // int number1;
            // int number2;
            // int number3;
            // string text1 = "introduceti primul numar:";
            // string text2 = "introduceti al doilea numar:";
            // Console.WriteLine(text1);
            // number1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(text2);
            // number2 = Convert.ToInt32(Console.ReadLine());

            //// adunarea
            //number3 = number1 + number2;
            // Console.WriteLine("Suma numerelor este: " + number3);

            //// scaderea
            //number3 = number1 - number2;
            // Console.WriteLine("Diferentelor numerelor este: " + number3);

            //// impartirea
            // if (number2 == 0) Console.WriteLine("Impartirea numerelor nu este posibila");
            // else
            // {
            //     number3 = number1 / number2;
            //     Console.WriteLine("Impartirea numerelor este: " + number3);
            // }

            //// inmultirea
            //number3 = number1 * number2;
            // Console.WriteLine("Inmultirea numerelor este: " + number3);

            //// min si max
            // if (number1 > number2) Console.WriteLine("Maximul dintre cele 2 numere este: " + number1);
            // else Console.WriteLine("Maximul dintre cele 2 numere este: " + number2);



            //////Tema 02 - Exercitiul 2
            //int number1;
            //int number2;
            //string text1 = "Scrieti primul numarul, de preferat mai mare ca 1000:";
            //String text2 = "Daca nr.-ul scris de dv. reprezinta grade C, apasati 1; daca reprezinta grade F apasati 2, daca reprezinta un nr. de zile apasati 3.";
            //Console.WriteLine(text1);
            //number1 = Convert.ToInt32(Console.ReadLine());
            //double number3 = number1 * 1.8 + 32;                            // functia de conversie in grade C
            //double number4 = (number1 - 32) / 1.8;                          // functia de conversie in grade F
            //Console.WriteLine(text2);
            //number2 = Convert.ToInt32(Console.ReadLine());                  // alegi ce reprezinta numarul scris
            //while (number2 > 3)                                             // in cazul in care ai introdus o valoare gresita
            //{
            //    Console.WriteLine("Hotarati-va! Daca nr.-ul scris de dv. reprezinta grade C, apasati 1; daca reprezinta grade F apasati 2, daca reprezinta un nr. de zile apasati 3.");
            //    number2 = Convert.ToInt32(Console.ReadLine());
            //}
            //while (number2 < 0)                                             // nu am stiu semnul "sau"  / // in cazul in care ai introdus o valoare gresita
            //{
            //    Console.WriteLine("Hotarati-va! Daca nr.-ul scris de dv. reprezinta grade C, apasati 1; daca reprezinta grade F apasati 2, daca reprezinta un nr. de zile apasati 3.");
            //    number2 = Convert.ToInt32(Console.ReadLine());
            //}
            //if (number2 == 1) Console.WriteLine(number1 + " grade C = " + number3 + " grade F");  // conversia in grade F
            //if (number2 == 2) Console.WriteLine(number1 + " grade F = " + number4 + " grade C");  // conversia in grade C
            //if (number2 == 3)                                               // conversia in ani, luni, saptamani si zile
            //{
            //    int an = number1 / 365;                                     //functia pt. an
            //    int luna = (number1 - an * 365) / 30;                       // functia pt. luna
            //    int saptamana = ((number1 - an * 365) - luna * 30) / 7;     //functia pt saptamana
            //    int zi = (number1 - an * 365) - luna * 30 - saptamana * 7;  // functia pt zi
            //    Console.WriteLine(number1 + " zile totalizeaza " + an + " ani, " + luna + " luni, " + saptamana + " saptamani si " + zi + " zile.");
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i != 100)
            //        Console.Write(i + ", ");
            //        else Console.Write(100);

            //}


            //int[] array = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            //foreach (int element in array)
            //{
            //    Console.WriteLine(element);
            //}


            //int a = 0;
            //while (a <= 100)
            //{
            //    Console.Write(a + ", ");
            //    a = a + 3;
            //}


            //for (int i = 0; i < 100; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.Write(i + ", ");
            //}


            //int i = 5;
            //int number;
            //string text  = "introduceti nr. 5";
            //Console.WriteLine(text);
            //number = Convert.ToInt32(Console.ReadLine());
            //for (int j = 0; j <= 10; j++)
            //{
            //    //Console.WriteLine(i + " * " + j + " = " + i * j);
            //    //Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            //    Console.WriteLine($"{i} * {j} = {i * j}");
            //}


            //double i = (int)4.1;
            //Console.WriteLine(i);


            //int[] numere = null;
            //numere = new int[5];
            //numere[0] = 0;
            //numere[1] = 2;
            //numere[2] = 4;
            //numere[3] = 6;
            //numere[4] = 8;

            //int[] numere2 = { 3, 2, 5, 13 };
            //int[] numere3 = new int[4] {5, 2, 6, 4};


            //int[] numbers = { 11, 22, 33, 44, 55 };
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + ", ");
            //}

            //int[] numbers = { 11, 22, 33, 44, 55 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + ", ");
            //}


            //int[] numbers = { 11, 22, 33, 44, 55 };
            //for (int i = numbers.Length-1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + ", ");
            //}


            //int[] numbers = new int[11];
            //for (int i = 0; i < 11; i++)
            //{
            //    numbers[i] = i + 10;
            //    if (i != 10)
            //    {
            //        Console.WriteLine(numbers[i] + ", ");
            //    }
            //    else Console.WriteLine(numbers[i] + ".");
            //}


            //TEMA:

            //// EXERCITIUL 00. PROBLEMA CU SIRUL DE LA SFARSITUL CURSULUI TRECUT
            //Console.WriteLine("Stabiliti lungimea sirului:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[a];
            //int[] array1 = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Sirul  este format din valorile: ");
            //for (int i = 0; i < a; i++)
            //{
            //    if (i != (a - 1))                           // pt. un rezultat afisat frumos
            //    {
            //        Console.Write(array[i] + ", ");
            //    }
            //    else
            //        Console.WriteLine(array[i] + ".");
            //}
            //Console.WriteLine("Sirul citit invers este format din valorile: ");
            //for (int i = a - 1; i >= 0; i--)
            //{
            //    if (i != 0)                                 // pt. un rezultat afisat frumos
            //    {
            //        Console.Write(array[i] + ", ");         
            //    }
            //    else
            //        Console.WriteLine(array[i] + ".");      
            //}
            //Console.WriteLine("Noul sir ia invers valorile primului sir: ");
            //int j = 0;
            //for (int i = a - 1; i >= 0; i--)
            //{
            //    if (i != 0)                                 // pt. un rezultat afisat frumos
            //    {
            //        array1[j] = array[i];
            //        Console.Write(array[i] + ", ");         
            //        j++;
            //    }
            //    else
            //        Console.WriteLine(array[i] + ".");      
            //}


            //// EXERCITIUL 01. PROBLEMA FIZZBUZZ
            //int i;
            //for (i = 1; i < 1001; i++)
            //{
            //    if (i % 3 == 0) Console.Write("Fizz, ");
            //    if (i % 5 == 0) Console.Write("Buzz, ");
            //    if ((i % 3 == 0) && (i % 5 == 0)) Console.Write("FizzBuzz, ");
            //    else Console.Write("{0}, ", i);
            //}


            //// EXERCITIUL 02. Write a program to count the frequency of each element in an array e. g. [1, 4, 5, 2, 1, 4, 3, 1, 2] 
            ////should output: 1 - 3 times 4 - 2 times 5 - one time 2 - 2 times 3 - one time
            //Console.WriteLine("Stabiliti lungimea sirului:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //// exercitiul propriu-zis:
            //for (int i = 0; i < a; i++)
            //{
            //    int b = 0;
            //    for (int j = 0; j < i; j++) //valorile pozitiilor verificate nu le mai luam in calcul. 
            //    {

            //        if (array[i] == array[j]) i++; // aici imi dadea o eroare la ultimul element din sir. i depasea lungimea sirului.
            //        if (i == a - 1)
            //        {
            //            return; // asa am scapat de eroare.
            //        }
            //    }
            //    for (int j = i; j < a; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            b++; // cuantific de cate ori am identificat valoarea in sir
            //        }
            //    }
            //    if (b == 1)
            //    {
            //        Console.Write("{0} - one time ", array[i]);
            //    }
            //    else
            //    {
            //        Console.Write("{0} - {1} times ", array[i], b);
            //    }
            //}


            //// EXERCITIUL 03.Read an array from console and separate odd and even values into 2 arrays.
            //Console.WriteLine("Stabiliti lungimea sirului:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[a];
            //int numere_pare = 0;
            //int numere_impare = 0;
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < a; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        numere_pare++;
            //    }
            //    else numere_impare++;
            //}
            //int[] array1 = new int[numere_pare];
            //int[] array2 = new int[numere_impare];
            //Console.WriteLine("Sirul numerelor pare este:");
            //int j = 0;
            //for (int i = 0; i < a; i++)
            //{

            //    if (array[i] % 2 == 0)
            //    {
            //        array1[j] = array[i];
            //        Console.WriteLine(array1[j]);
            //        j++;
            //    }
            //}
            //Console.WriteLine("Sirul numerelor impare este:");
            //int l = 0;
            //for (int i = 0; i < a; i++)
            //{
            //    if (array[i] % 2 == 1)
            //    {
            //        array2[l] = array[i];
            //        Console.WriteLine(array2[l]);
            //        l++;
            //    }
            //}


            //// EXERCITIUL 04.1 Find common elements between two arrays of integers. 
            //Console.WriteLine("Stabiliti lungimea primului sir:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int[] array1 = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
            //    array1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Primul sir  este format din valorile: ");
            //for (int i = 0; i < a; i++)
            //{
            //    if (i != (a - 1))                   // pt. un rezultat afisat frumos
            //    {
            //        Console.Write(array1[i] + ", ");
            //    }
            //    else
            //        Console.WriteLine(array1[i] + ".");
            //}
            //Console.ReadLine();
            //Console.WriteLine("Stabiliti lungimea sirului 2:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int[] array2 = new int[b];
            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
            //    array2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Primul sir  este format din valorile: ");
            //for (int j = 0; j < b; j++)
            //{
            //    if (j != (b - 1))                   // pt. un rezultat afisat frumos
            //    {
            //        Console.Write(array2[j] + ", ");
            //    }
            //    else
            //        Console.WriteLine(array2[j] + ".");
            //}
            //Console.WriteLine("Elementele comune ale celor 2 siruri sunt:");
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        if (array1[i] == array2[j])
            //        {
            //            Console.WriteLine(array1[i]);
            //        }
            //    }
            //}


            //// EXERCITIUL 04.2 Write a function to check if a number is prime or not. 
            //int number;
            //int x = 0;
            //Console.WriteLine("Introduceti un numar:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        x++; //numaram de cate ori restul da zero.
            //    }
            //}
            //if (x == 2) // un nr. prim se impart fix de 2 ori: la 1 si la propriul nr.
            //{
            //    Console.WriteLine(number + " este prim.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " nu este prim.");
            //}


            //LinkedList<int> list = new LinkedList<int>();
            //LinkedListNode<int> firstnode = new LinkedListNode<int>(10);
            //list.AddFirst(firstnode);

            //LinkedListNode<int> node2 = new LinkedListNode<int>(20);
            //list.AddAfter(firstnode, node2);


            //List<int> lista = new List<int>() { 10, 11, 50,};

            //lista.Add(10);
            //lista.Add(20);
            //lista.Add(11);
            //lista.Add(20);
            //List<int> duplicate = new List<int>();
            //for (int i = 0; i < lista.Count-1; i++)
            //{
            //    for (int j = i+1; j < lista.Count; j++)
            //    {
            //        if (lista[i] == lista[j])
            //        {
            //            lista.RemoveAt(j);
            //        }
            //    }
            //}
            //foreach (var element in lista)
            //{
            //    Console.Write(element + " ");
            //}


            //string s = "text kk";
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(s[i] + " ");
            //}



            ////Tema pentru 23 aprilie:

            //// Problema de 10 :)). Nr. caractere al ultimului cuvant.
            //NrCaractereUltimulCuvant();


            //// Exercitiul 1. Sum the values of an array and display it to console.

            //// Cum sa fac sa apelez o functie in alta functie? As folosi tot vectorul citit de la consola din functia DefinitiArr().
            //// Am incercat asa ceva:
            ////int[] arr = new int[] { DefinitiArr() } ;
            ////int x = SumaSirului(arr);

            //int[] arr = new int[] { 10, 20, 30, 40, 50 };
            //int x = SumaSirului(arr);


            //// Exercitiul 2. Calculate the average value of array elements.
            //double[] arr= new double[] { 10, 20, 30, 40, 50 };
            //double medie = MediaSirului(arr);

            //// Exercitiul 3. Find the index of an element in an array
            //int[] arr = new int[] { 10, 20, 30, 40, 50 };
            //int index = IndexulNumarului(arr);

            //// Exercitiul 4. Remove a specific element from an array.
            //List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
            //int x = RemoveElement(lista);

            //// Exercitiul 5. Insert an element into an array at a specified position..
            //List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //int element = InsertElement(lista);

            //// Exercitiul 6.Find the maximum and minimum value of an array.
            //int[] arr = new int[7] { 22, 34, 7, 86, 1001, 25, 756 };
            //int x = MinMax(arr);

            //// Exercitiul 7. Find common elements between two arrays of integers
            //int[] arr1 = { 65, 32, 65, 54, 2, 2005, 42, 100 };
            //int[] arr2 = { 9, 65, 5, 9, 2, 54, 42, 42, 39 };
            //int x = CommonElements(arr1, arr2);

            //// Exercitiul 8.Copy elements from an array into another.
            //int[] arr1 = new int[7] { 22, 34, 34, 86, 1001, 25, 756 };
            //List<int> lista0 = new List<int> { 0, 5, 10, 15 };
            //int x = CopyArr(arr1, lista0);

            ////Exercitiul 9.Implement an algorithm to determine if a string has all unique characters.
            //int x = UniqueCharacter();


            ////Exercitiul 10.Write code to remove duplicates from an unsorted linked list.
            //// Aici trebuie sa mai insist. Nu mi-a dat problema.
            //LinkedList<int> lista = new LinkedList<int>();
            //LinkedListNode<int> nodulLui30 = lista.AddFirst(30);
            //LinkedListNode<int> nodulLui20 = lista.AddFirst(20);
            //lista.AddAfter(nodulLui20, 20);
            //LinkedListNode<int> nodulLui10 = lista.AddFirst(10);
            //lista.AddBefore(nodulLui30, 20);
            //LinkedListNode<int> nodulLui50 = lista.AddLast(50);
            //lista.AddLast(10);
            //lista.AddLast(35);
            //Console.Write("Lista initiala este formata din elementele: ");
            //foreach (var x in lista)
            //{
            //    Console.Write(x + ", ");
            //}
            //var element = lista.First;
            //var elementNext = element.Next;
            //while (element != null)     // atat timp cat primul element este null
            //{
            //    while (elementNext != null)         // atat timp cat al 2-lea element este null
            //    {
            //        if (element == elementNext)     // daca primul element = elementNext stergem elementul
            //        {
            //            lista.Remove(elementNext);
            //        }
            //        elementNext = elementNext.Next;     //elementNext ia urmatoarea valoare.
            //    }
            //    element = element.Next; // trecem la al doilea element din sir si reluam de la primul while (comparam al 2-lea element cu restul elementelor)
            //}
            //Console.Write("Lista finala, fara duplicate este formata din elementele: ");
            //foreach (var x in lista)
            //{
            //    Console.Write(x + ", ");
            //}


            ////Exercitiul 11.Check if a word is a palindrome.
            //int x = Palindrom();

            ////Exercitiile de pe primul slide:
            // 1. Print to console all even numbers between 15 and 97.
            //for(int i=15; i<=97; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //2.Print all numbers divisible by 3 between 20 and 65.
            //for (int i = 20; i <= 65; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            // 3.Count all numbers divisible by 7 and multiple of 5, from 1400 to 2300 and print the result to console.
            //int count = 0;
            //for (int i = 1400; i <= 2300; i++)
            //{
            //    if (i % 35 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.Write(count);


            /// 4.Write a program to guess a number between 1 and 10.To generate a random number, use Random class from .NET Framework.
            // Cum se face asta?


            ////5.Read a text from console and print it reversed.
            //string text = ReversedText();

            ////6.Print numbers from 1 to 10 except 4 and 7.
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 4 || i == 7)
            //    {
            //        continue;
            //    }
            //    Console.Write(i + " ");
            //}

            ////7.Print the Fibonacci sequence from 0 to 50.
            //int x = FibonacciSequence();




            ////Exercitii
            //// E01.
            //int[] arr = new int [] {1, 2, 30, 46, 80, 24, 115, 13 };
            //Functia1(arr);

            ////E02.
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //Functia2(arr);

            ////E04.
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //Functia4(arr);

            ////E05. 
            //LinkedList<int> lista = new LinkedList<int>();
            //LinkedListNode<int> nodulLui30 = lista.AddFirst(30);
            //LinkedListNode<int> nodulLui20 = lista.AddFirst(8);
            //LinkedListNode<int> nodulLui10 = lista.AddFirst(25);
            //LinkedListNode<int> nodulLui9 = lista.AddFirst(8);
            //LinkedListNode<int> nodulLui8 = lista.AddFirst(5);
            //LinkedListNode<int> nodulLui5 = lista.AddFirst(5);
            //Functia05(lista);





            ///////////////////////         Tema 3.1            ////////////////////////

            ////E3.1.1. Given an array of ints, write a C# method to total all the values that are even number.
            //int[] arr = new int[] { 10, 15, 20, 25, 30, 35, 40, 55, 89, 95, 97, 13 };
            //Functia311(arr);

            ////E3.1.2. How to find all pairs of elements in an integer array, whose sum is equal to a given number?
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //Functia312(arr);

            ////E3.1.3. How to calculate factorial using recursion in C# + iterative + time difference
            //int factorial = Functia313(7);
            //Console.Write(factorial);

            ////E3.1.4. Algorithm to find if Array contains duplicates
            //int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            //Functia314(arr);

            ////E3.1.5. How to remove duplicates from a sorted linked list?
            //LinkedList<int> lista = new LinkedList<int>();
            //LinkedListNode<int> nodulLui30 = lista.AddFirst(30);
            //LinkedListNode<int> nodulLui20 = lista.AddFirst(8);
            //LinkedListNode<int> nodulLui10 = lista.AddFirst(25);
            //LinkedListNode<int> nodulLui9 = lista.AddFirst(8);
            //LinkedListNode<int> nodulLui8 = lista.AddFirst(5);
            //LinkedListNode<int> nodulLui5 = lista.AddFirst(5);
            //Functia315(lista);

            ////E3.1.6. How to find sum of digits of a number using Recursion?
            //int x = SumOfDigits(123456);
            //Console.Write("Suma cifrelor numarului ales este " + x + ".");

            ////E3.1.7. Given an unsorted array which has a number in the majority (a number appears more than 50 % in the array), find that number.
            //int[] arr = new int[] { 3, 3, 3, 3, 2, 5 };
            //Functia317(arr);

            ////E3.1.8. How to detect a cycle in a singly linked list?  
            //LinkedList<int> lista = new LinkedList<int>();
            //LinkedListNode<int> nodul1 = lista.AddFirst(30);
            //LinkedListNode<int> nodul2 = lista.AddFirst(8);
            //LinkedListNode<int> nodul3 = lista.AddFirst(25);
            //LinkedListNode<int> nodul4 = lista.AddFirst(6);
            //LinkedListNode<int> nodul5 = lista.AddFirst(8);
            //LinkedListNode<int> nodul6 = nodul2;
            //Functia318(lista);

            //E3.1.9. How to merge two sorted linked list?
            //LinkedList<int> lista1 = new LinkedList<int>();
            //LinkedListNode<int> nodul1 = lista1.AddFirst(9);
            //LinkedListNode<int> nodul2 = lista1.AddFirst(7);
            //LinkedListNode<int> nodul3 = lista1.AddFirst(5);
            //LinkedListNode<int> nodul4 = lista1.AddFirst(3);
            //LinkedListNode<int> nodul5 = lista1.AddFirst(1);
            //LinkedList<int> lista2 = new LinkedList<int>();
            //LinkedListNode<int> nodul6 = lista2.AddFirst(10);
            //LinkedListNode<int> nodul7 = lista2.AddFirst(8);
            //LinkedListNode<int> nodul8 = lista2.AddFirst(6);
            //LinkedListNode<int> nodul9 = lista2.AddFirst(4);
            //LinkedListNode<int> nodul10 = lista2.AddFirst(2);
            //Functia319(lista1, lista2);

            ////E3.1.10. Write a Program which checks if two Strings are Anagram or not
            //FunctiaAnagrama();

            ////E3.1.11. Write a function to print the nth number in Fibonacci series
            //Functia3111();

            ////E3.1.12. Write a function to count a total number of set bits in a 32-bit Integer
            //int numarDigits = Functia3112(6);
            //Console.WriteLine(numarDigits);

            ////E3.1.13. Write a function to remove duplicate characters from String
            //Functia3113();

            ////E3.1.14. How to find the 3rd element from the end, in a singly linked, in a single pass?
            //LinkedList<int> lista1 = new LinkedList<int>();
            //LinkedListNode<int> nodul1 = lista1.AddFirst(1);
            //LinkedListNode<int> nodul2 = lista1.AddFirst(3);
            //LinkedListNode<int> nodul3 = lista1.AddFirst(5);
            //LinkedListNode<int> nodul4 = lista1.AddFirst(7);
            //LinkedListNode<int> nodul5 = lista1.AddFirst(9);
            //LinkedListNode<int> nodul6 = lista1.AddFirst(10);
            //LinkedListNode<int> nodul7 = lista1.AddFirst(2);
            //Functia3114(lista1);

            ////E3.1.15. C# program to check if a number is Armstrong number or not
            //Functia3115();

            ////E3.1.16. Algorithm to check if a number is Prime or not
            //Functia3116();

            ////E3.1.17. Algorithm to check if a number is a Palindrome
            //Palindrom();

            ////E3.1.18. Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion
            //LinkedList<int> lista = new LinkedList<int>();
            //LinkedListNode<int> nodul1 = lista.AddFirst(1);
            //LinkedListNode<int> nodul2 = lista.AddFirst(2);
            //LinkedListNode<int> nodul3 = lista.AddFirst(3);
            //LinkedListNode<int> nodul4 = lista.AddFirst(4);
            //LinkedListNode<int> nodul5 = lista.AddFirst(5);
            //LinkedListNode<int> nodul6 = lista.AddFirst(6);
            //LinkedListNode<int> nodul7 = lista.AddFirst(7);
            //Functia3118a(lista);
            ////Functia3118b(lista);  ////Recursiv nu mi-a reusit!

            ////E3.1.19. How to rotate an array by a given pivot?
            //int[] arr = new int[] { 1, 20, 3, 43, 5, 26, 79, 8 };
            //Functia3119(arr);

            ////E3.1.20. Sorting an Array using Selection Sort
            //int[] arr = new int[] { 1, 20, 3, 43, 5, 26, 79, 8 };
            //Functia3120(arr);

            ////E3.1.20. Sorting an Array using Bubble Sort
            //int[] arr = new int[] { 1, 20, 3, 43, 5, 26, 79, 8 };
            //Functia3121(arr);





            ////////////////////////////          TEMA 3.2          /////////////////////////   
            //// E3101. C# Program to Check Whether the Entered Year is a Leap Year or Not
            AnBisect();

            //// E3102. C# Program to Display the ATM Transaction
            // Scenariul 1: cont 10000 lei. PIN: 1234. Clientul greseste PIN-ul de 3 ori.
            // Scenariul 1: cont 10000 lei. PIN: 1234. Operatiuni:
            // 1. Se introduce corect PIN-ul.
            // 2. Se inceraca retragerea unei sume mai mari decat soldul (ex: 11000 lei).
            // 3. Clientul isi da seama ca nu stie cat sold disponibil are. Anuleaza operatiunea de retragere.
            // 4. Interogheaza soldul.
            // 5. Depune bani suficient cat sa poata retrage suma dorita initial (11000 lei).
            // 6. Retrage suma (11000 lei).
            // 7. Dupa retragere, sceptic, clientul mai verifica o data soldul si inchie operatiunile.
            ATM();

            //// E3102. Add two numbers in a file. 
            //// Nu am stiut











            //Console.ReadKey();
        }







        static void NrCaractereUltimulCuvant()
        {
            Console.WriteLine("Introduceti textul:");
            string text = Console.ReadLine();
            string x;
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                x = Convert.ToString(text[i]);
                if (x != " ")
                {
                    a++;
                }
                else
                {
                    a = 0;
                }
            }
            Console.WriteLine("Ultimul cuvant are {0} caractere", a);
        }

        static int DefinitiArr()
        {
            Console.WriteLine("Stabiliti lungimea sirului:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Definiti valoarea pentru pozitia {0}:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sirul  este format din valorile: ");
            for (int i = 0; i < a; i++)
            {
                if (i != (a - 1))                           // pt. un rezultat afisat frumos
                {
                    Console.Write(array[i] + ", ");
                }
                else
                    Console.WriteLine(array[i] + ".");
            }
            return array[a];
        }

        static int SumaSirului(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }
            Console.WriteLine("Suma sirului este {0}", suma);
            return suma;
        }

        static double MediaSirului(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double media = sum / arr.Length;
            Console.WriteLine("Media elementelor este {0}", media);
            return media;
        }

        static int IndexulNumarului(int[] arr)
        {
            int i;
            Console.WriteLine("Scrieti numarul indexului pe care il cautati:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine("Indexul numarului {0} este {1}", number, i);
                }
            }
            return i;
        }
        static int RemoveElement(List<int> lista)
        {
            Console.WriteLine("De la ce pozitie doriti sa eliminati numarul din sir?");
            int number = Convert.ToInt32(Console.ReadLine());
            lista.RemoveAt(number);
            Console.WriteLine("Noul sir este format din elementele:");
            foreach (var i in lista)
            {
                Console.Write(i + " ");
            }
            return number;
        }

        static int InsertElement(List<int> lista)
        {
            Console.WriteLine("Care este numarul pe care doriti sa il adaugati in sir?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La ce pozitie doriti sa adaugati noul numar in sir?");
            int pozitie = Convert.ToInt32(Console.ReadLine());
            if (pozitie > lista.Count)          // in cazul in care de la consola se ofera o pozitie mai mare ca lungimea sirului
            {
                Console.WriteLine("Stabiliti o pozitie cel mult egala cu lungimea sirului: {0}!", lista.Count);
                pozitie = Convert.ToInt32(Console.ReadLine());
            }
            lista.Insert(pozitie, number);
            foreach (var i in lista)
            {
                Console.Write(i + " ");
            }
            return pozitie;
        }

        static int MinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Minimul sirului este {0} iar maximul este {1}.", min, max);
            return min;
        }

        static int CommonElements(int[] arr1, int[] arr2)
        {
            List<int> lista = new List<int>();      // lista cu elementele comune celor 2 siruri.
            List<int> lista0 = new List<int>();     // lista cu elementele distincte din primul sir.
            foreach (int x in arr1)     // eliminam elementele comune din primul sir.
            {
                if (!lista0.Contains(x))
                {
                    lista0.Add(x);
                }
            }
            for (int i = 0; i < lista0.Count; i++)
            {
                for (int j = 0; j < arr2.Length; j++)   // comparam elementele sirului 2 cu elementele care nu se repeta din sirul 1 (lista0)
                {
                    if (lista0[i] == arr2[j])
                    {
                        lista.Add(lista0[i]);
                        break;      //   daca un element din lista0 (primul sir fara duplicate) il gasim in al doilea sir, nu mai continuam sa cautam si celelalte pozitii din sirul 2
                    }
                }
            }
            Console.Write("Elementele comune ale celor doua siruri sunt: ");
            for (int z = 0; z < lista.Count; z++)
            {
                if (z != (lista.Count - 1))                           // pt. un rezultat afisat frumos
                {
                    Console.Write(lista[z] + ", ");
                }
                else
                    Console.WriteLine(lista[z] + ".");
            }
            return lista[1];
        }

        static int CopyArr(int[] arr1, List<int> lista)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                lista.Add(arr1[i]);
            }
            Console.WriteLine("Sirul doi, care a copiat valorile primului sir, are acum urmatoarele elemente: ");
            foreach (var element in lista)
            {
                Console.Write(element + ", ");
            }
            return lista[1];
        }

        static int UniqueCharacter()
        {
            Console.Write("Scrieti textul: ");
            string text = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        a++;
                    }
                }
            }
            if (a != 0)
            {
                Console.WriteLine("Textul nu are caractere unice.");
            }
            else
            {
                Console.WriteLine("Textul are caractere unice.");
            }
            return text[1];
        }

        static void Palindrom()
        {
            Console.Write("Introduceti textul: ");
            string text = Console.ReadLine();
            string text1 = text;
            int i = 0;
            int j = text1.Length - 1;
            int count = 0;
            if (text.Length / 2 == 0)       //verificam daca numarul de carcatere din text este par sau impar pentru a sti limita inferioara a lui j
            {
                while ((i < text.Length / 2) && (j > text1.Length / 2))
                {
                    if (text[i] == text1[j])
                    {
                        count++;
                    }
                    i++;
                    j--;
                }
            }
            else
            {
                while ((i < text.Length / 2) && (j >= text1.Length / 2))
                {
                    if (text[i] == text1[j])
                    {
                        count++;
                    }
                    i++;
                    j--;
                }
            }
            if (count == (text.Length / 2))
            {
                Console.WriteLine("Cuvantul este palindrom.");
            }
            else
            {
                Console.WriteLine("Cuvantul nu este palindrom.");
            }
        }

        static string ReversedText()
        {
            Console.Write("Scrieti un text: ");
            string text = Console.ReadLine();
            Console.Write("Textul fisat invers: ");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            return text;
        }

        static int FibonacciSequence()
        {
            Console.Write("Stabiliti limita secventei sirului lui Fibonacci: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 1;
            int fib = 0;
            Console.Write(i + ", ");
            //Console.Write(j + ", ");
            while (fib <= number)
            {
                Console.Write(fib + ", ");
                fib = i + j;
                i = j;
                j = fib;
            }
            return fib;
        }


        ///////////////////////         Tema 3.1            ////////////////////////

        static void Functia311(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    suma += arr[i];
                }
            }
            Console.Write("Suma numerelor pare este {0}.", suma);
        }

        static void Functia312(int[] arr)
        {
            Console.Write("Stabiliti numarul: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Suma de {0} este egala cu suma perechilor: ", number);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        Console.Write(arr[i] + " si " + arr[j] + "; ");
                    }
                }
            }
        }

        static int Functia313(int number)
        {
            if (number == 0) return 1;
            else return number * Functia313(number - 1);
        }

        static void Functia314(int[] arr)
        {
            List<int> lista = new List<int>();
            foreach (int x in arr)     // eliminam elementele comune din primul sir.
            {
                if (!lista.Contains(x))
                {
                    lista.Add(x);
                }
            }
            if (lista.Count < arr.Length)
            {
                Console.Write("Sirul contine duplicate.");
            }
            else
            {
                Console.Write("Sirul nu contine duplicate.");
            }
        }

        static void Functia315(LinkedList<int> lista)
        {
            Console.Write("Lista este formata din elementele: ");
            foreach (int x in lista)
            {
                Console.Write(x + ", ");
            }
            var element = lista.First;
            while (element != null)
            {
                var elementurmator = element.Next;
                while (elementurmator != null)
                {
                    if (element.Value == elementurmator.Value)
                    {
                        lista.Remove(elementurmator);
                    }
                    elementurmator = elementurmator.Next;
                }
                element = element.Next;
            }
            Console.WriteLine();
            Console.Write("Lista fara duplicate este formata din elementele: ");
            foreach (var x in lista)
            {
                Console.Write(x + ", ");
            }
        }

        static int SumOfDigits(int n)
        {
            if (n == 0) return 0;
            else return (n % 10 + SumOfDigits(n / 10));
        }

        static void Functia317(int[] arr)
        {
            int y = 0;          // numaram cati indecsi din sir am citit
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int x = 0;      // o variabila care numara de cate ori se regaseste un nr. in sir
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x++;
                        if (x > arr.Length / 2)
                        {
                            Console.Write(arr[i] + " este numar majoritar in sir.");
                            return;
                        }
                    }
                }
                y++;
                if (y == arr.Length - 1) // DOAR cand ajungem la ultimul element din sir
                {
                    if (x < arr.Length / 2) Console.Write("Nu exista un numar majoritar in sir.");
                }
            }

        }

        static void Functia318(LinkedList<int> lista)
        {
            var element1 = lista.First;
            int a = 0;      // folosit doar pentru a fisa mesajul
            if (element1 == null)     // daca sirul nu are elemente atunci nu are cum sa contina o bucla.
            {
                Console.Write("Sirul inlantuit nu contine bucla.");
            }
            var i = element1;
            var j = element1.Next;
            while (i != null && j != null && j.Next != null)
            {
                i = i.Next;
                j = j.Next.Next;
                if (i == j)
                {
                    Console.Write("Sirul contine o bucla");
                    return;
                }
                else
                {
                    a++;
                }
            }
            if (a != 0) Console.Write("Sirul nu contine o bucla");
        }

        static void Functia319(LinkedList<int> lista1, LinkedList<int> lista2)
        {
            Console.Write("Elementele listei 1 sunt: ");
            foreach (var a in lista1)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();
            Console.Write("Elementele listei 2 sunt: ");
            foreach (var b in lista2)
            {
                Console.Write(b + ", ");
            }
            Console.WriteLine();
            var head1 = lista1.First;
            while (head1 != null)
            {
                var head2 = lista2.First;
                while (head2 != null)
                {
                    if (head1.Value > head2.Value)
                    {
                        lista1.AddBefore(head1, head2.Value);
                        lista2.Remove(head2);
                    }
                    head2 = head2.Next;
                }
                head1 = head1.Next;
            }
            Console.Write("Elementele celor 2 siruri sunt: ");
            foreach (var i in lista1)
            {
                Console.Write(i + ", ");
            }
        }

        static void FunctiaAnagrama()
        {
            Console.Write("Stabiliti anagrama: ");
            string text1 = Console.ReadLine();
            Console.Write("Stabiliti text2 potential anagrama cu text1: ");
            string text2 = Console.ReadLine();
            for (int i = 0; i < text2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < text1.Length; j++)
                {

                    if (text2[i] == text1[j])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Textul2 ales nu este anagrama pentru textu1.");
                    return;
                }
            }
            Console.WriteLine("Textul2 ales este anagrama pentru textul1.");
        }

        static void Functia3111()
        {
            Console.WriteLine("Stabiliti pozitia numarului din sirul lui Fibonacci pe care il doriti sa il printati: ");
            int limita = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 1;
            for (int k = 3; k <= limita; k++)
            {
                int fib = i + j;
                i = j;
                j = fib;
                if (k == limita)
                {
                    Console.WriteLine("Pozitia numarului {0} din sirul lui Fibonacci este reprezentat de {1}", limita, fib);
                }
            }
        }

        static int Functia3112(int x)
        {
            List<int> lista = new List<int>();
            int count = 0;
            for (int i = 0; x > 0; i++)
            {
                lista.Add(x % 2);
                x = x / 2;
            }
            for (int j = 0; j < lista.Count; j++)
            {
                if (lista[j] == 1)
                {
                    count++;
                }
            }
            return count;
        }

        static void Functia3113()
        {
            Console.Write("Introduceti textul: ");
            string text = Console.ReadLine();
            List<char> lista = new List<char>();
            foreach (var element in text)
            {
                if (!lista.Contains(element))
                {
                    lista.Add(element);
                }
            }
            Console.Write("Sirul fara duplicate este format din elementele: ");
            foreach (var element in lista)
            {
                Console.Write(element);
            }
        }

        static void Functia3114(LinkedList<int> lista1)
        {
            var head1 = lista1.First;
            var head2 = lista1.First;
            for (int i = 0; i < 3; i++)
            {
                head2 = head2.Next;
            }
            while (head2 != null)
            {
                head2 = head2.Next;
                head1 = head1.Next;
            }
            Console.Write("Al 3-lea element de la capatul listei este {0}.", head1.Value);
        }

        static void Functia3115()
        {
            Console.Write("Stabiliti numarul pe care il doriti a verifica daca este Armstrong sau nu:");
            int number = Convert.ToInt32(Console.ReadLine());
            int nrOriginal = number;
            int copie = number;
            int count = 0;
            int armstrong = 0;
            while (number != 0)
            {
                number = number / 10;
                count++; // numaram cate cifre are numarul
            }
            while (copie != 0)
            {
                int copie2 = copie % 10; // fiecare cifra a numarului
                armstrong = armstrong + FunctiaPutere(copie2, count);
                copie = copie / 10;
            }
            if (nrOriginal == armstrong)
            {
                Console.WriteLine("Numarul {0} este armstrong.", nrOriginal);
            }
            else
            {
                Console.WriteLine("Numarul {0} nu este armstrong.", nrOriginal);
            }
        }

        static int FunctiaPutere(int copie2, int count)
        {
            int i = 0;
            int putere = 1;
            while (i < count)
            {
                putere = putere * copie2;
                i++;
            }
            return putere;
        }

        static void Functia3116()
        {
            int x = 0;
            Console.Write("Introduceti un numar:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    x++; //numaram de cate ori restul da zero.
                }
            }
            if (x == 2) // un nr. prim se impart fix de 2 ori: la 1 si la propriul nr.
            {
                Console.WriteLine(number + " este nr. prim.");
            }
            else
            {
                Console.WriteLine(number + " nu este nr. prim.");
            }
        }

        static void Functia3118a(LinkedList<int> lista1)
        {
            Console.Write("Elementele listei originale sunt: ");
            foreach (var element in lista1)
            {
                Console.Write(element + ", ");
            }
            var head = lista1.First;
            while (head.Next != null)
            {
                var next = head.Next;
                lista1.Remove(next);
                lista1.AddFirst(next.Value);
            }
            Console.WriteLine();
            Console.Write("Elementele listei inversate sunt: ");
            foreach (var element in lista1)
            {
                Console.Write(element + ", ");
            }
        }

        static void Functia3119(int[] arr)
        {
            int[] arr0 = new int[arr.Length];
            int j = 0;
            Console.Write("Sirul original este format din elementele: ");
            foreach (int element in arr)
            {
                Console.Write(element + ", "); // citim sirul
            }
            Console.WriteLine();
            Console.Write("Stabiliti pivotul: ");
            int pivot = Convert.ToInt16(Console.ReadLine()); // stabilim pivotul
            while (pivot > arr.Length) // atat timp cat pivotul este mai mare decat lungimea sirului stabiim un nou pivot
            {
                Console.Write("Stabiliti pivotul asa incat sa fie mai mic decat lungimea sirului: ");
                pivot = Convert.ToInt32(Console.Read());
            }
            for (int i = pivot + 1; i < arr.Length; i++)
            {
                arr0[j] = arr[i];
                j++;
            }
            arr0[j] = arr[pivot];
            j++;
            for (int k = 0; k < pivot; k++)
            {
                arr0[j] = arr[k];
                j++;
            }
            Console.Write("Sirul intors dupa pivot este format din elementele: ");
            foreach (int elem in arr0)
            {
                Console.Write(elem + ", ");
            }
        }

        static void Functia3120(int[] arr)
        {
            Console.Write("Sirul original este format din elementele: ");
            foreach (int element in arr)
            {
                Console.Write(element + ", "); // citim sirul
            }
            for (int j = 0; j < arr.Length; j++)
            {
                int min = arr[j]; // prima data minimul ia valoarea primului element din lista
                for (int i = j; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i]; // stabilim minimul dupa ce am parcurs toata lista
                    }
                }
                int var = arr[j]; // memoram intr-o variabila valoarea lui arr[j] care va fi inlocuita cu min
                arr[j] = min; // primul element ia val minimul
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[k] == min)
                    {
                        arr[k] = var; // pentru restul sirului inlocuim indexul unde am gasit min cu var (facem schim intre ele)
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sirul ordonat folosind Selection Sort este format din elementele: ");
            foreach (int elem in arr)
            {
                Console.Write(elem + ", "); // citim sirul sortat
            }
        }

        static void Functia3121(int[] arr)
        {
            int var;
            int count = 1;
            Console.Write("Sirul original este format din elementele: ");
            foreach (int element in arr)
            {
                Console.Write(element + ", "); // citim sirul
            }
            while (count != 0) // atat timp cat am facut o modificare in sir
            {
                count = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1]) // daca prima valoare e mai mare ca a 2-a, se interschimba valorile si tot asa...
                    {
                        var = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = var;
                        count++; // numaram  cate modificari am facut
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Sirul original ordonat prin Buble Sort este format din elementele: ");
            foreach (int element in arr)
            {
                Console.Write(element + ", "); // citim sirul
            }
        }






        ////////////////////            TEMA 3.2           ///////////////////////
        static void AnBisect()
        {
            Console.Write("Introduceti anul pe care doriti sa-l verificati daca este sau nu bisect: ");
            int number = Convert.ToInt16(Console.ReadLine());
            if (((number % 4 == 0) && (number % 100 != 0)) || number % 400 == 0)
            {
                Console.Write("Anul {0} este an bisect.", number);
            }
            else
            {
                Console.Write("Anul {0} nu este bisect.", number);
            }
        }

        static void ATM()
        {
            int sold = 10000;       // soldul
            int pin = 1234;         // codul PIN
            int a = 1;              // verificam de cate ori clientul a introdus codul PIN.
            int b = 1;              // contorizam daca clientul mai doreste sa faca operatiuni
            Console.WriteLine("Buna ziua! Bine ati venit!. Introduceti cardul!(Enter*)");
            Console.Read();         // Simulam introducerea cardului dupa care se afiseaza urmatoarele instructiuni.
            Console.Write("Introduceti codul PIN, din 4 cifre (1234*): ");
            Console.ReadLine();
            int pin1 = Convert.ToInt32(Console.ReadLine());
            do                      // verificam daca codul PIN intordus a fost corect si urmam instuctiunile
            {
                if (pin1 != pin)
                {
                    Console.Write("Codul PIN introdus este gresit. Reintroduceti codul PIN: ");
                    pin1 = Convert.ToInt32(Console.ReadLine());
                    a++;
                    if (a == 3)     // daca clientul greseste PIN-ul de 3 ori, cardul i se retine :)
                    {
                        Console.WriteLine("Ati introdus consecutiv de 3 ori codul PIN gresit. Cardul v-a fost retinut. Pentru mai multe informatii prezentati-va unui ofiter bancar. Multumim!");
                        return;
                    }
                }
            }
            while (pin1 != pin);
            do
            {
                Console.WriteLine("Apasati cifra aferenta tipului de operatiune dorita: ");
                Console.WriteLine("Verificare sold: 1");
                Console.WriteLine("Retragere numerar: 2");
                Console.WriteLine("Depunere numerar: 3");
                Console.WriteLine("Anulare: 0");
                int operatiune = Convert.ToInt32(Console.ReadLine()); // se selecteaza operatiunea dorita

                if (operatiune == 1)        //verificare sold
                {
                    Console.WriteLine("Soldul dumneavoastra este: {0} lei.", sold);
                }
                if (operatiune == 2)        // retragere numerar
                {
                    Console.WriteLine("Ce suma doriti sa retrageti?");
                    int retragere = Convert.ToInt32(Console.ReadLine());
                    while (retragere > sold) // in cazul in care se doreste a fi retrasa o suma mai mare decat disponibilul
                    {
                        Console.WriteLine("Suma dorita a fi retrasa depaseste soldul disponibil. Retrageti o suma cel mult egala cu soldul disponibil: ");
                        retragere = Convert.ToInt32(Console.ReadLine());
                        if (retragere == 0) // in cazul in care clientul doreste sa anuleze operatiunea
                        {
                            continue;
                        }
                    }
                    sold -= retragere;
                }
                if (operatiune == 3)        // depunere numerar
                {
                    Console.WriteLine("Ce suma doriti sa depuneti?");
                    int depunere = Convert.ToInt32(Console.ReadLine());
                    sold += depunere;
                    if (depunere == 0) // in cazul in care clientul doreste sa anuleze operatiunea
                    {
                        continue;
                    }
                }
                Console.WriteLine("Doriti sa efectuati o alta operatiune? Daca da, apasati 1. Daca nu, apasati 2: ");
                int optiune = Convert.ToInt32(Console.ReadLine()); // se selecteaza optiunea dorita
                if (optiune == 2)
                {
                    Console.WriteLine("Va multumim! Ridicati cardul.");
                    b++;
                }
            }
            while (b == 1);
        }
    }
}

