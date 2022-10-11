#r "Newtonsoft.Json"
#r "C:\home\site\wwwroot\HttpTrigger\bin\itextsharp.dll"
#r "C:\home\site\wwwroot\HttpTrigger\bin\SigPDF.dll"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

public static async Task<IActionResult> Run(HttpRequest Request, ILogger log)
{   
    /*
    log.LogInformation("C# HTTP trigger function processed a request.");

    string pdfToSign = req.Query["pdfToSign"];
    string certificate = req.Query["certificate"];
    
    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
    dynamic data = JsonConvert.DeserializeObject(requestBody);
    pdfToSign = pdfToSign ?? data?.pdfToSign;
    certificate = certificate ?? data?.certificate;
        
    string responseMessage = string.IsNullOrEmpty(pdfToSign)
        ? "This HTTP triggered function executed successfully. Pass a pdfToSign to stamp the certificate!"
                : $"Hello, {pdfToSign}. This HTTP triggered function executed successfully and we stamp the {certificate}.";

            return new OkObjectResult(responseMessage);
    
    
    // POST api/values
    
    [HttpPost]
    public async Task<HttpResponseMessage> Post()
        {
    
        if (!Request.Content.IsMimeMultipartContent("form-data"))
        {
            throw new HttpResponseException
                (Request.CreateResponse(HttpStatusCode.UnsupportedMediaType));
        }
        string responseMessage = "This HTTP triggered function executed successfully. Pass a pdfToSign to stamp the certificate!"

        return new OkObjectResult(responseMessage);
        }
    
        MultipartFormDataStreamProvider streamProvider = new MultipartFormDataStreamProvider(
            HttpContext.Current.Server.MapPath("~/Images/"));
        await Request.Content.ReadAsMultipartAsync(streamProvider);


        foreach (MultipartFileData fileData in streamProvider.FileData)
        {
            string fileName = "";
            if (string.IsNullOrEmpty(fileData.Headers.ContentDisposition.FileName))
            {
                fileName = Guid.NewGuid().ToString();
            }
            fileName = fileData.Headers.ContentDisposition.FileName;
            if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
            {
                fileName = fileName.Trim('"');
            }
            if (fileName.Contains(@"/") || fileName.Contains(@"\"))
            {
                fileName = Path.GetFileName(fileName);
            }                

            File.Move(fileData.LocalFileName,
                Path.Combine(HttpContext.Current.Server.MapPath("~/Images/"), fileName));
        }
        
        SigPDF.FirmaPDF Firma = new SigPDF.FirmaPDF();
        Firma.Sign(HttpContext.Current.Server.MapPath("~/Images/alazaro_1234.pfx"), "1234", HttpContext.Current.Server.MapPath("~/Images/doc.pdf"),
            HttpContext.Current.Server.MapPath("~/Images/docSign.pdf"), "", "", "", true);


        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
        FileStream fileStream = File.OpenRead(HttpContext.Current.Server.MapPath("~/Images/docSign.pdf"));
        response.Content = new StreamContent(fileStream);
        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

        return response;
    
    }
    */
}
