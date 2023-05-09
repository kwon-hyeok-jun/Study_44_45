////using System;

////namespace MethodOverridePractice
////{
////    public class ParentClass
////    {
////        public virtual void Hi1() => Console.WriteLine("기본: 안녕하세요.");
////        public void Hi2() => Console.WriteLine("기본: 반갑습니다.");
////        public void Hi3() => Console.WriteLine("기본: 또 만나요.");
////    }

////    public class ChildClass : ParentClass
////    {
////        public override void Hi1() => Console.WriteLine("파생: 안녕하세요.");
////        public new void Hi2() => Console.WriteLine("파생: 반갑습니다.");
////        public new void Hi3() => base.Hi3(); // 기본 클래스의 멤버에 접근
////    }

////    class Parent
////    {
////        public void Say() => Console.WriteLine("부모가 말하다.");
////        public void Hi() => Console.WriteLine("부모가 인사하다.");
////        public virtual void Walk() => Console.WriteLine("부모가 걷다.");
////    }

////    class Child : Parent
////    {
////        // 내가 새롭게 정의해서 사용하겠다.
////        //public void Say() => Console.WriteLine("자식이 말하다.");
////        // 새롭게 정의 : 오버라이드
////        public new void Hi() => Console.WriteLine("자식이 인사하다.");
////        // 새롭게 정의 : 오버라이드(override):재정의
////        public override void Walk() => Console.WriteLine("자식이 걷다.");
////    }

////    class MethodOverridePractice
////    {
////        static void Main()
////        {
////            ChildClass child = new ChildClass();
////            child.Hi1(); // virtual -> override
////            child.Hi2(); // X -> new
////            child.Hi3(); // X <- base

////            Child baby = new Child();
////            baby.Say(); // 자식이 예의가 없다.
////            baby.Hi(); // 자식이 예의바르다.
////            baby.Walk(); // 부모가 관대하다.
////        }
////    }
////}
////using System;

////// 인터페이스
////interface IPerson
////{
////    void Work();
////}

////// 클래스
////class Person : IPerson
////{
////    public void Work() => Console.WriteLine("일을 합니다.");
////}

////// 메인
////class InterfaceExam
////{
////    static void Main()
////    {
////        Person person = new Person();
////        person.Work();
////    }
////}

//using System;

//namespace InterfaceDemo
//{
//    // 배터리 표준(강제성)
//    interface IBattery
//    {
//        string GetName(); // 메서드 시그니처만 표시
//    }

//    class Good : IBattery
//    {
//        public string GetName() => "Good";
//    }

//    class Bad : IBattery
//    {
//        public string GetName() => "Bad";
//    }

//    class Car
//    {
//        private IBattery _battery;

//        //[1] 생성자의 매개 변수로 인터페이스 형식 지정
//        public Car(IBattery battery)
//        {
//            _battery = battery; // 넘어온 개체가 _battery 필드에 저장
//        }

//        public void Run() => Console.WriteLine(
//            "{0} 배터리를 장착한 자동차가 달립니다.", _battery.GetName());
//    }

//    class InterfaceDemo
//    {
//        static void Main(string[] args)
//        {
//            //[A] 넘겨주는 개체에 따라서 배터리 이름이 다르게 표시 
//            var good = new Car(new Good()); good.Run();
//            new Car(new Bad()).Run(); // 개체 만들기와 동시에 메서드 실행
//        }
//    }
//}

//[?] IEnumerator 인터페이스 사용해보기
using System;
using System.Collections;

class IEnumeratorDemo
{
    static void Main()
    {
        string[] names = { "닷넷코리아", "비주얼아카데미" };

        //[1] foreach 문으로 출력
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //[2] IEnumerator 인터페이스를 통한 데이터 출력: foreach문과 동일
        IEnumerator list = names.GetEnumerator(); // 하나씩 열거
        while (list.MoveNext()) // 값이 있는 동안 반복
        {
            Console.WriteLine(list.Current); // 현재 반복중인 데이터 출력
        }
    }
}
