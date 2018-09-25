using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePrs
{
    public class UnitOfWorkPrs : IDisposable
    {
        private ModelPrs context = new ModelPrs();
        private GenericRepository<tblItem> _tblItem;


        public GenericRepository<tblItem> tblItemRepository
        {
            get
            {
                return this._tblItem ?? new GenericRepository<tblItem>(context);
            }
        }


        public GenericRepository<T> getGeneric<T>() where T : class
        {
            var repo = new GenericRepository<T>(context);
            return repo;
        }


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


    }
}
