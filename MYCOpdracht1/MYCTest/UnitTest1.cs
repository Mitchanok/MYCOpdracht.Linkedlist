using System.Collections.Generic;
using MYCOpdracht1;
using NUnit;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace MYCTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void When_i_Add_One_Element_Count_Should_Be_one()
        {
            var mylist = new MyLinkedList<int>();
            mylist.Add(456);
            mylist.Count().Should().Be(1);
        }


        [Test]
        public void When_i_Add_Two_Element_Count_Should_Be_Two()
        {
            MyLinkedList<int> mylist = new MyLinkedList<int>();
            mylist.Add(456);
            mylist.Add(55);
            mylist.Count().Should().Be(2);
        }


        [Test]
        public void List_Count_Should_Be_Zero_When_I_Clear()
        {
            //assign
            var mylist = new MyLinkedList<int>();

            mylist.Add(222);
            mylist.Clear();
            mylist.Count().Should().Be(0);
        }


        [Test]
        public void When_I_Insert_Six_Contain_Should_Be_Six()
        {
            //assign
            var mylist = new MyLinkedList<int>();
            mylist.Add(77);
            mylist.Add(2);
            mylist.Add(5);
            mylist.Add(8);
            mylist.Insert(3,6);
            mylist.Contains(6).Should().BeTrue();


        }

        [Test]
        public void When_I_Insert_Six_Contain_Should_Be_Six_Index_Should_Be_Three()
        {
            //assign
            var mylist = new MyLinkedList<int>();
            mylist.Add(77);
            mylist.Add(2);
            mylist.Add(5);
            mylist.Add(8);
            mylist.Insert(3, 6);
            var index = mylist.IndexOf(6);
            mylist.Contains(6).Should().BeTrue();
            index.Should().Be(3);

        }


        [Test]
        public void When_I_Add_One_Remove_One()
        {
            //assign
            var mylist = new MyLinkedList<int>();

            mylist.Add(1);
            mylist.Remove(1);
            mylist.Count().Should().Be(0);
        }

        [Test]
        public void When_I_Add_Two_Remove_Two()
        {
            //assign
            var mylist = new MyLinkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Remove(1);
            mylist.Remove(2);
            mylist.Count().Should().Be(0);
        }


       
        

        [Test]
        public void IndexOf_Return_Correct_Index_when_Element_Exists()
        {
            //assign
            var mylist = new MyLinkedList<int>();

            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            

            int index = mylist.IndexOf(20);

            
        }

    }
}