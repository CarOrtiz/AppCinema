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

namespace CinemaDCO.Domain
{
   public class Funcion
    {
        public string Cinema { get; set; }
        public string Sala { get; set; }
        public string Ciudad { get; set; }
        public int Precio { get; set; }
    }
}