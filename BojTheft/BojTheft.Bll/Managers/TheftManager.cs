using AutoMapper;
using BojTheft.Bll.Interface;
using BojTheft.Bll.Models;
using BojTheft.Dal.Interface;
using System.Collections.Generic;

namespace BojTheft.Bll.Managers
{
    public class TheftManager : ITheftManager
    {
        private readonly ITheftRepositiry _theftRepositiry;
        private readonly IMapper _mapper;

        public TheftManager(ITheftRepositiry theftRepositiry, IMapper mapper)
        {
            _theftRepositiry = theftRepositiry;
            _mapper = mapper;
        }

        public List<TheftModel> GetThefts()
        {
            return _mapper.Map<List<TheftModel>>(_theftRepositiry.GetThefts());
        }

        public TheftModel GetTheftById(int id)
        {
            return _mapper.Map<TheftModel>(_theftRepositiry.GetTheftById(1));
        }
    }
}
