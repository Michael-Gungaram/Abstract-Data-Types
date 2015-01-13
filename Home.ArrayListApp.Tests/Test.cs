using NUnit.Framework;
using System;

namespace Home.ArrayListApp.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void create_a_list_with_the_right_capacity()
        {
            ArrayList<int> array = new ArrayList<int>(5);
            int sizeOf = array.Count;
            Assert.That(sizeOf, Is.EqualTo( 5 ) );
        }

        // Unit Test on iteration 1

        //[Test]
        //public void add_an_element_above_the_capacity_throws_ArgumentOutOfRangeException()
        //{
        //    ArrayListInt myArr = new ArrayListInt(2);
        //    myArr.Add(1);
        //    myArr.Add(2);
        //    Assert.Throws<ArgumentOutOfRangeException>(() => { myArr.Add(3); });
        //}

        [Test]
        public void is_the_right_value()
        {
            ArrayList<int> myArr = new ArrayList<int>(3);
            myArr.Add(2);
            int value = myArr.GetItem(0);
            Assert.That(value, Is.EqualTo(2));
        }

        [Test]
        public void setItem_is_working_well()
        {
            ArrayList<int> myArr = new ArrayList<int>(3);
            myArr.Add(12);
            int value = myArr.GetItem( 0 );
            Assert.That( value, Is.EqualTo( 12 ) );

            myArr.SetItem(0, 15);
            int newValue = myArr.GetItem( 0 );
            Assert.That(newValue, Is.EqualTo(15));
        }

        [Test]
        public void set_an_item_at_a_negative_index_or_above_the_arrayList_capacity_throws_ArgumentOutOfRangeException()
        {
            ArrayList<int> myArr = new ArrayList<int>(3);
            Assert.Throws<ArgumentOutOfRangeException>( () => { myArr.SetItem(58, 23); });
            Assert.Throws<ArgumentOutOfRangeException>( () => { myArr.SetItem(-255, 25); } );
        }        

        [Test]
        public void get_an_item_at_a_negative_index_or_above_the_arrayList_capacity_throws_ArgumentOutofRangeException()
        {
            int value = 0;
            ArrayList<int> array = new ArrayList<int>(3);
            array.Add(22);
            array.Add(67);
            array.Add(45);
            Assert.Throws<ArgumentOutOfRangeException>( () => { value = array.GetItem( 3 ); } );
        }

        [Test]
        public void insert_at_an_index_and_get_the_right_element()
        {
            int value = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;

            ArrayList<int> array = new ArrayList<int>(3);

            array.Add(5);
            array.Add(10);
            array.Add(15);
            array.Add(20);
            array.Insert(0, 10);

            value = array.GetItem(0);
            value2 = array.GetItem(1);
            value3 = array.GetItem(2);
            value4 = array.GetItem(3);

            Assert.That(value == 10);
            Assert.That(value2 == 10);
            Assert.That(value3 == 15);
            Assert.That(value4 == 20);
        }

        // Unit Test on iteration 2
        //[Test]
        //public void insert_at_over_arrayList_capacity_throws_ArgumentOutOfRangeException()
        //{
        //    ArrayListInt array = new ArrayListInt(4);

        //    array.Add(5);
        //    array.Add(10);
        //    array.Add(15);
        //    array.Add(20);

        //    Assert.Throws<ArgumentOutOfRangeException> ( () => array.Insert(5, 10) );
        //    Assert.Throws<ArgumentOutOfRangeException>(() => array.Insert(-1, 10));
        //}
        
        [Test]
        public void well_removed()
        {
            ArrayList<int> array = new ArrayList<int>(3);
            int value = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;

            array.Add(5);
            array.Add(10);
            array.Add(15);

            array.RemoveAt(1);

            value = array.Count;
            value2 = array.GetItem(0);
            value3 = array.GetItem(1);

            Assert.That( value == 2 );
            Assert.That( value3 == 15 );
        }

        [Test]
        public void remove_out_capabilites_of_arrayList_throws_ArgumentException()
        {
            ArrayList<int> array = new ArrayList<int>(3);

            array.Add(5);
            array.Add(10);
            array.Add(15);

            Assert.Throws<ArgumentException>( () => array.RemoveAt( 5 ) );
            Assert.Throws<ArgumentException>( () => array.RemoveAt( -8 ) );
        }

        [Test]
        public void clear_the_arrayList_correctly()
        {
            ArrayList<int> array = new ArrayList<int>(3);

            array.Add(5);
            array.Add(10);
            array.Add(15);
            array.Add(20);

            array.Clear();

            int value = array.Count;
            int index = array.GetIndex;
            array.Add(3712);
            int number = array.GetItem(0);

            Assert.That(value, Is.EqualTo(6));
            Assert.That(index, Is.EqualTo(0));
            Assert.That(number == 3712);
        }

        [Test]
        public void now_can_add_an_element_even_the_arrayList_is_full()
        {
            ArrayList<int> array = new ArrayList<int>(3);

            array.Add(5);
            array.Add(10);
            array.Add(15);
            array.Add(20);

            int value = array.Count;
            int number = array.GetItem(3);

            Assert.That(value == 6);
            Assert.That( number, Is.EqualTo(20) );
        }

        [Test]
        public void now_can_insert_into_the_arrayList_even_its_full()
        {
            ArrayList<int> array = new ArrayList<int>(3);
            array.Add(10);
            array.Add(20);
            array.Add(30);

            array.Insert(1, 21);
            int size = array.Count;
            int number = array.GetItem(1);

            Assert.That(size, Is.EqualTo( 6 ));
            Assert.That(number == 21);
        }

        [Test]
        public void test_of_the_indexer_implemented()
        {
            ArrayList<int> array = new ArrayList<int>(3);
            array.Add(1);
            array.Add(2);
            array.Add(3);

            int value = array[1];
            array[2] = 6;
            int changedValue = array[2];

            Assert.That( value == 2 );
            Assert.That( changedValue == 6);
        }
    }
}