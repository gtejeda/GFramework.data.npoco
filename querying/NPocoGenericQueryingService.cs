using System.Collections.Generic;
using GFramework.core.domainEntities;
using NPoco;

namespace GFramework.data.npoco.querying
{
    public class NPocoGenericQueryingService<T> : INPocoGenericQueryingService<T> where T : IEntity
    {

        private readonly IDatabase db;

        public NPocoGenericQueryingService(IDatabase DB)
        {
            db = DB;
        }




        public IList<T> GetAll()
        {
            return db.Fetch<T>();
        }


        public T GetSingle(object Id)
        {
            return db.SingleById<T>(Id);
        }


        public IList<T> GetAll(string WhereSQLQuery, object[] Parameters)
        {
            return db.Fetch<T>(WhereSQLQuery, Parameters);
        }


        public T GetSingle(string WhereSQLQuery, object[] Parameters)
        {
            return db.Single<T>(WhereSQLQuery, Parameters);
        }

    }
}
