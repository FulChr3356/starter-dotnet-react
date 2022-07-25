namespace starter_dotnet_react;
interface IApplication{
    boolean Apply();
    string firstName {get; set;}
    string lastName {get; set;}
    string email {get; set;}
    int creditScore {get; set;}

    enum Status {ACCEPTED, REJECTED, IN_PROGRESS, NOT_SUBMITTED, SUBMITTED}





}