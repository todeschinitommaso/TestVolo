using pausadidattica1;

namespace TestVolo
{
    public class UnitTest1
    {
        volo v;
        [Fact]
        public void Test1()
        {
            DateTime b = new DateTime(12, 10, 22);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", b);
            int a = v.NumPosti();
            Assert.True(a >= 100 && a <= 200);
        }

        [Fact]
        public void Test2()
        {
            int a = v.Costo();
            Assert.True(a >= 9 && a <= 20);
        }

        [Fact]
        public void Test3()
        {
            DateTime a = new DateTime(12, 10, 23);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", a);
            Assert.True(v.Prezzo == 140);
        }

        [Fact]
        public void Test4()
        {
            DateTime a = new DateTime(12, 10, 23);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", a);
            Assert.True(v.Codice == "AAbbb012");
        }

        [Fact]
        public void Test5()
        {
            DateTime a = new DateTime(12, 10, 23);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", a);
            Assert.True(v.Posti == 15);
        }

        [Fact]
        public void Test6()
        {
            DateTime a = new DateTime(12, 10, 23);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", a);
            Assert.True(v.Partenza == "Milano");
        }

        [Fact]
        public void Test7()
        {
            DateTime a = new DateTime(12, 10, 23);
            v = new volo("AAbbb012", 140, 15, "Milano", "Londra", a);
            Assert.True(v.Destinazione == "Londra");
        }
    }
}