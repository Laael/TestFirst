using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using TestFirst.Helpers;
using TestFirst.Services;

public static class ServerContext
{
	public static IEnumerable<ImageCell> GetImages()
    {
        var _api = RestService.For<IAPI>("https://gist.githubusercontent.com");
        try
        {
            var result = _api.GetData().Result;
            UserContext.Images = result;
            return result;
        }
        catch(Refit.ApiException ex)
        {
            Console.Write(ex);
            Console.WriteLine(Constants.ConnectError);
            return null;
        }
       
    }
}
