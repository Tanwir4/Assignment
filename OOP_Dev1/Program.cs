// See https://aka.ms/new-console-template for more information

class User
{
    String userName;
    String password;
    
}
class Employee 
{
    String name;
    String dept;
    String manager;
    String email;
    String nic;
    string mobileNumber;

    public void SubmitRequest() { }

    public void ReceiveNotification() { }
}

class Manager : User
{

    public void CheckPreRequisites() { }
    public void ApproveRequest() { }
    public String DeclineRequest() 
    { String reason="";
        return reason;
    }
    public void ReceiveNotification() { }

}

class Admin : User
{
    public void AddTraining() { }
    public void EditTraining() { }
    public void DeleteTraining() { }

}

class Training
{
    String trainingName;
    DateTime deadline;
    String preRequisite;
    String priority;
}

class TrainingRequestProcessing
{
    public void CheckManagerApproval() { }
    public void CheckTrainingDeadline() { }

}





