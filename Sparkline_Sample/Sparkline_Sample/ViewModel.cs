using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Sparkline_Sample
{
    public class ViewModel
    {
        public List<Model> Data { get; set; }
        public ViewModel()
        {
            Data = new List<Model>();
            Data.Add(new Model() { Performance = 3000 });
            Data.Add(new Model() { Performance = 5000 });
            Data.Add(new Model() { Performance = -3000 });
            Data.Add(new Model() { Performance = -4000 });
            Data.Add(new Model() { Performance = 2000 });
            Data.Add(new Model() { Performance = 3000 });
        }
    }
}