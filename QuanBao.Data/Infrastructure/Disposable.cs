using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBao.Data.Infrastructure
{
    // IDisposable la interface cos san cua c#
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        // if huy ko dispose
        ~Disposable()
        {
            Dispose(false);
        }
        // dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);// thu hoi bo nho
        }

        private void Dispose(bool Disposing)
        {
            if(!isDisposed && Disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
       // override this to dispose custom object
         protected virtual void DisposeCore()
        {

        }

    }
}
