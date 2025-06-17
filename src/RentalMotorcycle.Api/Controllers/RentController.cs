using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using RentalMotorcycle.Api.Mapper.Rental;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.Rental.Request;
using RentalMotorcycle.Api.ViewModels.Rental.Response;
using RentalMotorcycle.Data.Services.Rental;

namespace RentalMotorcycle.Api.Controllers
{
    [Route("locacao")]
    [Tags("Locação")]
    public class RentControllers(IRentService rentService, IRentMapper rentMapper) : Controller
    {
        [HttpGet("{id}")]
        [EndpointSummary("Consulta locacao por id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RentResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponse))]
        public async Task<ActionResult<RentResponse>> GetId(string id)
        {
            try
            {
                var ret = await rentService.GetById(id);
                if (ret == null)
                {
                    return NotFound(new BaseResponse
                    {
                        Mensagem = "Locação não encontrada"
                    });
                }
                ret.Valor_diaria = rentService.GetValorDiaria(ret);
                return Ok(new RentResponse(
                        ret.Identificador, 
                        ret.Valor_diaria,
                        ret.Entregador_id,
                        ret.Moto_id,
                        ret.Data_inicio,
                        ret.Data_termino,
                        ret.Data_previsao_termino,
                        ret.Data_devolucao)
                    );
            }
            catch (Exception e)
            {
                return BadRequest(new BaseResponse
                {
                    Mensagem = "Request mal formada"
                });
            }
        }

        [HttpPut("{id}/devolucao")]
        [EndpointSummary("Informar data de devolução e calcular valor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RentDeliveryResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<RentDeliveryResponse>> PutRent(string id,[FromBody]RentDeliveryViewModel model)
        {
            
            try
            {
                var rent = await rentService.PutRent(id, model.Data_devolucao);
                if (rent.success)
                {
                    return Ok(new RentDeliveryResponse
                    {
                        Mensagem = "Devolução realizada com sucesso!",
                        ValorLocacao = rent.totalRent
                    });
                }

                return NotFound(new BaseResponse
                {
                    Mensagem = "Locação não encontrada"
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

        [HttpPost]
        [EndpointSummary("Alugar uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult> Post([FromBody] RentViewModel model)
        {
            try
            {
                var validation = await rentService.PostRent(rentMapper.Map(model));
                if (!validation.existDeliveryMan)
                {
                    return BadRequest(new BaseResponse
                    {
                        Mensagem = "Entregador não encontrado"
                    });
                }

                if (!validation.existMotorcycle)
                {
                    return BadRequest(new BaseResponse
                    {
                        Mensagem = "Moto não encontrada"
                    });       
                }

                if (validation.ExistRent)
                {
                    return BadRequest(new BaseResponse
                    {
                        Mensagem = "Locação já cadastrada"
                    });
                }
            
                return Ok(new BaseResponse
                {
                    Mensagem = "Locação cadastrada com sucesso!"
                });
            }
            catch (Exception e)
            {
                return BadRequest(new BaseResponse
                {
                    Mensagem = "Request mal formada"
                });
            }
            
        }
    }
}