using System.Collections.Generic;
using PartDataLayer.DTO;

namespace PartDataLayer
{

    public interface IDataLayer
    {
        List<DtoPart> GetAllParts();
        bool InstsertIntoDataBase(List<DtoPart> insertList);
        bool DeleteIntoDataBase(List<DtoPart> insertList);
    }
}
