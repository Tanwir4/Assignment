using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dev1
{
    public interface IUserService
    {
        public void Register() { }
        public void ForgotPassword() { }
        public void UploadPreRequisite() { }
        public void ReceiveRequestResult() { }
        public void SubmitRequest() { }
        public void ReceiveNotifForApproval() { }
        public void ViewUploadedDoc() { }
        public void ApproveRequest() { }
        public void DeclineRequest() { }
        public void AddTraining() { }
        public void EditTraining() { }
        public void DeleteTraining() { }
        public void ExportSelectedEmployeeList() { }
        public void AssignRole() { }



        

    }
}
