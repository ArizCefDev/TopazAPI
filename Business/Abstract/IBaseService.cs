using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<RqDTO, TEntity, RsDTO>
    {
        IEnumerable<RsDTO> GetAll();
        RsDTO GetById(int id);
        RsDTO Insert(RqDTO dto);
        void Update(RqDTO dto);
        void Delete(int id);
    }
}
