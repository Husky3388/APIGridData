using System;
namespace APIGridData.Models
{
    public class Record
    {
        public int id { get; set; }
        public string name { get; set; }

        public Record(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
