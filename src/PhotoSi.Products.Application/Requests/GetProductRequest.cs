﻿using MediatR;
using Newtonsoft.Json;

namespace PhotoSi.Products.Application.Requests;

public class GetProductRequest : IRequest<ProductDto>
{
    public Guid Id { get; init; }
}

public class ProductDto
{
    [JsonProperty("id")]
    public Guid Id { get; private set; }

    [JsonProperty("name")]
    public string Name { get; private set; }


    [JsonProperty("category")]
    public string Category { get; private set; }
}
