using System.Data;
using System.Xml;

namespace LaTable
{
    internal class Data
    {
        public DateTime dateTime = DateTime.Now;
        public DataTable dataTable = new DataTable("DataTable");
        public UserService userService = new UserService();
        public int currentYear;
        public int currentMonth;

        public void InitializeDate()
        {
            currentYear = dateTime.Year;
            currentMonth = dateTime.Month;
        }

        public void CreateAndInitializeXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Root"));
            doc.Save(GetXmlFilePath());

            dataTable.Columns.Clear();
            dataTable.Rows.Clear();

            dataTable.Columns.Add("Имя", typeof(string));
            for (int i = 1; i <= DateTime.DaysInMonth(currentYear, currentMonth); i++)
            {
                dataTable.Columns.Add(i.ToString(), typeof(string));
            }

            for (int i = 0; i < userService.users.Count; i++)
            {
                dataTable.Rows.Add(userService.users[i].GetName());
            }

            dataTable.WriteXml(GetXmlFilePath(), XmlWriteMode.WriteSchema);
        }

        public string GetXmlFilePath()
        {
            return $"Data/{currentYear}{currentMonth}.xml";
        }

        public void SaveDataInXml()
        {
            dataTable.WriteXml(GetXmlFilePath(), XmlWriteMode.WriteSchema);
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
