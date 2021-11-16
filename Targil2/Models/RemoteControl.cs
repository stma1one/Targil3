using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil2.Models

{
   public  class RemoteControl
    {
        
       public  enum Status
        {
            On = 0,
            Off = 1
        };
        #region attributes
        private int _temperture;
        #endregion

        #region properties

        public static int MAX_TEMPERTURE { get; set; }
        public static int MIN_TEMPERTURE { get; set; }
        public int Temperture
        {
            get { return _temperture; }
            set
            {
                if (value > MAX_TEMPERTURE || value < MIN_TEMPERTURE)
                    throw new ArgumentOutOfRangeException($"טמפרטורה חייבת להיות בין {MAX_TEMPERTURE} - {MIN_TEMPERTURE}");
                else
                    _temperture = value;
            }

        }

        public Status status { get; set; }
        #endregion

        #region C'tor
        public RemoteControl()
        {
            MIN_TEMPERTURE = 16;
            MAX_TEMPERTURE = 32;
            Temperture = MIN_TEMPERTURE;
            status = Status.Off;
        }
        #endregion
    }
}