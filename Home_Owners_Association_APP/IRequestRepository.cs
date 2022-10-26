using Home_Owners_Association_APP.Models;
using System.Net.Http.Headers;

namespace Home_Owners_Association_APP
{
    public interface IRequestRepository
    {
        public IEnumerable<Request> GetAllRequests();
        public Request GetRequest(int id);
<<<<<<< HEAD
        public void UpdateRequest(Request request);

        public void DeleteRequest(Request request);

        public void InsertRequest(Request requestToInsert);
        public IEnumerable<Category> GetCategories();
        public Request AssignCategory();
||||||| 3db95d3 (implemented DeleteRequest)
        public void UpdateRequest(Request request);

        public void DeleteRequest(Request request);
=======
>>>>>>> parent of 3db95d3 (implemented DeleteRequest)
    }
}
