using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Enums;
using Core.Utilities.Messages;
using CorporateArchitecture.Bll.Abstract;
using CorporateArchitecture.Bll.ValidationRules.FluentValidation;
using CorporateArchitecture.Dal.Abstract;
using CorporateArchitecture.Entity.ComplexTypes.Model;
using CorporateArchitecture.Entity.Concrete;
using System.Collections.Generic;
using System.Threading;

namespace CorporateArchitecture.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [ValidationAspect(typeof(ProductValidation), Priority = 1)]
        [LogAspect(typeof(FileLogger))]

        public ProductModel Add(ProductModel model)
        {
            try
            {
                _productDal.Add(model.Product);
                model.Message = NotificationMessages.Success;
            }
            catch (System.Exception ex)
            {
                model.IsError = true;
                model.StackTrace = ex.StackTrace;
                model.Code = NotificationEnums.DbError.GetHashCode();
                model.Message = NotificationMessages.ErrorSave;
            }
            return model;
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }
        //[CacheAspect(1)]
        //[PerformanceAspect(5)]
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
        //[TransactionScopeAspect]
        public Product Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
