# Tema-3.2

            // E3101. C# Program to Check Whether the Entered Year is a Leap Year or Not
            AnBisect();
            
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
        
            // E3102. C# Program to Display the ATM Transaction
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
        
        
        
            // E3102. Add two numbers in a file. 
            // Nu am stiut
            
            
            
       


        
