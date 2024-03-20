using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.Create;

public class CreateModelCommand : IRequest<CreatedModelResponse>,ICacheRemoverRequest
{
    public int BrandId { get; set; }
    public int Name { get; set; }
    public bool BypassCache { get; }
    public string CacheKey => "model-list";

}
