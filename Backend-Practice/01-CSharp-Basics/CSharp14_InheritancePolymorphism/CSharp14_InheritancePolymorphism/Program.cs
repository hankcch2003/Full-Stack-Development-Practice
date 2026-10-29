using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十四章：繼承與多型");
        Console.WriteLine("================================");

        // 一、建立父類別物件
        Animal animal = new Animal("一般動物");

        Console.WriteLine();
        Console.WriteLine("========== 父類別 ==========");
        animal.ShowInfo();
        animal.MakeSound();

        // 二、建立子類別物件
        Dog dog = new Dog("小白", "柴犬");

        Console.WriteLine();
        Console.WriteLine("========== 狗的資料 ==========");
        dog.ShowInfo();
        dog.MakeSound();
        dog.Run();

        // 三、另一個子類別覆寫方法
        Cat cat = new Cat("小橘");

        Console.WriteLine();
        Console.WriteLine("========== 貓的資料 ==========");
        cat.ShowInfo();
        cat.MakeSound();

        // 四、多型：父類別型別的變數可以參考子類別物件。
        // 呼叫 virtual 方法時，會執行實際物件覆寫後的方法。

        Animal animal1 = new Dog("阿柴", "柴犬");
        Animal animal2 = new Cat("咪咪");

        Console.WriteLine();
        Console.WriteLine("========== 多型 ==========");
        animal1.MakeSound();
        animal2.MakeSound();

        // 五、使用父類別陣列統一處理不同子類別。
        Animal[] animals =
        {
            new Dog("旺財", "米克斯"),
            new Cat("雪球"),
            new Dog("豆豆", "柯基")
        };

        Console.WriteLine();
        Console.WriteLine("========== 動物清單 ==========");
        foreach (Animal item in animals)
        {
            item.ShowInfo();
            item.MakeSound();
            Console.WriteLine();
        }
    }
}

// 父類別：定義所有動物共通的資料與功能。
class Animal
{
    public string Name;

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine(Name + " 發出動物的叫聲");
    }

    public void ShowInfo()
    {
        Console.WriteLine("名稱：" + Name);
    }
}

// Dog 繼承 Animal，取得父類別的公開成員。
class Dog : Animal
{
    public string Breed;

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    // override 覆寫父類別的 virtual 方法。
    public override void MakeSound()
    {
        Console.WriteLine(Name + " 汪汪叫");
    }

    public void Run()
    {
        Console.WriteLine(Name + " 正在奔跑");
    }

    public new void ShowInfo()
    {
        Console.WriteLine("名稱：" + Name);
        Console.WriteLine("品種：" + Breed);
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " 喵喵叫");
    }
}