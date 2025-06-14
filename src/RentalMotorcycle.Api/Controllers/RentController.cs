using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.Rental;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.Rental.Request;

namespace RentalMotorcycle.Api.Controllers
{
    [Route("locacao")]
    public class RentControllers(IRentMapper rentMapper) : Controller
    {
        [HttpGet("{id}")]
        [EndpointSummary("Consulta locacao por id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RentViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<RentViewModel> GetId(string id)
        {
            return await Task.FromResult(new RentViewModel("", "", DateTime.Now, DateTime.Now, DateTime.Now, 0));
        }
    }
}