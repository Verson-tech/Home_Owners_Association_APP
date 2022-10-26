using Dapper;
using Home_Owners_Association_APP.Models;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Data;

namespace Home_Owners_Association_APP
{
    public class RequestRepository : IRequestRepository
    {
        private readonly IDbConnection _connection;
        public RequestRepository(IDbConnection conn)
        {
            _connection = conn;
        }

<<<<<<< HEAD
        public Request AssignCategory()
        {
            var categoryList = GetCategories();
            var request = new Request();
            request.Categories = categoryList;
            return request;
        }

        public void DeleteRequest(Request request)
        {
            _connection.Execute("DELETE FROM MAINTENANCE WHERE RequestID = @id;", new { id = request.RequestID });
        }

||||||| 3db95d3 (implemented DeleteRequest)
        public void DeleteRequest(Request request)
        {
            _connection.Execute("DELETE FROM MAINTENANCE WHERE RequestID = @id;", new { id = request.RequestID });
        }

=======
>>>>>>> parent of 3db95d3 (implemented DeleteRequest)
        public IEnumerable<Request> GetAllRequests()
        {
            return _connection.Query<Request>("SELECT * FROM MAINTENANCE;");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories;");
        }

        public Request GetRequest(int id)
        {
            return _connection.QuerySingle<Request>("SELECT * FROM MAINTENANCE WHERE REQUESTID = @id", new {id = id});
        }
<<<<<<< HEAD

        public void InsertRequest(Request requestToInsert)
        {
            _connection.Execute("INSERT INTO maintenance (REQUESTNAME, REQUESTDESC, CATEGORYID) VALUES (@requestName, @requestDesc, @categoryID);",
                new {requestName = requestToInsert.RequestName, requestDesc = requestToInsert.RequestDESC, categoryID = requestToInsert.CategoryID});
        }

        public void UpdateRequest(Request request)
        {
            _connection.Execute("UPDATE maintenance SET RequestDESC = @requestdesc, RequestSTATUS = @requeststatus WHERE RequestID = @id",
                 new { requestdesc = request.RequestDESC, requeststatus = request.RequestSTATUS, id = request.RequestID });
        }
||||||| 3db95d3 (implemented DeleteRequest)

        public void UpdateRequest(Request request)
        {
            _connection.Execute("UPDATE maintenance SET RequestDESC = @requestdesc, RequestSTATUS = @requeststatus WHERE RequestID = @id",
                 new { requestdesc = request.RequestDESC, requeststatus = request.RequestSTATUS, id = request.RequestID });
        }
=======
>>>>>>> parent of 3db95d3 (implemented DeleteRequest)
    }
}
