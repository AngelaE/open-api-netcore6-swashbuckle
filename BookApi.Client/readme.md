# Generate BookApi Client 

The Book API client is generated with autorest, see https://aka.ms/autorest for details.

To generate the client for this project:
1. run ```npm install``` in the root folder of the repository
2. run the npm task to generate the client: ```npm run generate-book-client```

## AutoRest Client Generator Configuration
``` yaml
use-extension:
  "@autorest/csharp": "3.0.0-beta.20220312.1"
  "@autorest/modelerfour": "4.22.3"

version: 3.1.3 #autorest version
input-file: http://localhost:5000/swagger/v1/swagger.json
output-folder: .
csharp: 
  namespace: Clients 
  directive:
    from: swagger-document
    where: $.definitions.*
    transform: >
      $["x-namespace"] = "BookApi"
  client-side-validation: false # disable client side validation of constraints
```
