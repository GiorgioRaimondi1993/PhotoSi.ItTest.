﻿using MediatR;

namespace PhotoSi.Users.Application.Requests;
public class GetLocationsRequest : IRequest<IEnumerable<LocationDto>>
{
    public Guid? UserId { get; init; }

    public int PageNum { get; init; }

    public int PageSize { get; init; }
}
