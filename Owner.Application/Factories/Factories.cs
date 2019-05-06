using System;
using System.Collections.Generic;
using System.Text;

namespace Owner.Application.Factories
{
    public sealed class Factories
    {
        private static OwnerFactory ownerFactory = null;
        private static readonly object padlock = new object();

        Factories()
        {
        }

        public static OwnerFactory Owner
        {
            get
            {
                if (ownerFactory == null)
                {
                    lock (padlock)
                    {
                        if (ownerFactory == null)
                        {
                            ownerFactory = new OwnerFactory();
                        }
                    }
                }
                return ownerFactory;
            }
        }
    }
}
