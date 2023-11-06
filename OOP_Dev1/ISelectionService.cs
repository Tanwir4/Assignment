using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dev1
{
    public interface ISelectionService
    {
        public void CheckManagerApproval() { }
        public void CheckPriority() { }
        public void CheckFCFS() { }
    }
}
