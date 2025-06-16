using Microsoft.AspNetCore.Mvc;
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
        public async Task<RentResponse> GetId(string id)
        {
            var ret = await rentService.GetById(id);
            ret.Valor_diaria = rentService.GetValorDiaria(ret);
            return await Task.FromResult(new RentResponse(
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

        [HttpPut("{id}/devolucao")]
        [EndpointSummary("Informar data de devolução e calcular valor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RentViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<RentViewModel>> PutRent(string id, RentViewModel model)
        {
            return await Task.FromResult(new RentViewModel(
                "", 
                "", 
                "", 
                DateTime.Now, 
                DateTime.Now, 
                DateTime.Now, 
                0));
        }

        [HttpPost]
        [EndpointSummary("Alugar uma moto")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RentViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public async Task<ActionResult<RentViewModel>> Post([FromBody] RentViewModel model)
        {
            await rentService.PostRent(rentMapper.Map(model));
            return CreatedAtAction(nameof(GetId), new { id = model.Identificador }, model);
        }
    }
}