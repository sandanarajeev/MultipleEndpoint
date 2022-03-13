using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MultipleEndpoint;

public class Functions
{
    /// <summary>
    /// Default constructor that Lambda will invoke.
    /// </summary>
    public Functions()
    {
    }


    /// <summary>
    /// A Lambda function to respond to HTTP Get methods from API Gateway
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The API Gateway response.</returns>
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
    {
        
        context.Logger.LogInformation(JsonConvert.SerializeObject(request));
        context.Logger.LogInformation(JsonConvert.SerializeObject(context)); 
        context.Logger.LogInformation("Get Request\n");
        var method = "";
        if(request.Path.Contains("makeorder")){
            method = "makeorder";
        } else if(request.Path.Contains("createorder")){
            method = "createorder";
        } else if(request.Path.Contains("cancelorder")){
            method = "cancelorder";
        } else if(request.Path.Contains("vieworder")){
            method = "vieworder";
        }
        var response = new APIGatewayProxyResponse
        {
            StatusCode = (int)HttpStatusCode.OK,
            Body = "Hello " + method,
            Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
        };

        return response;
    }
}