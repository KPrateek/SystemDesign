using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            IWidgetFactory widgetFactory = FactoryMaker.getFactory("PM");
            IScrollBar scrollBar = widgetFactory.CreateScrollBar();
            IWindow window = widgetFactory.CreateWindow();

            scrollBar.MoveDown();
            scrollBar.SetColor();
            scrollBar.MoveUp();
            scrollBar.SetHeight();

            window.SetHeight();
            window.SetWidth();

        }
    }

    //Factory creator - an indirect way of instantiating the factories
    class FactoryMaker
    {
        private static IWidgetFactory widgetFactory = null;
        public static IWidgetFactory getFactory(String choice)
        {
            if (choice.Equals("PM"))
            {
                widgetFactory = new PMWidgetFactory();
            }
            else if (choice.Equals("Motif"))
            {
                widgetFactory = new MotifWidgetFactory();
            }
            return widgetFactory;
        }
    }
    /// <summary>
    /// ///////////  ABSTRACT PRODUCT - 1
    /// </summary>
    interface IWindow
    {
        void SetColor();
        void SetWidth();
        void SetHeight();
    }

    /// <summary>
    /// ///////////  CONCRETE PRODUCT - 1
    /// </summary>
    public class PMWindow : IWindow
    {
        public void SetColor()
        {
           Console.WriteLine("Setting PMWindow color");
        }

        public void SetWidth()
        {
            Console.WriteLine("Setting PMWindow width");
        }

        public void SetHeight()
        {
            Console.WriteLine("Setting PMWindow height");
        }

    }

    /// <summary>
    /// ///////////  CONCRETE PRODUCT - 2
    /// </summary>
    public class MotifWindow : IWindow
    {
        public void SetColor()
        {
            Console.WriteLine("Setting MotifWindow color");
        }

        public void SetWidth()
        {
            Console.WriteLine("Setting MotifWindow width");
        }

        public void SetHeight()
        {
            Console.WriteLine("Setting MotifWindow height");
        }

    }

    /// <summary>
    /// //// ABSTRACT PRODUCT B
    /// </summary>
    interface IScrollBar
    {
        void MoveUp();
        void MoveDown();
        void SetColor();
        void SetWidth();
        void SetHeight();
    }

    public class PMScrollBar : IScrollBar
    {
        public void MoveUp()
        {
            Console.WriteLine("Moving up PMScrollBar");
        }
        public void MoveDown()
        {
            Console.WriteLine("Moving down PMScrollBar");
        }
        public void SetColor()
        {
            Console.WriteLine("Setting color of PMScrollBar");
        }
        public void SetWidth()
        {
            Console.WriteLine("Setting width of PMScrollBar");
        }
        public void SetHeight()
        {
            Console.WriteLine("Setting height of PMScrollBar");
        }
       
    }

    public class MotifScrollBar : IScrollBar
    {
        public void MoveUp()
        {
            Console.WriteLine("Moving up MotifScrollBar");
        }
        public void MoveDown()
        {
            Console.WriteLine("Moving down MotifScrollBar");
        }
        public void SetColor()
        {
            Console.WriteLine("Setting color of MotifScrollBar");
        }
        public void SetWidth()
        {
            Console.WriteLine("Setting width of MotifScrollBar");
        }
        public void SetHeight()
        {
            Console.WriteLine("Setting height of MotifScrollBar");
        }

    }

    interface IWidgetFactory
    {
        IWindow CreateWindow();
        IScrollBar CreateScrollBar();
    }

    class MotifWidgetFactory : IWidgetFactory
    {
        public IWindow CreateWindow()
        {
            return new MotifWindow();
        }

        public IScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }
    }

    class PMWidgetFactory : IWidgetFactory
    {
        public IWindow CreateWindow()
        {
            return new PMWindow();
        }

        public IScrollBar CreateScrollBar()
        {
            return new PMScrollBar();
        }
    }
}
