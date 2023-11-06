using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dev1
{
    public interface IApplicationService
    {
        public void CheckPreRequisite() { }
        public void CheckDeadline() { }
        public void SendAppApprovalNotif() { }


    }
}
