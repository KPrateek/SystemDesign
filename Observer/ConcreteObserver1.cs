using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class ConcreteObserver1 : IObserver
    {
        public ConcreteObserver1(Subject subject)
        {
            subject.Attach(this);
        }

        public void Update(Object s)
        {
            int result = (s as Subject).GetData();
            Console.WriteLine(result);
        }
    }
}
