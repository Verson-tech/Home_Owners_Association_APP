using Microsoft.AspNetCore.Mvc;

namespace Home_Owners_Association_APP.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestRepository repo;

        public RequestController(IRequestRepository repo)
        {
            this.repo = repo;
        }

        //GET: /<controller>/
        public IActionResult Index()
        {
            var requests= repo.GetAllRequests();
            return View(requests);
        }

        public IActionResult ViewRequest(int id)
        {
            var request = repo.GetRequest(id);
            return View(request);
        }
<<<<<<< HEAD
        public IActionResult UpdateRequest(int id)
        {
            Request prod = repo.GetRequest(id);
            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateRequestToDatabase(Request request)
        {
            repo.UpdateRequest(request);

            return RedirectToAction("ViewRequest", new { id = request.RequestID });
        }

        public IActionResult DeleteRequest(Request request)
        {
            repo.DeleteRequest(request);
            return RedirectToAction("Index");
        }

        public IActionResult InsertRequest()
        {
            var req = repo.AssignCategory();
            return View(req);
        }

        public IActionResult InsertRequestToDatabase(Request requestToInsert)
        {
            repo.InsertRequest(requestToInsert);
            return RedirectToAction("Index");
        }
||||||| 3db95d3 (implemented DeleteRequest)
        public IActionResult UpdateRequest(int id)
        {
            Request prod = repo.GetRequest(id);
            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateRequestToDatabase(Request request)
        {
            repo.UpdateRequest(request);

            return RedirectToAction("ViewRequest", new { id = request.RequestID });
        }

        public IActionResult DeleteRequest(Request request)
        {
            repo.DeleteRequest(request);
            return RedirectToAction("Index");
        }
=======
>>>>>>> parent of 3db95d3 (implemented DeleteRequest)
    }
}
