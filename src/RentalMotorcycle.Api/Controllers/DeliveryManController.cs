using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.DeliveryMen;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;

namespace RentalMotorcycle.Api.Controllers


{
    [Route("entregadores")]
    [Tags("Entregadores")]
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
        
        [HttpPost]
        [EndpointSummary("Cadastrar entregador")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<DeliveryManViewModel> PostEntregador(string id)
        {
            return await Task.FromResult(new DeliveryManViewModel("","","",DateTime.Now, "", "", ""));
        }
        
        [HttpPost("{id}/cnh")]
        [EndpointSummary("Enviar foto da CNH")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<DeliveryManViewModel> PostEntregadorCnh(string id)
        {
            return await Task.FromResult(new DeliveryManViewModel("","","",DateTime.Now, "", "", ""));
        }
    }    
}