namespace starter_dotnet_react;

public class LoanApplication {

    public LoanApplication(){
        status = "In Progress";
    }
    public string firstName {get; set;}
    public string lastName {get; set;}

    public long ssn {get; set;}

    public string email {get; set;}

    public int creditScore {get;}

    public string status {get; set;}



    public int QueryCreditScore(string ssn){
        Random random = new Random();
        return random.Next(300,800);
    }

    public Boolean ProcessApplicaiton(){
        if(QueryCreditScore(this.ssn) > 650){
            status = "Completed";
            return true;
        }
            
        return false;
    }
}