using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Sparta_Dungeon.Program;

namespace Sparta_Dungeon
{
    internal class Program
    {
        // 플레이어 클래스
        public class Player
        {
            public int Level { get; set; }
            public string Name { get; }
            public string Class { get; }
            public int AttackPower { get; set; }
            public int DefensivePower { get; set; }
            public int Health { get; set; }
            public int Gold { get; set; }
            public bool Flag_equipWeaphon { get; set; }
            public bool Flag_equipArmor { get; set; }

            public List<Item> UserItems { get; set; }

            public Player(string name)
            {
                Level = 1;
                Name = name;
                Class = "도적";
                AttackPower = 10;
                DefensivePower = 5;
                Health = 10;
                Gold = 15000;
                UserItems = new List<Item>();

                Flag_equipWeaphon = false;
                Flag_equipArmor = false;
            }
        }

        // 아이템 인터페이스 정의
        public interface Item
        {
            string Name { get; }
            int Number { get; }
            int Gold { get; }
            bool flag_buy { get; set; }
            bool flag_equip { get; set; }
            string Explain { get; }
            public int DefensivePower { get; }
            public int AttackPower { get; }

            void Buy(Player player);
        }

        // 아이템 목록 클래스
        public class ItemIndex
        {
            public List<Item> Itemindex { get; set; }
            public bool Flag_Shopbuy { get; set; }

            public ItemIndex()
            {
                Itemindex = new List<Item>() { new Armor1(), new Armor2(), new Armor3(), new Weaphon1(), new Weaphon2(), new Weaphon3() };
                Flag_Shopbuy = false;
            }
        }

        // 방어구1
        public class Armor1 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int DefensivePower { get; }
            public int AttackPower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }
            public Armor1()
            {
                Number = 1;
                Name = "수련자 갑옷";
                Explain = "수련에 도움을 주는 갑옷입니다.";
                DefensivePower = 5;
                AttackPower = 0;
                Gold = 1000;

                flag_buy = false;
                flag_equip = false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 방어구2
        public class Armor2 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int DefensivePower { get; }
            public int AttackPower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }
            public Armor2()
            {
                Number = 2;
                Name = "무쇠 갑옷";
                Explain = "무쇠로 만들어져 튼튼한 갑옷입니다.";
                DefensivePower = 9;
                AttackPower = 0;
                Gold = 2000;
                flag_buy = false;
                flag_equip |= false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 방어구3
        public class Armor3 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int DefensivePower { get; }
            public int AttackPower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }
            public Armor3()
            {
                Number = 3;
                Name = "스파르타의 갑옷";
                Explain = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
                DefensivePower = 15;
                AttackPower = 0;
                Gold = 3500;
                flag_buy = false;
                flag_equip = false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 공격 무기1
        public class Weaphon1 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int AttackPower { get; }
            public int DefensivePower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }
            public Weaphon1()
            {
                Number = 4;
                Name = "낡은 검";
                Explain = "쉽게 볼 수 있는 낡은 검 입니다.";
                AttackPower = 2;
                DefensivePower = 0;
                Gold = 600;
                flag_buy = false;
                flag_equip = false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 공격 무기2
        public class Weaphon2 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int AttackPower { get; }
            public int DefensivePower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }

