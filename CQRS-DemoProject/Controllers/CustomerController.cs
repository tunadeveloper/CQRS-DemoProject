using CQRS_DemoProject.MediatorDesignPattern.Commands;
using CQRS_DemoProject.MediatorDesignPattern.Queries;
using CQRS_DemoProject.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_DemoProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetCustomerQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveCustomer(int id)
        {
            await _mediator.Send(new  RemoveCustomerCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var value = await _mediator.Send(new GetCustomerByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
