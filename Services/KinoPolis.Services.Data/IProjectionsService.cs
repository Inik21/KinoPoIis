using System.Collections.Generic;
using System.Text;

namespace KinoPolis.Services.Data
{
    public interface IProjectionsService
    {
        public T GetProjectionById<T>(int id);
    }
}
