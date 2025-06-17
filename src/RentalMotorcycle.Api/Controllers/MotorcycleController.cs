using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.Motorcycle;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using RentalMotorcycle.Api.ViewModels.Motorcycle.Response;
using RentalMotorcycle.Data.Services.Motorcycles;
using RentalMotorcycle.Data.Services.Motorcycles.DTO;

namespace RentalMotorcycle.Api.Controllers
{
    [Route("motos")]
    [Tags("Motos")]
    public class MotorcycleControllers(IMotorcycleService motorcycleService, IMotorcycleMapper motorcycleMapper) : Controller
    {
        [HttpGet("")]
        [EndpointSummary("Consultar motos existentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<MotorcycleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<List<MotorcycleViewModel>> Get()
        {
            var ret = await motorcycleService.ListAsync();
            return motorcycleMapper.Map(ret);
        }
        
        [HttpGet("{id}")]
        [EndpointSummary("Consultar motos existentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<IActionResult> GetId(string id)
        {
            try
            {
                var ret = await motorcycleService.GetById(id);
                if (ret == null)
                {
                    return NotFound(new  BaseResponse
                    {
                        Mensagem = "Moto não encontrada"
                    });
                }
                return Ok(motorcycleMapper.Map(ret));
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
        [EndpointSummary("Cadastrar uma moto nova")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<IActionResult> Post([FromBody] MotorcycleViewModel motorcycleViewModel)
        {
            var success = await motorcycleService.PostMotorcycle(motorcycleMapper.Map(motorcycleViewModel));
            if (!success)
            {
                return BadRequest(new BaseResponse
                {
                    Mensagem = "Dados Inválidos"
                });
            }
            return Ok(new BaseResponse
            {
                Mensagem = "Moto adicionada com sucesso"
            });
        }

        [HttpPut("{id}")]
        [EndpointSummary("Modificar a placa de uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(BaseResponse))]
        public async Task<IActionResult> PutPlate(string id, [FromBody] MotorcyclePlateViewModel motorcyclePlateViewModel)
        {
            try
            {
                var success = await motorcycleService.PutMotorcyclePlate(id, motorcyclePlateViewModel.Placa);
                if (success)
                {
                    return Ok(new BaseResponse
                    {
                        Mensagem = "Placa Alterada com sucesso",
                    }) ;
                }

                return NotFound(new BaseResponse
                {
                    Mensagem = "Moto não encontrada"
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
        
        [HttpDelete("{id}")]
        [EndpointSummary("Remover uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BaseResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<IActionResult> Delete(string id)
        {
            var success = await motorcycleService.DeleteMotorcycle(id);
            
            if (success)
            {
                return Ok(new BaseResponse
                {
                    Mensagem = "Moto deletada com sucesso",
                }) ;
            }

            return BadRequest(new BaseResponse
            {
                Mensagem = "Dados invalidos"
            });
        }
    }
}