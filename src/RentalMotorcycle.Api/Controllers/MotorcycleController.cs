using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper.Motorcycle;
using RentalMotorcycle.Api.ViewModels;
using RentalMotorcycle.Api.ViewModels.Motorcycle.Request;
using RentalMotorcycle.Data.Services;

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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<MotorcycleViewModel> GetId(string id)
        {
            return await Task.FromResult(new MotorcycleViewModel("string", 0, "", ""));
        }

        [HttpPost]
        [EndpointSummary("Cadastrar uma moto nova")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<MotorcycleViewModel>> PostMotorcycle(MotorcycleViewModel model)
        {
            return await Task.FromResult(new MotorcycleViewModel("string", 0, "", ""));
        }

        [HttpPut("{id}")]
        [EndpointSummary("Modificar a placa de uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<MotorcycleViewModel>> PutMotorcycle(MotorcycleViewModel model)
        {
            return await Task.FromResult(new MotorcycleViewModel("string", 0, "", ""));
        }
        
        [HttpDelete("{id}")]
        [EndpointSummary("Remover uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<MotorcycleViewModel>> DeleteMotorcycle(string id)
        {
            return await Task.FromResult(new MotorcycleViewModel("string", 0, "", ""));
        }
    }
}