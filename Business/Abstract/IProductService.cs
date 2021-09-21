using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();  //IDataResult<List<Product>> hem işlem sonucunu hem mesajı içeren hem döndüreceği tipi içeren(List<Product>) içerir. Öncesinde List<Product> diyerek sadece dönüş tipini belirtmiştik. Şimdiki yapı ise çok daha işlevsel olmuş oldu.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //void döndürmek yerine artık IResult diyoruz.
    }
}
