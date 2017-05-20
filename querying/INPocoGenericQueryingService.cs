using System.Collections.Generic;
using GFramework.core.domainEntities;
using GFramework.core.querying;

namespace GFramework.data.npoco.querying
{
    public interface INPocoGenericQueryingService<T> : IDefaultQueryingService<T> where T : IEntity
    {

        IList<T> GetAll(string WhereSQLQuery, object[] Parameters);

        T GetSingle(string WhereSQLQuery, object[] Parameters);

    }
}
