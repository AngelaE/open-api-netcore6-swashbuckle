using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(o =>
    {
        o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.CustomOperationIds(apiDesc =>
    {
        // use ControllerName_Method as operation id. That will group the methods in the generated client
        if (apiDesc.ActionDescriptor is ControllerActionDescriptor desc)
        {
            var operationAttribute = (desc.EndpointMetadata
            .FirstOrDefault(a => a is SwaggerOperationAttribute) as SwaggerOperationAttribute);
            return $"{desc.ControllerName}_{operationAttribute?.OperationId ?? desc.ActionName}";
        }
        // otherwise get the method name from the methodInfo
        var controller = apiDesc.ActionDescriptor.RouteValues["controller"];
        apiDesc.TryGetMethodInfo(out MethodInfo methodInfo);
        string methodName = methodInfo?.Name ?? null;
        return $"{controller}_{methodName}";
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
