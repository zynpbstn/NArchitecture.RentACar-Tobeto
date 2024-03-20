using Application.Features.Brands.Dtos;
using Application.Features.Models.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Models.Queries.GetAll;

public class GetAllModelsQuery : IRequest<List<GetAllModelsResponse>>
{
    public class GetAllModelsQueryHandler : IRequestHandler< List<GetAllModelsResponse>>, ICachableRequest
    {
        public bool BypassCache { get; }

        public string CacheKey => "model-list";

        public TimeSpan? SlidingExpiration { get; }
    }
}
