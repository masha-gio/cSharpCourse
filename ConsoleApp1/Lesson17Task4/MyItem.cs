using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Task4
{
    internal class MyItem
    {
        [JsonProperty("MyAge")]
        public int Age {  get; set; }

        [JsonIgnore]
        public string Name { get; set; }
    }
}
