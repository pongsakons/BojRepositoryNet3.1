using BojTheft.Dal.Pocos;
using System.Collections.Generic;

namespace BojTheft.Dal.Interface
{
    public interface ITheftRepositiry
    {
        List<Theft> GetThefts();
        Theft GetTheftById(int id);
    }
}
