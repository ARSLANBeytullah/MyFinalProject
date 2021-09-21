using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz. Ama diğer katmanlar Core katmanını referans alırlar.
    // class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity,new() //T 'yi where ile sınırlandırabiliyoruz.(T referans tip olsun ve IEntity veya IEntity'den implemente edilen bir nesne olabilir.New lenmelidir ayrıca.Yani interfaceleri kullanamayız.) 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Filtre vermessek null'dür yani bir filtre vermessek tümünü getirir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
