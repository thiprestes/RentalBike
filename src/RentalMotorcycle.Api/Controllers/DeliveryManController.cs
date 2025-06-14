using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.DeliveryMen;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;

namespace RentalMotorcycle.Api.Controllers


{
    [Route("entregadores")]
    public class DeliveryManControllers(IDeliveryManMapper deliveryManMapper) : Controller
    {
        [HttpGet("{id}")]
        [EndpointSummary("Consulta entregador por id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<DeliveryManViewModel> GetId(string id)
        {
            return await Task.FromResult(new DeliveryManViewModel("","","",DateTime.Now, "", "", ""));
        }
    }    
}