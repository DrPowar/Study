using System;

namespace Main_Test.Polimorphism
{
    class VirtualMetods
    {   
        protected virtual void Bob()
        {
            Console.WriteLine("Я люблю їсти варене сало");
        }
        public virtual void Metod1()
        {
            Bob();
            Console.WriteLine("Я просто метод :-(");
        }
    }

    class VirtualMetods2 : VirtualMetods
    {
        protected override void Bob()
        {
            Console.WriteLine("Я люблю їсти траву");
        }
        public override void Metod1()
        {
            Bob();
            Console.Write("Я просто метод номер 2 ");
        }
    }

    class VirtualMetodUser
    {
        public void Print(VirtualMetods vm)
        {
            vm.Metod1();
        }
    }
}
