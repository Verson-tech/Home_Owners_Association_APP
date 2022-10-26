using Home_Owners_Association_APP.Models;

namespace Home_Owners_Association_APP
{
    public class Request
    {
        public Request()
        {

        }
        public int RequestID { get; set; }
        public string? RequestDESC { get; set; }        
        public string? RequestSTATUS { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string RequestName { get; set; }
        public int CategoryID { get;  set; }
    }
}
