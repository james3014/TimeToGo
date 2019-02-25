using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MapsService.Libs.Models
{
    [DataContract]
    public class MapModel
    {
        public IEnumerable<Data> Data { get; set; }
    }
}
