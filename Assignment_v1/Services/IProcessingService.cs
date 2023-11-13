using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_v1.Services
{
    public interface IProcessingService
    {
        void CheckPreRequisites();
        void CheckPriority();
        void CheckManagerApproval();

    }
}
