﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo.Domain.Entities;
using CarGo.Application.Features.CQRS.Results.BrandResults;
using CarGo.Application.Features.Mediator.Queries.FeatureQueries;
using CarGo.Application.Features.Mediator.Results.FeatureResults;
using CarGo.Application.interfaces;
using MediatR;

namespace CarGo.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureId = request.Id,
                Name = values.Name,
            };
        }
    }
}
