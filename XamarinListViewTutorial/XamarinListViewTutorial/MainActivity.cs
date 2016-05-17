using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamarinListViewTutorial
{
    [Activity(Label = "XamarinListViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our activity's content view from the "main" layout resource
            SetContentView(XamarinListViewTutorial.Resource.Layout.Main);

            // Get our ListView from the layout resource
            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<Person>();
            mItems.Add(new Person { FirstName = "Bob", LastName = "White", Age = "42", Gender = "Male" });
            mItems.Add(new Person { FirstName = "Harry", LastName = "Potter", Age = "18", Gender = "Male" });
            mItems.Add(new Person { FirstName = "John", LastName = "Lennon", Age = "41", Gender = "Male" });
            mItems.Add(new Person { FirstName = "Chris", LastName = "Barry", Age = "37", Gender = "Male" });
            mItems.Add(new Person { FirstName = "Sarah", LastName = "Conner", Age = "21", Gender = "Female" });
            mItems.Add(new Person { FirstName = "Louise", LastName = "Davis", Age = "12", Gender = "Female" });
            mItems.Add(new Person { FirstName = "Jack", LastName = "Shepard", Age = "37", Gender = "Male" });
            mItems.Add(new Person { FirstName = "Vicky", LastName = "Vale", Age = "36", Gender = "Female" });
            mItems.Add(new Person { FirstName = "Betty", LastName = "Boop", Age = "80", Gender = "Female" });
            mItems.Add(new Person { FirstName = "Bridget", LastName = "Jones", Age = "40", Gender = "Female" });
            mItems.Add(new Person { FirstName = "Fred", LastName = "Flintstone", Age = "78", Gender = "Male" });
            mItems.Add(new Person { FirstName = "Elizabeth", LastName = "Windsor", Age = "42", Gender = "Female" });
            mItems.Add(new Person { FirstName = "David", LastName = "Weyland", Age = "8", Gender = "Male" });


            // Recall that: 
            // Android.Resource.Layout.SimpleListItem1   
            // is simply an integer ID value describing the pre-built Android layout of child views for a simple list item 
            // typically for use with a ListView
            // ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            MyListViewAdapter adapter = new MyListViewAdapter(this, this.mItems);

            mListView.Adapter = adapter;

            mListView.ItemClick += mListView_ItemClick;          
        }

        private void mListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].FirstName);
        }
    }
}

