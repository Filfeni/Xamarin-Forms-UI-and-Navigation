using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_UI_Navigation
{
    public class HomeMasterMenuItem
    {
        public HomeMasterMenuItem()
        {
            TargetType = typeof(HomeMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}