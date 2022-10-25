namespace Home_Owners_Association_APP
{
    public class Request
    {
        public Request()
        {

        }
        public int RequestID { get; set; }

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestDESC { get; set; } 

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestStatus { get; set; }

        //public class  
       
    }
}
