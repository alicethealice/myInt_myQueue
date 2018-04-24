using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaQ;
namespace MaQTest
{
    [TestClass]
    public class DEQueueTest
    {

        [TestMethod]
        public void testFront_mast_odin_dva_tri()
        {
            DEQueue<string> qwsda=new DEQueue<string>();
            qwsda.pushBack("KAte");
            qwsda.pushBack("LOLQOP");
            Assert.AreEqual(qwsda.front(), "KAte");
        }

        [TestMethod]
        public void test_popfront_a_b_c_d()
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popFront() + qwsda.popFront() + qwsda.popFront()+ qwsda.popFront();
            Assert.AreEqual(a, "abcd");
        }
        [TestMethod]
        public void test_popback_d_c_b_a()
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popBack() + qwsda.popBack() + qwsda.popBack() + qwsda.popBack();
            Assert.AreEqual(a, "dcba");
        }

        [TestMethod]
        public void test_popfront_popback_a_d_b_c()
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popFront() + qwsda.popBack() + qwsda.popFront() + qwsda.popBack();
            Assert.AreEqual(a, "adbc");
        }

        [TestMethod]
        public void test_toArray_a_d_b_c()
        {
            DEQueue<int> qwsda = new DEQueue<int>();
            qwsda.pushBack(1);
            qwsda.pushBack(2);
            qwsda.pushBack(3);
            qwsda.pushBack(4);
            int[] a = new int[4];
            a[0] = 1;a[1] = 2;a[2] = 3;a[3] = 4;
            int[] b = qwsda.toArray();
            //Assert.AreEqual(a, b);
            CollectionAssert.AreEqual(a, b);
        }


    }
}
