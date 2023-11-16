using Blockwoche;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Blockwoche.Tests
{
    [TestClass]
    public class SchuelerCrudTests
    {
        [TestMethod]
        public void TestSchuelerCreate()
        {
            using (var dbContext = new BlockwocheContext())
            {
                
                var schuelerName = "TestSchueler";

                
                var newSchueler = new Schueler { Name = schuelerName };
                dbContext.Schueler.Add(newSchueler);
                dbContext.SaveChanges();

                
                var retrievedSchueler = dbContext.Schueler.FirstOrDefault(s => s.Name == schuelerName);
                Assert.IsNotNull(retrievedSchueler, "Schueler wurde nicht korrekt erstellt.");
            }
        }

        [TestMethod]
        public void TestSchuelerRead()
        {
            using (var dbContext = new BlockwocheContext())
            {
                var schuelerList = dbContext.Schueler.ToList();   

                
                Assert.IsNotNull(schuelerList, "Schuelerliste sollte nicht null sein.");
                Assert.IsTrue(schuelerList.Count > 0, "Es sollten Schueler in der Liste sein.");
            }
        }

        [TestMethod]
        public void TestSchuelerDelete()
        {
            using (var dbContext = new BlockwocheContext())
            {

                var schuelerName = "TestSchueler";


                
                var retrievedSchueler = dbContext.Schueler.FirstOrDefault(s => s.Name == schuelerName);
                Assert.IsNotNull(retrievedSchueler, "Schueler wurde nicht korrekt erstellt.");


                if (retrievedSchueler != null)
                {
                    dbContext.Schueler.Remove(retrievedSchueler);
                    dbContext.SaveChanges();
                }

                var deletedSchueler = dbContext.Schueler.FirstOrDefault(s => s.Name == schuelerName);
                Assert.IsNull(deletedSchueler, "Schueler wurde nicht korrekt gelöscht.");

            }
        }
    }
}

