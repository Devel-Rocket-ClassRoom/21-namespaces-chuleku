using System;
using static System.Console;
using static System.Math;

///과제 1: 정규화된 이름으로 네임스페이스 사용
/*Foo.Car car = new Foo.Car();
car.mesage();

Bar.Car bar = new Bar.Car();
bar.mesage();
namespace Foo
{
    public class Car
    {
        public void mesage()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}
namespace Bar
{
    public class Car
    {
        public void mesage()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}*/
///과제 2: 중첩 네임스페이스 활용
/*Korea.Seoul.Car seoulcar = new Korea.Seoul.Car();
seoulcar.run();
Korea.Incheon.Car Incheoncar = new Korea.Incheon.Car();
Incheoncar.run();
namespace Korea.Seoul
{
    public class Car
    {
        public void run()
        {
            Console.WriteLine("서울 자동차가 달립니다.");
        }
    }
}
namespace Korea.Incheon
{
    public class Car
    {
        public void run()
        {
            Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}*/
///과제 3: using static 지시문
WriteLine("Hello, World!");
double result = Sqrt(16);
WriteLine($"제곱근: {result}");
double Maxvalue = Max(10, 20);
WriteLine($"최댓값: {Maxvalue}");