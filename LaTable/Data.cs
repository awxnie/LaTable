using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.Common;
using System.Xml;

namespace LaTable
{
    public class Data
    {
        public Random random = new Random();
        public DateTime dateTime = DateTime.Now;
        public DataTable dateTable = new DataTable("DataTable");
        public UserService userService = new UserService();
        public List<KeyValuePair<string, DateTime>> dateList = new List<KeyValuePair<string, DateTime>>();
        private string jsonFilePath =   "Data/userDates.json";
        public int currentYear;
        public int currentMonth;
        public int daysInMonth;

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
            daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
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

        public void CreateAndInitializeXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Root"));
            doc.Save(GetXmlFilePath());

            GenerateDateTable();
            dateTable.WriteXml(GetXmlFilePath(), XmlWriteMode.WriteSchema);
        }

        public void GenerateDateTable()
        {
            dateTable.Columns.Add("Имя/Число__", typeof(string));
            for (int i = GetDayOfWeek(DayOfWeek.Monday); i <= daysInMonth; i++)
            {
                dateTable.Columns.Add($"{i}.1", typeof(string));
            }
            if (GetDayOfWeek(DayOfWeek.Sunday) < 7)
            {
                for (int i = 1; i <= GetDayOfWeek(DayOfWeek.Sunday); i++)
                {
                    dateTable.Columns.Add($"{i}.2", typeof(string));
                }
            }

            foreach (var user in userService.users)
            {
                dateTable.Rows.Add(user.GetName());
            }
        }

        public void MakeSchedule()
        {
            for (int i = 0; i < dateTable.Rows.Count; i++)
            {
                for (int j = 1; j < dateTable.Columns.Count; j++)
                {
                    //dateTable.Rows[i][j] = "";
                    if (!dateTable.Rows[i][j].ToString().Contains("ВХ"))
                    {
                        dateTable.Rows[i][j] = "";
                    }
                }
            }
            AddRDMShifts();
            //AddDaysOff();
            AddMainShifts();
        }

        public void AddRDMShifts()
        {
            int mondayIndex = GetDayOfWeek(DayOfWeek.Monday);
            int sundayIndex = GetDayOfWeek(DayOfWeek.Sunday);
            int totalDays = daysInMonth - mondayIndex + sundayIndex + 1;
            DateTime currentDate = new DateTime(currentYear, currentMonth, mondayIndex);

            for (int i = 1; i < totalDays; i++)
            {
                switch (currentDate.DayOfWeek)
                {
                    case DayOfWeek.Tuesday:
                        dateTable.Rows[0][i] = "R";
                        break;
                    case DayOfWeek.Monday:
                        dateTable.Rows[1][i] = "R";
                        break;
                    case DayOfWeek.Wednesday:
                        dateTable.Rows[2][i] = "R";
                        break;
                }
                currentDate = currentDate.AddDays(1);
            }
            dateTable.Rows[2][daysInMonth - mondayIndex + 1] = "R";
        }

        public void AddDaysOff()
        {
            int mondayIndex = GetDayOfWeek(DayOfWeek.Monday);
            int sundayIndex = GetDayOfWeek(DayOfWeek.Sunday);
            int totalDays = daysInMonth - mondayIndex + sundayIndex + 1;
            int numberOfWeeks = totalDays / 7;
            int currentWeekStart = mondayIndex;

            for (int week = 0; week < numberOfWeeks; week++)
            {
                for (int nameIndex = 0; nameIndex <= userService.users.Count - 2; nameIndex++)
                {
                    int assignedDaysOff = 0; // Считаем, сколько выходных уже назначено этому пользователю

                    while (assignedDaysOff < 2) // Каждому пользователю по 2 выходных
                    {
                        int randomDay = random.Next(currentWeekStart, currentWeekStart + 7);
                        int columnIndex = randomDay - mondayIndex + 1;

                        // Проверяем, не превышен ли лимит 5 ВХ в этом дне (столбце)
                        int dayOffCount = 0;
                        for (int row = 0; row < dateTable.Rows.Count - 2; row++)
                        {
                            if (dateTable.Rows[row][columnIndex].ToString() == "ВХ")
                            {
                                dayOffCount++;
                            }
                        }

                        // Если в дне меньше 5 выходных, назначаем выходной
                        if (dayOffCount < 5 && string.IsNullOrWhiteSpace(dateTable.Rows[nameIndex][columnIndex].ToString()))
                        {
                            dateTable.Rows[nameIndex][columnIndex] = "ВХ";
                            assignedDaysOff++;
                        }
                    }
                }
                currentWeekStart += 7;
            }
        }

