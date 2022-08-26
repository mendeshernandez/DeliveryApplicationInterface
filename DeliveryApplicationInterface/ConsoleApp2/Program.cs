using System;

namespace DeliveryApplication
{
    interface ITitle
    {
        void TitleDelivery();
    }

    interface IVersion
    {
        void GetVersion();
    }

    interface IValidate
    {
        void IsValidate();
    }

    interface ILog : ITitle, IVersion, IValidate
    {
        void Debug();
    }

    class DeliveryInitialization : ILog
    {
        public void TitleDelivery()
        {
            var Title = "Grab";
            Console.WriteLine(Title);
        }

        public void IsValidate()
        {
            bool isValidate = true;

            Console.WriteLine(isValidate);
        }

        public void GetVersion()
        {
            var Version = 1.0;
            Console.WriteLine($"Version App : {Version}" );
        }

        public void Debug()
        {
            Console.WriteLine("Debuging");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dp = new DeliveryInitialization();

            dp.TitleDelivery();
            dp.IsValidate();
            dp.GetVersion();
            dp.Debug();
        }
    }
}