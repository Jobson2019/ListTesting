﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingProject;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
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
            int expected = 1;
            int actual;
           
            // act
            testList.Add(234);
            testList.Add(300);
            testList.Add(500);
            testList.Add(800);
            actual = testList.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]


       
    }
    }
