using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Subject
    {
        private int SubjectInteger;

        private List<IObserver> observerList = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observerList.Add(observer);
        }

        private void Detach(IObserver observer)
        {
            observerList.Remove(observer);
        }


        public void SetData(int i)
        {
            SubjectInteger = i;
            foreach (var observer in observerList)
            {
                observer.Update(this);
            }
        }

        public int GetData()
        {
            return SubjectInteger;
        }

    }
}
