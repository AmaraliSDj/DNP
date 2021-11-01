using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DNP.Data
{
    public interface IAdultData
    {IList<Adult> GetAdults();

        Adult AddAdults(Adult adult);

        void RemoveAdults(int adultId);

        Task<Adult> Update(Adult adult);

        Adult Get(int id);
        
    }
}