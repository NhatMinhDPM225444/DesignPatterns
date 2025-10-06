using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real18_Momento
{
    public class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public ProspectMemento SaveMemento()
        {
            return new ProspectMemento(Name, Phone, Budget);
        }

        public void RestoreMemento(ProspectMemento memento)
        {
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}
