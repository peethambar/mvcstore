using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DesignCT
{
    //eager initialization of singleton
    public class SingletonEager
    {
        private static SingletonEager instance = new SingletonEager();
        private SingletonEager() { }

        public static SingletonEager GetInstance
        {
            get
            {
                return instance;
            }
        }
    }

    ////lazy initialization of singleton
    public class SingletonLazy
    {
        private static SingletonLazy instance = null;
        private SingletonLazy() { }

        public static SingletonLazy GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonLazy();

                return instance;
            }
        }
    }

    ////Thread-safe (Double-checked Locking) initialization of singleton
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private SingletonThreadSafe() { }
        private static object lockThis = new object();

        public static SingletonThreadSafe GetInstance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                        instance = new SingletonThreadSafe();

                    return instance;
                }
            }
        }
    }
}
