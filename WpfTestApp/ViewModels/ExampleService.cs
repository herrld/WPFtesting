using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityInjection;

namespace ViewModels
{
    class ExampleService : IExampleService
    {
        private readonly IExampleManager _exampleManager;

        public ExampleService():this(DependencyFactory.Resolve<IExampleManager>())
        {

        }

        public ExampleService(IExampleManager exampleManager)
        {
            this._exampleManager = exampleManager;
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public class ExampleManager : IExampleManager
    {
        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
