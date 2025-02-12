using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTable
{
    public partial class MiddleForm : BaseForm
    {
        public DataGridView calendarGrid = new DataGridView();
        public Label dateLabel = new Label();
        public override DataGridView CalendarGrid => calendarGrid;
        public override Label DateLabel => dateLabel;
    }
}
