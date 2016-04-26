using System;
using System.Reflection;
using Ninject;

namespace CrossLogger.Code
{
    public static class NinjectConfig
    {
        public static Lazy<IKernel> CreateKernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            //RegisterServices(kernel);

            return kernel;
        });



    }
}