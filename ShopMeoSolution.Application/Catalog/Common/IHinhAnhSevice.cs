using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Application.Catalog.Common
{
    public interface IHinhAnhSevice
    {
        string GetFile(string fileName);
        Task SaveFile (Stream biye,string name );
        Task DeleteFile(string fileName);
    }
}
