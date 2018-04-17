using System;

namespace Cms.Data.Infrastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposeable;

        ~Disposeable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposeable && disposing)
            {
                DisposeCore();
            }

            isDisposeable = true;
        }

        //Override this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}