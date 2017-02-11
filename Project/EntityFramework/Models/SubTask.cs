using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class SubTask
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public int TaskID { get; set; }
        public Task Task { get; set; }
    }
}
