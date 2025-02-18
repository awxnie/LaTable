﻿ using Newtonsoft.Json;
using System.Data;
using System.Xml;

namespace LaTable
{
    public class Data
    {
        public DateTime dateTime = DateTime.Now;
        public DataTable dateTable = new DataTable("DataTable");
        public UserService userService = new UserService();
        public List<KeyValuePair<string, DateTime>> dateList = new List<KeyValuePair<string, DateTime>>();
        private string jsonFilePath =   "Data/userDates.json";
        public int currentYear;
        public int currentMonth;

        public Data()
        {
            CreateDataFiles();
            dateList = new List<KeyValuePair<string, DateTime>>();
        }

        private void CreateDataFiles()
        {
            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }
            if (!File.Exists("Data/userDates.json"))
            {
                File.WriteAllText("Data/userDates.json", "[]");
            }
        }

        public void InitializeDate()
        {
            currentYear = dateTime.Year;
            currentMonth = dateTime.Month;
        }

        public List<KeyValuePair<string, DateTime>> ReadDatesFromFile()
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<KeyValuePair<string, DateTime>>>(json);
        }

        public void AddDateToList(string eventName, DateTime eventTime)
        {
            List<KeyValuePair<string, DateTime>> dateList = ReadDatesFromFile();
            dateList.Add(new KeyValuePair<string, DateTime>(eventName, eventTime));
            WriteDatesToJson(dateList);
        }

        public void WriteDatesToJson(List<KeyValuePair<string, DateTime>> dateList)
        {
            string json = JsonConvert.SerializeObject(dateList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        public void LoadDatesToList()
        {
            dateList = ReadDatesFromFile();
        }

        public void RemoveDateFromJson(string key, DateTime date)
        {
            List<KeyValuePair<string, DateTime>> dateList = ReadDatesFromFile();
            dateList.RemoveAll(pair => pair.Key == key && pair.Value == date);
            WriteDatesToJson(dateList);
        }

        public void CreateAndInitializeXml(int year, int month)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Root"));
            doc.Save(GetXmlFilePath(year, month));

            GenerateDateTable(year, month);
            dateTable.WriteXml(GetXmlFilePath(year, month), XmlWriteMode.WriteSchema);
        }

        public void GenerateDateTable(int year, int month)
        {
            int monday, sunday;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime date = new DateTime(year, month, 1);
            dateTable.Clear();
            dateTable.Columns.Add("Имя/Число__", typeof(string));
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    monday = date.Day;
                    break;
                }
                else
                {
                    date = date.AddDays(1);
                }
            }

            date = new DateTime(year, month, daysInMonth);
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sunday = date.Day;
                    break;
                }
                else
                {
                    date = date.AddDays(1);
                }
            }

            for (int i = monday; i <= daysInMonth; i++)
            {
                dateTable.Columns.Add($"{i}_1", typeof(string));
            }
            if(sunday < 7)
            {
                for (int i = 1; i <= sunday; i++)
                {
                    dateTable.Columns.Add($"{i}_2", typeof(string));
                }
            }

            foreach (var user in userService.users)
            {
                dateTable.Rows.Add(user.GetName());
            }
        }

        public void AddDateToXml(string name, DateTime date)
        {
            dateTable.Clear();
            dateTable.ReadXml(GetXmlFilePath(date.Year, date.Month));

            DataRow targetRow = null;
            foreach (DataRow row in dateTable.Rows)
            {
                if (row["Имя/Число"].ToString() == name)
                {
                    targetRow = row;
                    break;
                }
            }

            string columnName = date.Day.ToString();
            targetRow[columnName] = "ВХ";

            SaveDataInXml(date.Year, date.Month);
        }

        public string GetXmlFilePath(int year, int month)
        {
            return $"Data/{year}{month}.xml";
        }

        public void SaveDataInXml(int year, int month)
        {
            dateTable.WriteXml(GetXmlFilePath(year, month), XmlWriteMode.WriteSchema);
        }

        public void ClearDataInXml(int year, int month)
        {
            dateTable.Clear();
            dateTable.ReadXml(GetXmlFilePath(year, month));

            foreach (DataRow row in dateTable.Rows)
            {
                for (int i = 1; i < dateTable.Columns.Count; i++)
                {
                    row[i] = string.Empty;
                }
            }

            SaveDataInXml(year, month);
        }

        public void IncrementMonth()
        {
            if (currentMonth == 12)
            {
                currentYear += 1;
                currentMonth = 1;
            }
            else
            {
                currentMonth += 1;
            }
        }

        public void DecrementMonth()
        {
            if (currentMonth == 1)
            {
                currentYear -= 1;
                currentMonth = 12;
            }
            else
            {
                currentMonth -= 1;
            }
        }
    }
}
