# IO.Swagger - the C# library for the Gestão de Propostas

API de Gestão de Propostas.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new PropostaApi();
            var clientId = clientId_example;  // string | Client ID disponibilizado na criação da App.
            var accessToken = accessToken_example;  // string | Access Token com permissões de acesso.
            var xAuthorization = B;  // byte[] | base64 do codigoParceiro:codigoUsuario:senha.
            var cpf = cpf_example;  // string | Cpf utilizado na proposta.

            try
            {
                List<PropostaResponse> result = apiInstance.PropostasGet(clientId, accessToken, xAuthorization, cpf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropostaApi.PropostasGet: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dev-api.portocred.com.br/gestao-proposta/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PropostaApi* | [**PropostasGet**](docs/PropostaApi.md#propostasget) | **GET** /propostas | 
*PropostaApi* | [**PropostasIdClientesDocumentosPost**](docs/PropostaApi.md#propostasidclientesdocumentospost) | **POST** /propostas/{id}/clientes/documentos | 
*PropostaApi* | [**PropostasIdDocUploadUrlGet**](docs/PropostaApi.md#propostasiddocuploadurlget) | **GET** /propostas/{id}/doc-upload-url | 
*PropostaApi* | [**PropostasIdDocumentosGet**](docs/PropostaApi.md#propostasiddocumentosget) | **GET** /propostas/{id}/documentos | 
*PropostaApi* | [**PropostasIdGet**](docs/PropostaApi.md#propostasidget) | **GET** /propostas/{id} | 
*PropostaApi* | [**PropostasIdHistoricosGet**](docs/PropostaApi.md#propostasidhistoricosget) | **GET** /propostas/{id}/historicos | 
*PropostaApi* | [**PropostasIdMensagensPost**](docs/PropostaApi.md#propostasidmensagenspost) | **POST** /propostas/{id}/mensagens | 
*PropostaApi* | [**PropostasIdOfertasGet**](docs/PropostaApi.md#propostasidofertasget) | **GET** /propostas/{id}/ofertas | 
*PropostaApi* | [**PropostasIdOfertasPost**](docs/PropostaApi.md#propostasidofertaspost) | **POST** /propostas/{id}/ofertas | 
*PropostaApi* | [**PropostasIdPendenciasGet**](docs/PropostaApi.md#propostasidpendenciasget) | **GET** /propostas/{id}/pendencias | 
*PropostaApi* | [**PropostasIdPut**](docs/PropostaApi.md#propostasidput) | **PUT** /propostas/{id} | 
*PropostaApi* | [**PropostasIdStatusGet**](docs/PropostaApi.md#propostasidstatusget) | **GET** /propostas/{id}/status | 
*PropostaApi* | [**PropostasPost**](docs/PropostaApi.md#propostaspost) | **POST** /propostas | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AcaoAlteracaoProposta](docs/AcaoAlteracaoProposta.md)
 - [Model.AlteracaoPropostaRequest](docs/AlteracaoPropostaRequest.md)
 - [Model.Candidato](docs/Candidato.md)
 - [Model.CartaoCredito](docs/CartaoCredito.md)
 - [Model.Cheque](docs/Cheque.md)
 - [Model.Cliente](docs/Cliente.md)
 - [Model.Conjuge](docs/Conjuge.md)
 - [Model.ContaBancaria](docs/ContaBancaria.md)
 - [Model.CpfDocumentoProposta](docs/CpfDocumentoProposta.md)
 - [Model.DadoAdicional](docs/DadoAdicional.md)
 - [Model.DadosLiberacao](docs/DadosLiberacao.md)
 - [Model.Documento](docs/Documento.md)
 - [Model.DocumentoProposta](docs/DocumentoProposta.md)
 - [Model.Emprego](docs/Emprego.md)
 - [Model.Endereco](docs/Endereco.md)
 - [Model.EstadoCivil](docs/EstadoCivil.md)
 - [Model.FormaEnvio](docs/FormaEnvio.md)
 - [Model.Historico](docs/Historico.md)
 - [Model.InclusaoPrePropostaResponse](docs/InclusaoPrePropostaResponse.md)
 - [Model.InclusaoPropostaResponse](docs/InclusaoPropostaResponse.md)
 - [Model.IndicativoSimNao](docs/IndicativoSimNao.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.Nacionalidade](docs/Nacionalidade.md)
 - [Model.Oferta](docs/Oferta.md)
 - [Model.Pendencia](docs/Pendencia.md)
 - [Model.PreEfetivacaoPropostaRequest](docs/PreEfetivacaoPropostaRequest.md)
 - [Model.PreProposta](docs/PreProposta.md)
 - [Model.Proposta](docs/Proposta.md)
 - [Model.PropostaResponse](docs/PropostaResponse.md)
 - [Model.ReferenciaPessoal](docs/ReferenciaPessoal.md)
 - [Model.RendaAdicional](docs/RendaAdicional.md)
 - [Model.Sexo](docs/Sexo.md)
 - [Model.StatusPropostaResponse](docs/StatusPropostaResponse.md)
 - [Model.Telefone](docs/Telefone.md)
 - [Model.TipoCliente](docs/TipoCliente.md)
 - [Model.TipoConta](docs/TipoConta.md)
 - [Model.TipoContaBancaria](docs/TipoContaBancaria.md)
 - [Model.TipoContrato](docs/TipoContrato.md)
 - [Model.TipoCorrespondencia](docs/TipoCorrespondencia.md)
 - [Model.TipoEfetivacao](docs/TipoEfetivacao.md)
 - [Model.TipoResidencia](docs/TipoResidencia.md)
 - [Model.TipoSeguro](docs/TipoSeguro.md)
 - [Model.TipoSimulacao](docs/TipoSimulacao.md)
 - [Model.TipoTelefone](docs/TipoTelefone.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
