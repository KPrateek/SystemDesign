using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ConcreteObserver1 concreteObserver1 = new ConcreteObserver1(subject);
            ConcreteObserver2 concreteObserver2 = new ConcreteObserver2(subject);
            subject.SetData(5);
        }
    }


}
