using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifier1
{
    class A
    {
        private void showAPriv() {
            Console.WriteLine("Hello");
        }

        protected void showAProtected()
        {
            Console.WriteLine("Hello");
        }

        public void showAPublic()
        {
            Console.WriteLine("Hello");
        }

        protected internal void showAProtectedInternal()
        {
            Console.WriteLine("Hello");
        }

        internal void showAInternal()
        {
            Console.WriteLine("Hello");
        }
    }
}
