using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern19_Observer
{
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
