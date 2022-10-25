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

        public IEnumerable<Request> GetAllRequests()
        {
            return _connection.Query<Request>("SELECT * FROM MAINTENANCE;");
        }

        public Request GetRequest(int id)
        {
            return _connection.QuerySingle<Request>("SELECT * FROM MAINTENANCE WHERE REQUESTID = @id", new {id = id});
        }
    }
}
