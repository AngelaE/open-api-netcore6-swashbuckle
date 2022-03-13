using Azure.Core.Pipeline;
using BookApi;

// All these options need to be initialized properly in DI for production code
var endpoint = new Uri("http://localhost:5000");
var clientOptions = Azure.Core.ClientOptions.Default;
var diagnostics = new ClientDiagnostics(clientOptions);
var pipeline = HttpPipelineBuilder.Build(clientOptions);
var authorsClient = new AuthorsRestClient(diagnostics, pipeline, endpoint);

var authors = await authorsClient.GetAllAsync();
Console.WriteLine($"Request was successful, found {authors.Value.Count} authors");

foreach(var author in authors.Value)
{
    Console.WriteLine(author.Name);
}