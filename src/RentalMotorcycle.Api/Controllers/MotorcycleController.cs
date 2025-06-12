using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using RentalMotorcycle.Api.Mapper;
using RentalMotorcycle.Api.ViewModels.Motorcycle;
using RentalMotorcycle.Data.Services.Motorcycle;
using RentalMotorcycle.Api.ViewModels;

namespace RentalMotorcycle.Api.Controllers
{
    [Route("motos")]
    public class MotorcycleControllers(IMotorcycleService motorcycleService, IMotorcycleMapper motorcycleMapper) : Controller
    {
        [HttpGet("")]
        [EndpointSummary("Consultar motos existentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<MotorcycleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseError))]
        public async Task<List<MotorcycleViewModel>> Get()
        {
            var ret = await motorcycleService.ListAsync();
            return motorcycleMapper.Map(ret);
        }
        
        [HttpGet("{id}")]
        [EndpointSummary("Consultar motos existentes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MotorcycleViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponseError))]
        public async Task<MotorcycleViewModel> GetId(string id)
        {
            return await Task.FromResult(new MotorcycleViewModel("string", 0, "", ""));
        }
    }
}