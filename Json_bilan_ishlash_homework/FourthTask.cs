using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_bilan_ishlash_homework
{
    public class FourthTask
    {
        public List<DataPerson> speakers { get; set; }
    }
    public class DataPerson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string link { get; set; }
        public string bio { get; set; }
        public string description { get; set; }
    }
}