        private void AddMainShifts()
        {
            string[] cycleValues = { "У", "У", "В", "В", "Н", "П", "П", "В" };

            for (int col = 1; col < dateTable.Columns.Count; col++)
            {
                List<int> freeRowIndices = new List<int>();

                for (int row = 0; row < dateTable.Rows.Count - 1; row++)
                {
                    if (string.IsNullOrWhiteSpace(dateTable.Rows[row][col].ToString()))
                    {
                        freeRowIndices.Add(row);
                    }
                }

                ShuffleList(freeRowIndices); // Перемешивание списка

                bool success = false;
                int maxAttempts = 1000; // Ограничение попыток
                int attempt = 0;

                while (!success && attempt < maxAttempts)
                {
                    attempt++;
                    bool validAssignment = false;
                    int cycleIndex = 0;

                    foreach (int rowIndex in freeRowIndices)
                    {
                        string prevShift = dateTable.Rows[rowIndex][col - 1].ToString();
                        string curShift = cycleValues[cycleIndex];

                        if ((curShift == "Н" && rowIndex < 3) ||
                            (prevShift == "Н" && (curShift == "У" || curShift == "В" || curShift == "П")) ||
                            (prevShift == "В" && curShift == "У"))
                        {
                            ShuffleList(freeRowIndices);
                            validAssignment = false;
                            break;
                        }
                        else
                        {
                            dateTable.Rows[rowIndex][col] = cycleValues[cycleIndex];
                            cycleIndex = (cycleIndex + 1) % cycleValues.Length;
                            validAssignment = true;
                        }
                    }

                    if (validAssignment)
                    {
                        success = true;
                    }
                }
            }
        }

        public void ShuffleList<T>(List<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        public int GetDayOfWeek(DayOfWeek dayOfWeek)
        {
            int day;
            int startDay = (dayOfWeek == DayOfWeek.Monday) ? 1 : daysInMonth;
            DateTime date = new DateTime(currentYear, currentMonth, startDay);
            while (true)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    day = date.Day;
                    break;
                }
                else
                {
                    date = date.AddDays(1);
                }
            }

            if (day > 7) return 0;
            return day;
        }

        public void AddDateToXml(string name, DateTime date)
        {
            dateTable.Clear();
            dateTable.ReadXml(GetXmlFilePath());
            DataRow targetRow = null;
            foreach (DataRow row in dateTable.Rows)
            {
                if (row["Имя/Число__"].ToString() == name)
                {
                    targetRow = row;
                    break;
                }
            }

            string columnName = date.Day.ToString();
            targetRow[$"{columnName}.1"] = "ВХ";

            SaveDataInXml();
        }

        public string GetXmlFilePath()
        {
            return $"Data/{currentYear}{currentMonth}.xml";
        }

        public void SaveDataInXml()
        {
            dateTable.WriteXml(GetXmlFilePath(), XmlWriteMode.WriteSchema);
        }

        public void ClearDataInXml()
        {
            dateTable.Clear();
            dateTable.ReadXml(GetXmlFilePath());

            foreach (DataRow row in dateTable.Rows)
            {
                for (int i = 1; i < dateTable.Columns.Count; i++)
                {
                    row[i] = string.Empty;
                }
            }

            SaveDataInXml();
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
            daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
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
            daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
        }
    }
}
