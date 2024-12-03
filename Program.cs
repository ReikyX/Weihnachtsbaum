namespace Weihnachtsbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MeinProgramm();
            Korrektur();
        }
        static void Aufgabe()
        {
            //Stufe1:
            //
            //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
            //Du kannst dir das Aussehen des Baums selber aussuchen
            //Nutze für die Ausgabe Schleifen.
            //
            //Beispiel:
            //       x
            //      xxx
            //     xxxxx
            //    xxxxxxx
            //   xxxxxxxxx
            //  xxxxxxxxxxx
            //      xxx
            //      xxx

            //Stufe 2:
            //
            //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
            //Nutze ggf. Farben.

            //Stufe 3: 
            //
            //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

            //Stufe 4:
            //
            //Lass den Baum Blinken und Funkeln
            //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.
        }
        static void MeinProgramm()
        {
            string[] gruß = { "„Frohe Weihnachten und ein glückliches neues Jahr!“", "„Genieße die besinnliche Zeit im Kreise deiner Lieben!“", "„Möge dein Herz in dieser festlichen Zeit leuchten!“", "„Wünsche dir frohe Feiertage und viel Freude!“", "„Besinnliche Weihnachten und einen guten Rutsch ins neue Jahr!“", "„Weihnachten ist Liebe – und du bist ein Teil davon!“", "„Frohes Fest! Mögen deine Wünsche in Erfüllung gehen!“", "„Wärme, Frieden und Freude – das wünsche ich dir zu Weihnachten!“", "„Die besten Geschenke sind die, die wir miteinander teilen.“", "„Frohe Weihnachten! Lass uns die Zeit genießen!“" };
            Random zufall = new Random();
            //Console.ForegroundColor = (ConsoleColor)new Random().Next();


            string[] weihnachtsbaum = {
                @"                    *",
                @"                   /^\",
                @"                  /* *\",
                @"                 /* ° *\",
                @"                /° * * °\",
                @"               /* ° * ° *\",
                @"              /° * ° ° * °\",
                @"             /° * * ° * * °\",
                @"            /° * ° * * ° * °\",
                @"           *******************",
                @"                   |||"
            };


            while (true)
            {
                Console.Clear();

                foreach (string line in weihnachtsbaum)
                {
                    foreach (char x in line)
                    {
                        if (x == '°')
                        {
                            Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
                            Console.Write('°');
                            Console.ResetColor();
                        }
                        else if (x == '/' || x == '\\' || x == '^' || x == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(x);
                            Console.ResetColor();
                        }
                        else if (x == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(x);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(x);
                        }
                    }
                    Console.WriteLine();
                }

                int zufallIndex = zufall.Next(gruß.Length);
                string zufallsText = gruß[zufallIndex];
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, weihnachtsbaum.Length + 2);
                Console.WriteLine($"{zufallsText}                                                           ");
                Console.ResetColor();
                Thread.Sleep(2000);
            }
        }
        static void Korrektur()
        {
            //Stufe1:

            string[] baum = { "       x", "      xxx", "     xxxxx", "    xxxxxxx", "   xxxxxxxxx", "  xxxxxxxxxxx", "      xxx", "      xxx" };
            foreach (string s in baum)
            {
                Console.WriteLine(s);
            }

            //Stufe2:

            string[] gruss = { "Frohe Weihnachten!", "Es Weichnachtet! OMG!", "Stille Nacht! Heilige Nacht!" };

            Random rand = new Random();
            int auswahl = rand.Next(0, gruss.Length);

            Console.ForegroundColor = (ConsoleColor)rand.Next(1, 1);
            Console.WriteLine(gruss[auswahl]);
            Console.ResetColor();

            //Stufe3:

            while (true)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.ResetColor();

                foreach (string s in baum)
                {
                    Console.WriteLine(s);
                }

                int letzeAuswahl = auswahl;
                while (true)
                {
                    auswahl = rand.Next(0, gruss.Length);
                    if (auswahl != letzeAuswahl)
                    {
                        break;
                    }

                }
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.WriteLine(gruss[auswahl]);


                //Stufe 4:

                Console.SetCursorPosition(7, 1);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(6, 2);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(8, 2);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(5, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(7, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(9, 3);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(4, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(6, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(8, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(10, 4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(3, 5);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(5, 5);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(7, 5);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(9, 5);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");

                Console.SetCursorPosition(11, 5);
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                Console.Write("o");


            }
        }
    }
}

