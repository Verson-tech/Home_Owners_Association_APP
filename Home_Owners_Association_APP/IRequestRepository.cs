using Home_Owners_Association_APP.Models;
using System.Net.Http.Headers;

namespace Home_Owners_Association_APP
{
    public interface IRequestRepository
    {
        public IEnumerable<Request> GetAllRequests();
        public Request GetRequest(int id);
        public void UpdateRequest(Request request);

        public void DeleteRequest(Request request);

        public void InsertRequest(Request requestToInsert);
        public IEnumerable<Category> GetCategories();
        public Request AssignCategory();
    }
}
