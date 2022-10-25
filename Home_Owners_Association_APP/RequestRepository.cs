using Dapper;
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

        public void DeleteRequest(Request request)
        {
            _connection.Execute("DELETE FROM MAINTENANCE WHERE RequestID = @id;", new { id = request.RequestID });
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return _connection.Query<Request>("SELECT * FROM MAINTENANCE;");
        }

        public Request GetRequest(int id)
        {
            return _connection.QuerySingle<Request>("SELECT * FROM MAINTENANCE WHERE REQUESTID = @id", new {id = id});
        }

        public void UpdateRequest(Request request)
        {
            _connection.Execute("UPDATE maintenance SET RequestDESC = @requestdesc, RequestSTATUS = @requeststatus WHERE RequestID = @id",
                 new { requestdesc = request.RequestDESC, requeststatus = request.RequestSTATUS, id = request.RequestID });
        }
    }
}
