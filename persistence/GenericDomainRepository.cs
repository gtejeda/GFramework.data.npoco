using GFramework.core.domainEntities;
using GFramework.core.exceptions;
using GFramework.core.persistence;
using NPoco;

namespace GFramework.data.npoco.persistence
{
    public class GenericDomainRepository : IDefaultDomainRepository
    {
        private readonly IDatabase db;
        public GenericDomainRepository(IDatabase DB)
        {
            db = DB;
        }



        /// <summary>
        /// The Dapper Repository as every other repository should receive a Domain Object to maintain the validity of the Domain,
        /// It will also call the IsValid Function on the DomainEntity
        /// </summary>
        /// <param name="DomainEntity">A Domain Entity should never be invalid</param>
        public void Create(IDomainEntity DomainEntity)
        {
            DomainEntity.Validate();

            if (!DomainEntity.IsValid)
                throw new EntityIsInvalidException();

            dynamic n = DomainEntity;

            db.Insert(n);
        }



        /// <summary>
        /// The Dapper Repository as every other repository should receive a Domain Object to maintain the validity of the Domain,
        /// It will also call the IsValid Function on the DomainEntity
        /// </summary>
        /// <param name="DomainEntity">A Domain Entity should never be invalid</param>
        public void Update(IDomainEntity DomainEntity)
        {
            DomainEntity.Validate();

            if (!DomainEntity.IsValid)
                throw new EntityIsInvalidException();

            dynamic n = DomainEntity;

            db.Update(n);
        }



        public void Delete(IDomainEntity DomainEntity)
        {
            dynamic n = DomainEntity;
            db.Delete(n);
        }




    }
}
