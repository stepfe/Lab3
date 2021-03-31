using NUnit.Framework;
using Laba3;
namespace Test3
{
    public class Tests
    {
        private Sorter sorter;
        [SetUp]
        public void Setup()
        {
            sorter = new Sorter();
        }

        [Test]
        public void RANDOM_SORT()
        {
            bool isOk = true;
            int[] a = { 0, 5, 2, 4, 1, 6, 3 };
            
            sorter.sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a[i])
                {
                    isOk = false;
                }
            }
            Assert.AreEqual(true, isOk);
        }

        [Test]
        public void REVERSE()
        {
            bool isOk = true;
            int[] a = { 6, 5, 4, 3, 2, 1, 0 };
            Sorter sorter = new Sorter();
            sorter.sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a[i])
                {
                    isOk = false;
                }
            }
            Assert.AreEqual(true, isOk);
        }

        [Test]
        public void ALREDY_SORTED()
        {
            bool isOk = true;
            int[] a = { 0, 1, 2, 3, 4, 5 };
            Sorter sorter = new Sorter();
            sorter.sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a[i])
                {
                    isOk = false;
                }
            }
            Assert.AreEqual(true, isOk);
        }
    }
}