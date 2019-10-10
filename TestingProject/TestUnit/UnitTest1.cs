using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingProject;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        //add int to empty list
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
        //add two ints to empty list
        public void Add_TwoToEmptyList_ItemGoesToIndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int expectedTwo = 11;
            int actual;

            //act
            testList.Add(12);
            testList.Add(11);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, expectedTwo, actual);
        }

        // remove method test 1
        [TestMethod]
        public void RemoveInteger()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 9;


            //act
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
            testList.Remove(5);
            int actual = testList.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        //remove method 2, removing two integers
        [TestMethod]
        public void RemoveTwoIntegers()
        {    //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int expectedTwo = 3;
    
           
           //act
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
            testList.Remove(5);
            testList.Remove(3);
            int actual = testList.Count;
            expected = testList.Count;
            expectedTwo = testList.Count;
             //assert
            Assert.AreEqual(expected, expectedTwo, actual);
        }

            [TestMethod]
        public void ConToString()
        {
        CustomList<string> testList = new CustomList<string>();
        string expected = "Trombone";
            testList.Add("Tro");
            testList.Add("mbo");
            testList.Add("ne");
            string actual = testList.ToString();
            Assert.AreEqual(expected, actual);

            

        }
     }
    }

       



