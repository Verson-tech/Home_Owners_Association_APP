using Home_Owners_Association_APP.Models;

namespace Home_Owners_Association_APP
{
    public class Request
    {
        public Request()
        {

        }
        public int RequestID { get; set; }
<<<<<<< HEAD
        public string? RequestDESC { get; set; }        
        public string? RequestSTATUS { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string RequestName { get; set; }
        public int CategoryID { get;  set; }
||||||| 3db95d3 (implemented DeleteRequest)

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestDESC { get; set; } 

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestSTATUS { get; set; }

        //public class  
       
=======

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestDESC { get; set; } 

        //CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
        public string? RequestStatus { get; set; }

        //public class  
       
>>>>>>> parent of 3db95d3 (implemented DeleteRequest)
    }
}
