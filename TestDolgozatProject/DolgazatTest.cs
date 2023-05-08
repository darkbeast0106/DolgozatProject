namespace TestDolgozatProject
{
    public class DolgazatTest
    {
        Dolgozat dolgozat;
        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void PontFelvesz_MinimumAlatt()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                dolgozat.PontFelvesz(-2);
            });
        }

        [Test]
        public void PontFelvesz_MaximumFelett()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                dolgozat.PontFelvesz(101);
            });
        }

        [Test]
        public void PontFelvesz_Minimum()
        {
            Assert.DoesNotThrow(() =>
            {
                dolgozat.PontFelvesz(-1);
            });
        }

        [Test]
        public void PontFelvesz_Maximum()
        {
            Assert.DoesNotThrow(() =>
            {
                dolgozat.PontFelvesz(100);
            });
        }

        [Test]
        public void MindenkiMegirta_EgyTanuloIrt()
        {
            dolgozat.PontFelvesz(50);
            Assert.IsTrue(dolgozat.MindenkiMegirta);
        }

        [Test]
        public void MindenkiMegirta_EgyTanuloNullaPont()
        {
            dolgozat.PontFelvesz(0);
            Assert.IsTrue(dolgozat.MindenkiMegirta);
        }

        [Test]
        public void MindenkiMegirta_EgyTanuloNemIrt()
        {
            dolgozat.PontFelvesz(-1);
            Assert.IsFalse(dolgozat.MindenkiMegirta);
        }


        [Test]
        public void MindenkiMegirta_TobbTanuloIrt()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(100);
            dolgozat.PontFelvesz(20);
            dolgozat.PontFelvesz(32);
            dolgozat.PontFelvesz(40);
            dolgozat.PontFelvesz(55);
            Assert.IsTrue(dolgozat.MindenkiMegirta);
        }

        [Test]
        public void MindenkiMegirta_TobbTanuloNullaPontVan()
        {
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(70);
            dolgozat.PontFelvesz(32);
            dolgozat.PontFelvesz(100);
            Assert.IsTrue(dolgozat.MindenkiMegirta);
        }

        [Test]
        public void MindenkiMegirta_TobbTanuloValakiNemIrt()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(42);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(100);
            Assert.IsFalse(dolgozat.MindenkiMegirta);
        }

        [Test]
        public void Bukas_Minimum()
        {
            Assert.AreEqual(0, dolgozat.Bukas);
            dolgozat.PontFelvesz(0);
            Assert.AreEqual(1, dolgozat.Bukas);
        }
        [Test]
        public void Bukas_MinimumAlatt()
        {
            Assert.AreEqual(0, dolgozat.Bukas);
            dolgozat.PontFelvesz(-1);
            Assert.AreEqual(0, dolgozat.Bukas);
        }
        [Test]
        public void Bukas_Maximum()
        {
            Assert.AreEqual(0, dolgozat.Bukas);
            dolgozat.PontFelvesz(49);
            Assert.AreEqual(1, dolgozat.Bukas);
        }
        [Test]
        public void Bukas_MaximumFelett()
        {
            Assert.AreEqual(0, dolgozat.Bukas);
            dolgozat.PontFelvesz(50);
            Assert.AreEqual(0, dolgozat.Bukas);
        }

        [Test]
        public void Bukas_TobbPontEsetenMegfeleloenSzamol()
        {
            Assert.AreEqual(0, dolgozat.Bukas);
            dolgozat.PontFelvesz(75);
            dolgozat.PontFelvesz(55);
            dolgozat.PontFelvesz(45);
            dolgozat.PontFelvesz(65);
            dolgozat.PontFelvesz(25);
            Assert.AreEqual(2, dolgozat.Bukas);
        }

    }
}