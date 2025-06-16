using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.DeliveryMen;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.DeliveryMen.Request;
using RentalMotorcycle.Api.ViewModels.DeliveryMen.Response;
using RentalMotorcycle.Data.Services.DeliveryMen;

namespace RentalMotorcycle.Api.Controllers


{
    [Route("entregadores")]
    [Tags("Entregadores")]
    public class DeliveryManControllers(IDeliveryManService deliveryManService, IDeliveryManMapper deliveryManMapper) : Controller
    {
        [HttpGet("{id}")]
        [EndpointSummary("Consulta entregador por id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<DeliveryManViewModel> GetId(string id)
        {
            var ret = await deliveryManService.GetById(id);
            return await Task.FromResult(new DeliveryManViewModel(
                ret.Identificador,
                ret.Nome,
                ret.Cnpj,
                ret.Data_nascimento,
                ret.Numero_cnh,
                ret.Tipo_cnh, 
                ret.Imagem_cnh));
        }
        
        [HttpPost]
        [EndpointSummary("Cadastrar entregador")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<DeliveryManViewModel>> PostEntregador([FromBody] DeliveryManViewModel model)
        {
            await deliveryManService.PostDeliveryMan(deliveryManMapper.Map(model));
            return CreatedAtAction(nameof(GetId), new { id = model.Identificador }, model);
        }
        
        [HttpPut("{id}/cnh")]
        [EndpointSummary("Enviar foto da CNH")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryManViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<DeliveryManViewModel> PostEntregadorCnh(string id)
        {
            return await Task.FromResult(new DeliveryManViewModel("","","",DateTime.Now, "", "", ""));
        }
    }    
}