using BojTheft.Bll.Models;
using System.Collections.Generic;

namespace BojTheft.Bll.Interface
{
    public interface ITheftManager
    {
        List<TheftModel> GetThefts();
        TheftModel GetTheftById(int id);
    }
}
