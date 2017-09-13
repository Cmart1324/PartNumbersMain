using System.Collections.Generic;
using System.Linq;
using PartDataLayer.DTO;

namespace PartLogic.List_Classes
{
    public class Mapper
    {
        #region DTOS
        public List<Parts> MapParts(List<DtoPart> dtos)
        {
            return dtos.Select(MapDtoParts).ToList();
        }
        public Parts MapDtoParts(DtoPart dto)
        {
            return new Parts(dto.PartNumber, dto.PartPrice, dto.PartDesciption);
        }

        #endregion

        #region views
        public List<DtoPart> MapPartsTolistDtoParts(List<Parts> views)
        {
            return views.Select(MapPartsToDtoParts).ToList();
        }
        public DtoPart MapPartsToDtoParts(Parts view)
        {
            return new DtoPart(view.PartNumber, view.PartPrice, view.PartDesciption);
        }
        #endregion 
    }
}
