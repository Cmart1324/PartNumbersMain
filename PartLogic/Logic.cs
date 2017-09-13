using System.Collections.Generic;
using System.Linq;
using PartDataLayer;
using PartLogic.List_Classes;

namespace PartLogic
{
    public class Logic : ILogic
    {
        #region sets variables
      
        private Mapper _mapper;
        private Mapper Mapper => _mapper ?? (_mapper = new Mapper());

        private DataLayer _agent;
        private IDataLayer Agent => _agent ?? (_agent = new DataLayer());

        public List<Parts> _getParts;
        public List<Parts> GetParts => _getParts ?? (_getParts = Mapper.MapParts(Agent.GetAllParts()));

        private List<Parts> _nonOrginalList;
        public List<Parts> NonOrginalList => _nonOrginalList ?? (_nonOrginalList = SetnonOrginalList());

        public List<Parts> SetnonOrginalList()
        {
            var tempList = new List<Parts>();
            foreach (var item in GetParts)
            {
                tempList.Add(item.ShallowCopy());
            }
            return tempList;
        }
       
        #endregion //sets variables. 


        public int SetListAndGetCount()
        {
            SetnonOrginalList();

           int count = _getParts.Count;

           return count;
        }

        #region changes list
        public void AddtoGetPart(string partNumber, double partPrice, string partDescription)
        {
           
            NonOrginalList.Add(new Parts(partNumber, partPrice, partDescription));
        }
        public void DeletePart(string partNumber)
        {
            var item = _nonOrginalList.First(x => x.PartNumber == partNumber);
            _nonOrginalList.Remove(item);
        }
        #endregion // changes list

        #region valid

        public bool IsValid(string textBoxText)
        {
            return textBoxText != "";
        }
        public bool IsNumber(string textBoxText)
        {
            return double.TryParse(textBoxText, out double number) && number > 0.0;
        }
        public bool IsNineLetter(string textBoxText)
        {
            return textBoxText.Length ==9;
        }
        public bool IsPartNumberAlreadyInTheList(string textBoxText)
        {
            bool exists = NonOrginalList.Any(x => x.PartNumber == textBoxText);
            return !exists;
        }
        #endregion //end valid

        #region changes database
        public bool ChangeDataBase()
        {
            return DeleteDataBase() && InstertDataBase();
        }

        private bool DeleteDataBase()
        {
            var tempList = SetnonOrginalList();

            tempList.RemoveAll(x => NonOrginalList.Any(k => k.PartNumber == x.PartNumber));

            return tempList.Count == 0 || Agent.DeleteIntoDataBase(Mapper.MapPartsTolistDtoParts(tempList));
        }

        public bool InstertDataBase()
        {
            var list = (from parts in NonOrginalList
                        where GetParts.All(x => x.PartNumber != parts.PartNumber)
                        select parts).ToList();
            return
                list.Count == 0 || Agent.InstsertIntoDataBase(Mapper.MapPartsTolistDtoParts(list));
        }

        #endregion // changes database
    }
}
