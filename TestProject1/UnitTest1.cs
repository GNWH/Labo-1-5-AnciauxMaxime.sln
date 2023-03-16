using Labo_1AnciauxMaxime.sln;

namespace TestProject1
{
    [TestClass]
    public class UnitTestCarre
    {
        [TestMethod]
        public void TestConstruct()
        {
            Carre carre = new Carre();
            if (carre.Longueur != 0) Assert.Fail("Erreur de constructeur par defaut du carré");
        }

        [TestMethod]
        public void TestSurface()
        {
            Carre carre = new Carre();
            carre.Longueur = 5;
            if (MathUtil.Surface(carre) != 25) Assert.Fail("Erreur de calcul de la méthode surface de mathlib pour le carré !");
        }

        [TestMethod]
        public void TestCompare()
        {
            Carre carre1 = new Carre();
            Carre carre2 = new Carre();

            if (carre1.CompareTo(carre2) != 0) Assert.Fail("Erreur de comparaison : devrait être égaux !");
            carre1.Longueur = 5;
            if (carre1.CompareTo(carre2) < 0) Assert.Fail("Erreur de comparaison : carré 1 devait être plus grand que carré 2 !");
            carre2.Longueur = 10;
            if (carre1.CompareTo(carre2) > 0) Assert.Fail("Erreur de comparaison : carré 2 devait être plus grand que carré 1 !");
        }

        [TestMethod]
        public void TestPointDans()
        {
            Carre carre = new Carre();
            carre.Longueur = 5;
            if (!carre.CoordonneeEstDans(new Coordonnees(5,5))) Assert.Fail("La coordonée à la limite x et y n'est pas considérée comme faisant partie du carré !");
            if (carre.CoordonneeEstDans(new Coordonnees(6, 6))) Assert.Fail("La coordonée en dehors de la limite x et y est considérée comme faisant partie du carré !");
        }

        [TestMethod]
        public void TestSors()
        {
            List<Carre> listCarre = new List<Carre>();
            listCarre.Add(new Carre());
            listCarre.Add(new Carre(new Coordonnees(), 1));
            listCarre.Add(new Carre(new Coordonnees(), 5));
            listCarre.Add(new Carre(new Coordonnees(),2));
            listCarre.Add(new Carre(new Coordonnees(), 4));
            listCarre.Add(new Carre(new Coordonnees(), 3));
            listCarre.Sort();

            foreach (var nbr in Enumerable.Range(0, 4))
            {
                if (listCarre[nbr].CompareTo(listCarre[nbr+1]) >= 0) Assert.Fail("La liste est mal triée !"); ;
            }
        }
    }
}