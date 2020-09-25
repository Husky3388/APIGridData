using System;
using System.Collections.Generic;
using System.Linq;
using APIGridData.Models;

namespace APIGridData
{
    public static class Data
    {
        public static List<Record> records = new List<Record>();

        static Data()
        {
            LoadMockData();
        }

        static void LoadMockData()
        {
            records = MockData;
        }

        public static void InsertData(Record record)
        {
            records.Add(record);
        }

        public static void UpdateData(int id, Record record)
        {
            Record recordToBeUpdated = records.SingleOrDefault(x => x.id == id);
            if (recordToBeUpdated != null)
            {
                recordToBeUpdated.name = record.name;
            }
        }

        public static void DeleteData(int id)
        {
            Record recordToBeDeleted = records.SingleOrDefault(x => x.id == id);
            if (recordToBeDeleted != null)
            {
                records.Remove(recordToBeDeleted);
            }
        }

        static List<Record> MockData = new List<Record>()
        {
            new Record(1, "test1"),
            new Record(2, "test2"),
            new Record(3, "test3"),
            new Record(4, "test4"),
            new Record(5, "test5")
        };
    }
}