            public Weaphon2()
            {
                Number = 5;
                Name = "청동 도끼";
                Explain = "어디선가 사용됐던거 같은 도끼입니다.";
                AttackPower = 5;
                DefensivePower = 0;
                Gold = 1500;
                flag_buy = false;
                flag_equip = false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 공격 무기3
        public class Weaphon3 : Item
        {
            public int Number { get; }
            public string Name { get; }
            public string Explain { get; }
            public int AttackPower { get; }
            public int DefensivePower { get; }
            public int Gold { get; }
            public bool flag_buy { get; set; }
            public bool flag_equip { get; set; }
            public Weaphon3()
            {
                Number = 6;
                Name = "스파르타의 창";
                Explain = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
                AttackPower = 7;
                DefensivePower = 0;
                Gold = 2500;
                flag_buy = false;
                flag_equip = false;
            }

            public void Buy(Player player)
            {
                if (!flag_buy)
                {
                    if (player.Gold - Gold > 0)
                    {
                        player.Gold -= Gold;
                        flag_buy = true;
                        Console.WriteLine("구매를 완료했습니다.");
                    }
                    else
                        Console.WriteLine("Gold가 부족합니다.");
                }
            }
        }

        // 잘못된 입력
        public static void WrongInput()
        {
            Console.WriteLine();
            Console.WriteLine("잘못된 입력입니다.");
            Thread.Sleep(1000); // 입력 후에 1초 대기
        }

        // 초기 화면
        public static void Init(Player player, ItemIndex Itemindex)
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 게임 종료");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    State(player, Itemindex);
                    break;
                case 2:
                    Inventory(player, Itemindex);
                    break;
                case 3:
                    Shop(player, Itemindex);
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                default:
                    WrongInput();
                    Init(player, Itemindex);
                    break;
            }
        }

        // 상태창
        public static void State(Player player, ItemIndex Itemindex)
        {
            int equipArmorPower = 0;
            int equipWeaponPower = 0;

            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. " + player.Level.ToString("D2"));
            Console.WriteLine();
            Console.WriteLine("Chad ( {0} )", player.Class);

            if (player.UserItems.Count != 0)
            {
                // 장착된 아이템 찾기
                Item selectItem = player.UserItems.Find(item => item.flag_equip == true);
                foreach (var item in player.UserItems)
                {
                    if (item.flag_equip)
                    {
                        if (item.Number >= 1 && item.Number <= 3)
                        {
                            player.Flag_equipArmor = true;
                            equipArmorPower += item.DefensivePower;
                        }
                        else
                        {
                            player.Flag_equipWeaphon = true;
                            equipWeaponPower += item.AttackPower;
                        }
                    }
                }
            }

            if (!player.Flag_equipWeaphon)
                Console.WriteLine("공격력 : " + player.AttackPower);
            else
                Console.WriteLine("공격력 : " + player.AttackPower + " (+{0})", equipWeaponPower);
            if (!player.Flag_equipArmor)
                Console.WriteLine("방어력 : " + player.DefensivePower);
            else
                Console.WriteLine("방어력 : " + player.DefensivePower + " (+{0})", equipArmorPower);

            Console.WriteLine("체력 : " + player.Health);
            Console.WriteLine("Gold : {0} G", player.Gold);
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Init(player, Itemindex);
            }
            else
            {
                WrongInput();
                State(player, Itemindex);
            }
        }

        // 인벤토리
        public static void Inventory(Player player, ItemIndex Itemindex)
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 0:
                    Init(player, Itemindex);
                    break;
                case 1:
                    Inventory_weapon(player, Itemindex);
                    break;
                default:
                    WrongInput();
                    Inventory(player, Itemindex);
                    break;
            }
        }

        // 상점
        public static void Shop(Player player, ItemIndex Itemindex)
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();

            Console.WriteLine("[보유 골드]");
            Console.WriteLine("{0} G", player.Gold);
            Console.WriteLine();

            Console.WriteLine("[아이템 목록]");

            if (Itemindex != null)
            {
                int i = 1;
                // 아이템 목록 불러오기
                foreach (var item in Itemindex.Itemindex)
                {
                    if (!Itemindex.Flag_Shopbuy)
                    {
                        if (!item.flag_buy)
                        {
                            if (item.AttackPower == 0)
                                Console.WriteLine($"- {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}   | {item.Gold} G");
                            else
                                Console.WriteLine($"- {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}   | {item.Gold} G");
                        }
                        else
                        {
                            if (item.AttackPower == 0)
                                Console.WriteLine($"- {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}   |  구매완료");
                            else
                                Console.WriteLine($"- {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}   |  구매완료");
                        }
                    }
                    else
                    {
                        if (!item.flag_buy)
                        {
                            if (item.AttackPower == 0)
                                Console.WriteLine($"- {i++} {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}   | {item.Gold} G");
                            else
                                Console.WriteLine($"- {i++} {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}   | {item.Gold} G");
                        }
                        else
                        {
                            if (item.AttackPower == 0)
                                Console.WriteLine($"- {i++} {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}   |  구매완료");
                            else
                                Console.WriteLine($"- {i++} {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}   |  구매완료");
                        }
                    }
                }
            }

            Console.WriteLine();
            if (!Itemindex.Flag_Shopbuy)
                Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            if (!Itemindex.Flag_Shopbuy)
            {
                switch (input)
                {
                    case 0:
                        Init(player, Itemindex);
                        break;
                    case 1:
                        Itemindex.Flag_Shopbuy = true;
                        Shop(player, Itemindex);
                        break;
                    default:
                        WrongInput();
                        Shop(player, Itemindex);
                        break;
                }
            }
            else
            {
                if (input == 0)
                {
                    Itemindex.Flag_Shopbuy = false;
                    Init(player, Itemindex);
                }
                else
                {
                    Item selectItem = Itemindex.Itemindex.Find(item => item.Number == input);
                    if (selectItem != null)
                    {
                        if (!selectItem.flag_buy)
                        {
                            selectItem.Buy(player);
                            player.UserItems.Add(selectItem);
                            Thread.Sleep(1000);
                            Shop(player, Itemindex);
                        }
                        else
                        {
                            Console.WriteLine("이미 구매한 아이템 입니다.");
                            Thread.Sleep(1000);
                            Shop(player, Itemindex);
                        }
                    }
                    else
                    {
                        WrongInput();
                        Shop(player, Itemindex);
                    }
                }
            }
        }

        // 인벤토리 - 장착관리
        public static void Inventory_weapon(Player player, ItemIndex Itemindex)
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            if (player.UserItems.Count != 0)
            {
                foreach (var item in player.UserItems)
                {
                    if (!item.flag_equip)
                    {
                        if (item.AttackPower == 0)
                            Console.WriteLine($"- {item.Number} {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}");
                        else
                            Console.WriteLine($"- {item.Number} {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}");
                    }
                    else
                    {
                        if (item.AttackPower == 0)
                            Console.WriteLine($"- {item.Number} [E] {item.Name}   | 방어력 +{item.DefensivePower}   | {item.Explain}");
                        else
                            Console.WriteLine($"- {item.Number} [E] {item.Name}   | 공격력 +{item.AttackPower}   | {item.Explain}");
                    }
                }
            }
            else
                Console.WriteLine("보유하고 있는 장비가 없습니다.");

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Init(player, Itemindex);
            }
            else
            {
                Item selectItem = player.UserItems.Find(item => item.Number == input);
                if (selectItem != null)
                {
                    if (!selectItem.flag_equip)
                    {
                        selectItem.flag_equip = true;
                        Inventory_weapon(player, Itemindex);
                    }
                    else
                    {
                        selectItem.flag_equip = false;
                        Inventory_weapon(player, Itemindex);
                    }
                }
                else
                {
                    WrongInput();
                    Inventory_weapon(player, Itemindex);
                }
            }
        }
        static void Main(string[] args)
        {
            ItemIndex Itemindex = new ItemIndex(); // 아이템 목록 생성
            Player player = new Player("Player1");  // 플레이어 생성

            Init(player, Itemindex); // 초기화면 실행
        }
    }
}
