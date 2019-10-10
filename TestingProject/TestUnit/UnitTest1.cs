using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingProject;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        private T[] items;
        [TestMethod]



        
     
        
            public void Add_AddToEmptyList_ItemGoesToIndexZero()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 12;
                int actual;
                // act
                testList.Add(12);
                actual = testList[0];
                // assert
                Assert.AreEqual(expected, actual);
            }
       [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            
           
            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(10);
            int actual = testList [3];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;


            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(10);
            int actual = testList[3];
            // assert
            Assert.AreEqual(expected, actual);
        }



