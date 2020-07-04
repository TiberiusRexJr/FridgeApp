using System;

namespace FridgeApp.Database
{
    public sealed class Database
    {
        private static volatile IMyObject instance;
        private static Object syncRootObject = new Object();
    
        public static IMyObject Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRooObject)
                    {
                        if (instance == null)
                        {
                            instance = new MyObject();
                        }
                    }
                }
                return instance;
            }
        }
    }
}