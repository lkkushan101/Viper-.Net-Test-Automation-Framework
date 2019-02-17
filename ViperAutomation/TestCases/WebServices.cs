using System;
using NUnit.Framework;
using ViperAutomation.ReusableRequest;

using ViperAutomation.Utility;
public class GetTest
{
    [Test]

    public void testGet()
    {
        JSONReader jsonRead = new JSONReader();
        GetRequest reqGet = new GetRequest();
        reqGet.getRequest(jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "Request_Get"));
        PostRequest reqPost = new PostRequest();
        reqPost.postRequest(jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "Request_Post"), new { email = jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "email"), password = jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "password") });
        DeleteRequest reqDelete = new DeleteRequest();
        reqDelete.deleteRequest(jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "Request_Delete"));
        PutRequest reqPut = new PutRequest();
        reqPut.putRequest(jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "Request_Put"), new { name = (jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "name")), job = jsonRead.jsonReader("../ViperAutomation/Data/DaraWebServices.json", "job") });


    }


}