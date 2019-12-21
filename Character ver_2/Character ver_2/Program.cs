//add functions and debug


using System;

namespace Console_game_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person_2 person_2 = new Person_2();

            Console.WriteLine("게임설명");
            Console.WriteLine("BadGuy라는 사람이 있습니다.");
            Console.WriteLine("그 사람은 공격도하고 방어도 합니다.");
            Console.WriteLine("공격을해 BadGuy의 HP를 0으로 만드세요.");


            Console.WriteLine("공격력을 입력해주세요.");
            person.power = int.Parse(Console.ReadLine());


            Console.WriteLine("체력을 입력해주세요.");
            person.HP = int.Parse(Console.ReadLine());


            Console.WriteLine("방어력을 입력해주세요.");
            person.defense = int.Parse(Console.ReadLine());




            while (true)
            {
                Console.WriteLine("공격 or 방어");

                string choose = Console.ReadLine();

                if (choose == "공격")
                {
                    person.attack();
                }


                if (choose == "방어")
                {
                    person.protect();
                }                                               
            }
        }

    }
    class Person
    {
        public int HP;
        public int power;
        public int defense;


        
        public void protect()
        {
            Random ra = new Random();
            int a = ra.Next(1,100);

            BadGuy badGuy = new BadGuy();

            badGuy.power = badGuy.power - a;
            
            
            Console.WriteLine("이만큼 공격이 들어왔습니다.{0}",a);
            Console.WriteLine("얼마만큼 방어 하시겠습니까?");
            int aw = int.Parse(Console.ReadLine());


            int num = 0;
            while(num < 5)
            {
                num++;
                Console.WriteLine("방어중...");

            }

            if (aw < a)
            {
                Console.WriteLine("방어에 실패했습니다.");

                Console.WriteLine("HP가{0}{1}", a, "만큼줄어듭니다.");

                HP = HP - a;

                Console.WriteLine("남은 HP:{0}", HP); 
            }

            if (aw > a)
            {
                Console.WriteLine("방어에 성공했습니다.");

                Console.WriteLine("방어력이{0}{1}", 10, "만큼줄어듭니다.");

                defense = defense - 10;

                Console.WriteLine("남은 방어력:{0}", defense);
                
            }

            if (HP < 0)
            {
                Console.WriteLine("사망하셨습니다.");
                Console.WriteLine("캐릭터가 하나 더 남았습니다.");
                Console.WriteLine("부활하시겠습니까?  y/n");

                string aq = Console.ReadLine();

                if (aq == "y")
                {
                    Person_2 person_2 = new Person_2();
                    
                    Console.WriteLine("남은HP:{0}", person_2.HP);
                    Console.WriteLine("남은 공격력:{0}", person_2.power);
                    Console.WriteLine("남은 방어력:{0}", person_2.defense);
                }
            }
            
            
            
            if (aw > a)
            {
                Console.WriteLine("방어에 성공했습니다.");
                Console.WriteLine("방어력이{0}{1}", aw, " 만큼 줄어듭니다.");

                defense = defense - aw;

                Console.WriteLine("남은 방어력:{0}", defense);
            }
            
            
        }
            
        public void attack()
        {

            Random r = new Random();
            int i = r.Next(0, 10);

            Console.WriteLine("얼만큼 공격?");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("공격을 시작합니다.");

            int a = 0;

            while (a < 5)
            {
                a++;
                Console.WriteLine("공격중...");

            }

            if (i < 5)
            {
                Console.WriteLine("공격에 실패하였습니다.");
                Console.WriteLine("다시 공격하세요.");
            }
            else if (i > 6)
            {
                Console.WriteLine("공격에 성공했습니다.");
                Console.WriteLine("공격력이{0}{1}", x ,"만큼떨어집니다");
                power = power - x;

                Console.WriteLine("남은 공격력{0}", power);

                BadGuy badGuy = new BadGuy();

                badGuy.HP = badGuy.HP - x;

                Console.WriteLine("BadGuty의 HP가{0}{1}", x, "만큼 줄어들었습니다.");
                Console.WriteLine("BadGuy의 HP:{0}");

                if (badGuy.HP < 0)
                {
                    Console.WriteLine("축하합니다.");
                    Console.WriteLine("이겼습니다.");
                }
            }

            else
            {
                Console.WriteLine("스킬이 사용됩니다.");
                for (int v = 0; v < 5; v++)
                {
                    Console.WriteLine("스킬 사용중...");
                }

                Console.WriteLine("스킬사용에 성공했습니다.");
                Console.WriteLine("공격은 100만큼 들어갔지만 공격력이 떨어지지는 않았습니다.");

                BadGuy badGuy = new BadGuy();
                badGuy.HP = badGuy.HP - x;

                Console.WriteLine("BadGuty의 HP가{0}{1}", 100, "만큼 줄어들었습니다.");

                if (badGuy.HP < 0)
                {
                    Console.WriteLine("축하합니다.");
                    Console.WriteLine("이겼습니다.");
                }


            }

        }
    }

    class Person_2 : Person
    {
       
    }


    class BadGuy
    {
        public int HP = 100;
        public int power = 100;
        public int defense = 100;

    }  
}

