using BojTheft.Dal.Interface;
using BojTheft.Dal.Pocos;
using System.Collections.Generic;

namespace BojTheft.Dal.MockRepositorys
{
    public class TheftMockRepositiry : ITheftRepositiry
    {
        public Theft GetTheftById(int id)
        {
            return new Theft
            {
                Email = "Email",
                Id = 1,
                Name = "Name",
                PhoneNumber = 21345
            };
        }

        public List<Theft> GetThefts()
        {
            return new List<Theft> {
                new Theft
                {
                    Email = "Email",
                    Id = 1,
                    Name ="Name",
                    PhoneNumber = 21345
                }
            };
        }
    }
}
