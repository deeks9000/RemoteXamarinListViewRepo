using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinListViewTutorial
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;  // local container for the items will be 'fed' to the ListView control as the visible content
        private Context mContext;


        //
        // CONSTRUCTOR
        //
        public MyListViewAdapter(Context context, List<Person> items)
        {
            this.mContext = context;

            this.mItems = items;
        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }
        
        public override long GetItemId(int position)
        {
            return position;
        }

        public override Person this[int position]
        {
            get
            {
                return this.mItems[position];
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;  // re-use a previously built row (ie a View object)

            if (row == null)
            {
                row = LayoutInflater.FromContext(mContext).Inflate(Resource.Layout.MyListViewRow, null, false);
            }

            // Get the txtName instance of type TextView from this instance of MyListViewRow
            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.txtFirstName);
            txtFirstName.Text = this.mItems[position].FirstName;

            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = this.mItems[position].LastName;

            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = this.mItems[position].Age;

            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = this.mItems[position].Gender;
            
            return row;
        }
    }
}