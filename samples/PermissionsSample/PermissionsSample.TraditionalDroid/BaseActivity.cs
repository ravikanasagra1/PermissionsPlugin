
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Plugin.Permissions;
using Android.Content.PM;

namespace PermissionsSample.TraditionalDroid
{
    public abstract class BaseActivity : AppCompatActivity
    {
        public Toolbar Toolbar
        {
            get;
            set;
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(LayoutResource);
            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (Toolbar != null)
            {
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetHomeButtonEnabled(true);

            }
        }

        protected abstract int LayoutResource
        {
            get;
        }

        protected int ActionBarIcon
        {
            set { Toolbar.SetNavigationIcon(value); }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

}