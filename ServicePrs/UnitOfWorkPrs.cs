using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePrs
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<tblItem> tblItemRepository { get; }
        IGenericRepository<tblItemUnit> tblItemUnitRepository { get; }

        void Save();
        void SaveWithLog();

    }

    public class UnitOfWorkPrs : IUnitOfWork
    {
        private ModelPrs context = new ModelPrs();


        private IGenericRepository<tblItem> _tblItem;
        public IGenericRepository<tblItem> tblItemRepository
        {
            get
            {
                if (this._tblItem == null)
                {
                    this._tblItem = new GenericRepository<tblItem>(context);
                }
                return this._tblItem;
            }
        }

        private IGenericRepository<tblItemUnit> _tblItemUnit;
        public IGenericRepository<tblItemUnit> tblItemUnitRepository
        {
            get
            {
                if (this._tblItemUnit == null)
                {
                    this._tblItemUnit = new GenericRepository<tblItemUnit>(context);
                }
                return this._tblItemUnit;
            }
        }

        //public GenericRepository<T> getGeneric<T>() where T : class
        //{
        //    var repo = new GenericRepository<T>(context);
        //    return repo;
        //}


        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                            ve.PropertyName,
                                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                            ve.ErrorMessage);
                    }
                }
                throw;
            }

            //   context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SaveWithLog()
        {
            throw new NotImplementedException();
        }
    }
}
