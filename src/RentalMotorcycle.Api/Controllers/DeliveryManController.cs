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
        public async Task<IActionResult> GetId(string id)
        {
            try
            {
                var ret = await deliveryManService.GetById(id);
                if (ret == null)
                {
                    return NotFound(new  BaseResponse
                    {
                        Mensagem = "Entregador não encontrado"
                    });
                }
                return Ok(deliveryManMapper.Map(ret));
            }
            catch (Exception e)
            {
                return BadRequest(new BaseResponse
                {
                    Mensagem = "Request mal formada"
                });
            }
            
        }
        
        [HttpPost]
        [EndpointSummary("Cadastrar entregador")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<IActionResult> PostEntregador([FromBody] DeliveryManViewModel model)
        {
            var success = await deliveryManService.PostDeliveryMan(deliveryManMapper.Map(model));
            if (!success)
            {
                return BadRequest(new  BaseResponse
                {
                    Mensagem = "Dados inválidos"
                });
            }
            return Ok(new BaseResponse
            {
                Mensagem = "Cadastrado com sucesso!"
            });
        }
        
        [HttpPut("{id}/cnh")]
        [EndpointSummary("Enviar foto da CNH")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponse))]
        public async Task<IActionResult> PutEntregadorCnh(string id, [FromBody] DeliveryManCnhViewModel deliveryManCnhViewModel)
        {
            try
            {
                var success = await deliveryManService.PutDeliveryManCnh(id, deliveryManCnhViewModel.Imagem_cnh);
                if (success)
                {
                    return Ok(new BaseResponse
                    {
                        Mensagem = "Foto da Cnh atualizada com sucesso!",
                    }) ;
                }

                return NotFound(new BaseResponse
                {
                    Mensagem = "Entregador não encontrado"
                });
            }
            catch (Exception e)
            {
                return BadRequest(new BaseResponse
                {
                    Mensagem = "Dados inválidos"
                });  
            }  
        }
    }    
}