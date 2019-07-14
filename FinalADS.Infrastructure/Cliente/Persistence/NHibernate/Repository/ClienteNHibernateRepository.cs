using FinalADS.Domain.Clientes.Contracts;
using FinalADS.Domain.Clientes.Entities;
using FinalADS.Infrastructure.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Linq;

namespace FinalADS.Infrastructure.Clientes.Persistence.NHibernate.Repository
{
    public class ClienteNHibernateRepository : NHibernateRepository<Cliente>, IClienteRepository
    {
        public ClienteNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }

       /* public Account GetByNumber(string accountNumber)
        {
            return _unitOfWork.GetSession()
                .Query<Account>()
                .SingleOrDefault(x => x.Number == accountNumber);
        }
        */
        /*
        public Account GetByNumberWithUpgradeLock(string accountNumber)
        {            
            ICriteria criteria = _unitOfWork.GetSession().CreateCriteria<Account>();
            criteria.SetLockMode(LockMode.Upgrade);
            criteria.Add(Restrictions.Eq("Number", accountNumber));
            Account account = (Account) criteria.UniqueResult();
            return account;
        }
        */
    }
}
