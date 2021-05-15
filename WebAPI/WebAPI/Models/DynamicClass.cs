using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DynamicClass
    {
    }
    /// Dynamic List DTO
    /// </summary>
    public class DynamicListDTO
    {
        public List<dynamic> thisList { get; set; }
        public string errorMessage { get; set; }
    }

    /// <summary>
    /// Dynamic Single Record DTO
    /// </summary>
    public class DynamicRecordDTO
    {
        public dynamic thisRecord { get; set; }
        public string errorMessage { get; set; }
    }

}
