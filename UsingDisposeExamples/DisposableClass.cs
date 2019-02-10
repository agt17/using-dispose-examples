using System;
using System.ComponentModel;

namespace UsingDisposeExamples
{
    class DisposableClass : IDisposable
    {
        bool disposed = false;
        private Component component = new Component();

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool b)
        {
            if (!this.disposed)
            {
                component.Dispose();
                Console.WriteLine("disposing");
            }
            disposed = true;
        }
    }
}
