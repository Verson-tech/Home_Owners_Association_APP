namespace Home_Owners_Association_APP
{
    public interface IRequestRepository
    {
        public IEnumerable<Request> GetAllRequests();
        public Request GetRequest(int id);
        public void UpdateRequest(Request request);

        public void DeleteRequest(Request request);
    }
}
