using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Headers("Accept: application/json")]
public interface IAPI
{
    [Get("/yannski/3019778/raw/dfb34d018165f47b61b3bf089358a3d5ca199d96/movies.json")]
    Task<IEnumerable<ImageCell>> GetData();
}
