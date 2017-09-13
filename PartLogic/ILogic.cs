using System.Collections.Generic;
using PartLogic.List_Classes;

namespace PartLogic
{
    // interface for the logic and passes values to it and returns to UI layer
    public interface ILogic
    {
        List<Parts> GetParts { get; }
        List<Parts> NonOrginalList { get; }
        int SetListAndGetCount();
        bool IsValid(string textBoxText);
        bool IsNumber(string textBoxText);
        bool IsNineLetter(string textBoxText);
        bool IsPartNumberAlreadyInTheList(string textBoxText);
        void AddtoGetPart(string partNumber, double partPrice, string partDescription);  
        void DeletePart(string partNumber);
        bool ChangeDataBase();
    }
}
