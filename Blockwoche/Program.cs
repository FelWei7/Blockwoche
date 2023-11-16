using System;
using System.Linq;

namespace Blockwoche
{
    class Program
    {
        static void Main()
        {
            bool exitProgram = false;


            do
            {
                Console.WriteLine("Welche Tabelle möchten Sie bearbeiten (1: Schueler, 2: Lehrer, 3: Buch, 4: Beenden):");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        SchuelerCRUD();
                        break;

                    case 2:
                        LehrerCRUD();
                        break;

                    case 3:
                        BuchCRUD();
                        break;

                    case 4:
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }

            } while (!exitProgram);
        }

        static void SchuelerCRUD()
        {
            using (var dbContext = new BlockwocheContext())
            {
                Console.WriteLine("Schueler bearbeiten:");
                Console.WriteLine("1: Hinzufügen, 2: Anzeigen, 3: Aktualisieren, 4: Löschen, 5: Zurück");

                int schuelerAction = int.Parse(Console.ReadLine());


                switch (schuelerAction)
                {
                    case 1:
                        Console.WriteLine("Schueler hinzufügen");
                        Console.WriteLine("Name:");

                        string schuelerName = Console.ReadLine();

                        var newSchueler = new Schueler { Name = schuelerName };

                        dbContext.Schueler.Add(newSchueler);
                        dbContext.SaveChanges();
                        break;

                    case 2:
                        Console.WriteLine("Schueler anzeigen:");
                        foreach (var schueler in dbContext.Schueler)
                        {
                            Console.WriteLine(schueler.Name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Schueler aktualisieren:");
                        Console.WriteLine("Name des zu aktualisierenden Schuelers:");

                        string oldSchuelerName = Console.ReadLine();

                        var schuelerToUpdate = dbContext.Schueler.FirstOrDefault(s => s.Name == oldSchuelerName);

                        if (schuelerToUpdate != null)
                        {
                            Console.WriteLine("Neuer Name:");

                            string newSchuelerName = Console.ReadLine();

                            schuelerToUpdate.Name = newSchuelerName;

                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Schueler nicht gefunden.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Schueler löschen:");
                        Console.WriteLine("Name des zu löschenden Schuelers:");

                        string schuelerToDeleteName = Console.ReadLine();

                        var schuelerToDelete = dbContext.Schueler.FirstOrDefault(s => s.Name == schuelerToDeleteName);

                        if (schuelerToDelete != null)
                        {
                            dbContext.Schueler.Remove(schuelerToDelete);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Schueler nicht gefunden.");
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Ungültige Aktion für Schueler.");
                        break;
                }
            }
        }


        static void LehrerCRUD()
        {
            using (var dbContext = new BlockwocheContext())
            {
                Console.WriteLine("Lehrer bearbeiten:");
                Console.WriteLine("Drücken Sie 1: Hinzufügen, 2: Anzeigen, 3: Aktualisieren, 4: Löschen, 5: Zurück");

                int lehrerAction = int.Parse(Console.ReadLine());


                switch (lehrerAction)
                {
                    case 1:
                        Console.WriteLine("Lehrer hinzufügen");
                        Console.WriteLine("Name:");

                        string lehrerName = Console.ReadLine();

                        var newLehrer = new Lehrer { Name = lehrerName };

                        dbContext.Lehrer.Add(newLehrer);
                        dbContext.SaveChanges();
                        break;

                    case 2:
                        Console.WriteLine("Lehrer anzeigen:");
                        foreach (var lehrer in dbContext.Lehrer)
                        {
                            Console.WriteLine(lehrer.Name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Lehrer aktualisieren:");
                        Console.WriteLine("Name des zu aktualisierenden Lehrers:");

                        string oldLehrerName = Console.ReadLine();

                        var lehrerToUpdate = dbContext.Lehrer.FirstOrDefault(l => l.Name == oldLehrerName);

                        if (lehrerToUpdate != null)
                        {
                            Console.WriteLine("Neuer Name:");

                            string newLehrerName = Console.ReadLine();

                            lehrerToUpdate.Name = newLehrerName;

                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Lehrer nicht gefunden.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Lehrer löschen:");
                        Console.WriteLine("Name des zu löschenden Lehrers:");

                        string lehrerToDeleteName = Console.ReadLine();

                        var lehrerToDelete = dbContext.Lehrer.FirstOrDefault(l => l.Name == lehrerToDeleteName);

                        if (lehrerToDelete != null)
                        {
                            dbContext.Lehrer.Remove(lehrerToDelete);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Lehrer nicht gefunden.");
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Ungültige Aktion für Lehrer.");
                        break;
                }
            }
        }

        static void BuchCRUD()
        {
            using (var dbContext = new BlockwocheContext())
            {
                Console.WriteLine("Buch bearbeiten:");
                Console.WriteLine("1: Hinzufügen, 2: Anzeigen, 3: Aktualisieren, 4: Löschen, 5: Zurück");

                int buchAction = int.Parse(Console.ReadLine());

                switch (buchAction)
                {
                    case 1:
                        Console.WriteLine("Buch hinzufügen");
                        Console.WriteLine("Name:");

                        string buchName = Console.ReadLine();

                        var newBuch = new Buch { Name = buchName };

                        dbContext.Buch.Add(newBuch);
                        dbContext.SaveChanges();
                        break;

                    case 2:
                        Console.WriteLine("Buch anzeigen:");
                        foreach (var buch in dbContext.Buch)
                        {
                            Console.WriteLine(buch.Name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Buch aktualisieren:");
                        Console.WriteLine("Name des zu aktualisierenden Buchs:");

                        string oldBuchName = Console.ReadLine();

                        var buchToUpdate = dbContext.Buch.FirstOrDefault(b => b.Name == oldBuchName);

                        if (buchToUpdate != null)
                        {
                            Console.WriteLine("Neuer Name:");

                            string newBuchName = Console.ReadLine();

                            buchToUpdate.Name = newBuchName;

                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Buch nicht gefunden.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Buch löschen:");
                        Console.WriteLine("Name des zu löschenden Buchs:");

                        string buchToDeleteName = Console.ReadLine();

                        var buchToDelete = dbContext.Buch.FirstOrDefault(b => b.Name == buchToDeleteName);

                        if (buchToDelete != null)
                        {
                            dbContext.Buch.Remove(buchToDelete);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Buch nicht gefunden.");
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Ungültige Aktion für Buch.");
                        break;
                }
            }
        }
    }
}
