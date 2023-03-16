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
            if (carre.Longueur != 0) Assert.Fail("Erreur de constructeur par defaut du carr�");
        }

        [TestMethod]
        public void TestSurface()
        {
            Carre carre = new Carre();
            carre.Longueur = 5;
            if (MathUtil.Surface(carre) != 25) Assert.Fail("Erreur de calcul de la m�thode surface de mathlib pour le carr� !");
        }

        [TestMethod]
        public void TestCompare()
        {
            Carre carre1 = new Carre();
            Carre carre2 = new Carre();

            if (carre1.CompareTo(carre2) != 0) Assert.Fail("Erreur de comparaison : devrait �tre �gaux !");
            carre1.Longueur = 5;
            if (carre1.CompareTo(carre2) < 0) Assert.Fail("Erreur de comparaison : carr� 1 devait �tre plus grand que carr� 2 !");
            carre2.Longueur = 10;
            if (carre1.CompareTo(carre2) > 0) Assert.Fail("Erreur de comparaison : carr� 2 devait �tre plus grand que carr� 1 !");
        }

        [TestMethod]
        public void TestPointDans()
        {
            Carre carre = new Carre();
            carre.Longueur = 5;
            if (!carre.CoordonneeEstDans(new Coordonnees(5,5))) Assert.Fail("La coordon�e � la limite x et y n'est pas consid�r�e comme faisant partie du carr� !");
            if (carre.CoordonneeEstDans(new Coordonnees(6, 6))) Assert.Fail("La coordon�e en dehors de la limite x et y est consid�r�e comme faisant partie du carr� !");
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
                if (listCarre[nbr].CompareTo(listCarre[nbr+1]) >= 0) Assert.Fail("La liste est mal tri�e !"); ;
            }
        }
    }
}