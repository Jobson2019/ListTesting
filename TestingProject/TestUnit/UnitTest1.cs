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
        //check count
        //more integers
        //items listing
        //add three
        [TestMethod]
        public void Add_ThreeToEmptyList_ItemGoesToIndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int expectedTwo = 9;
            int expectedThree = 7;
            int actual;

            //act
            testList.Add(8);
            testList.Add(9);
            testList.Add(7);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, expectedTwo, expectedThree);
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
            int actual;

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
            actual = testList.Count;
            expected = testList.Count;
            expectedTwo = testList.Count;
            //assert
            Assert.AreEqual(expected, expectedTwo, actual);
        }

        // idea remove 2, and only have method remove the first instance of 2

        // idea, in remove 2 in list of 5, return true/false via bool
        [TestMethod]
        public void RemoveAndReturn()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;
            //act
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            actual = testList.Remove(2);

            //assert
            Assert.AreEqual(actual, expected);


        }


        //convert to string test

        [TestMethod]
        public void ConToString()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "Trombone";
            //act
            testList.Add("Tro");
            testList.Add("mbo");
            testList.Add("ne");
            string actual = testList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        //convert to String Test Two
        [TestMethod]
        public void ConToStringTwo()
        {
            CustomList<string> testList = new CustomList<string>();
            string expected = "God Dammit Randy";
            testList.Add("God ");
            testList.Add("Dammit ");
            testList.Add("Randy");
            string actual = testList.ToString();
            Assert.AreEqual(expected, actual);
        }

        //overload minus operator
        //   [TestMethod]
        //   public void MinusOverloadOne()
        //       CustomList<string> testListOne = new CustomList<string>();
        //       CustomList<string> testListTwo = new CustomList<string>();
        //        CustomList<string> testListThree = new CustomList<string>();

        //}
    }
}

       



