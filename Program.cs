using System.Diagnostics.Contracts;

namespace TextRpg
{
    internal class Program
    {
        public class Player
        {
            public int Lv;
            public string Name;
            public string Job;
            public int Atk;
            public int Def;
            public int Hp;
            public int Gold;

            public void NewPlayer()
            {

                Name = "Nobody";
                Job = "전사";
                Lv = 1;
                Atk = 10;
                Def = 5;
                Hp = 100;
                Gold = 1500;


            }

            public void OpenStatus()
            {
                //상태창
                Console.Clear();
                Console.WriteLine("상태보기.");
                Console.WriteLine();
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine("LV. 0" + Lv);
                Console.Write(Name + " ");
                Console.WriteLine(Job);
                Console.WriteLine("공격력 : " + Atk);
                Console.WriteLine("방어력 : " + Def);
                Console.WriteLine("체력 : " + Hp);
                Console.WriteLine("Gold : " + Gold + " G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();

            }

            public void OpenInventory()
            {
                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine();
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                //                [아이템 목록]
                //- 1[E]무쇠갑옷 | 방어력 + 5 | 무쇠로 만들어져 튼튼한 갑옷입니다.
                //- 2[E]스파르타의 창  | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.
                //-3 낡은 검         | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.


                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("2. 나가기");

            }

            public void OpenEquipments()
            {
                //장착
                Console.Clear();

            }

            public void OpenShop()
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine(Gold + " G");
                Console.WriteLine();
                Console.WriteLine("아이템 목록");

                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");

            }



        }

        public class GameManager
        {

            public void GameStart()
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해주세요.\n");
            }


            public int selectNum;
            private bool isInt;
            public int CheckSelect(int menu)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                while (true)
                {
                    string input = Console.ReadLine();
                    isInt = int.TryParse(input, out selectNum);

                    if ((!isInt) || (isInt && selectNum > menu) || (isInt && selectNum < 0))
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        Console.Write(">> ");
                    }
                    else
                        return selectNum;
                }


            }

            public void OpenTown()
            {
                //마을
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine();
            }


        }


        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            Player player = new Player();

            while (true)
            {
                gm.GameStart();
                player.NewPlayer();
                player.Name = Console.ReadLine();

                Console.WriteLine("\n입력하신 이름은 " + player.Name + " 입니다.\n");
                Console.WriteLine("1. 저장\n2. 취소\n");

                gm.CheckSelect(2);

                if (gm.selectNum != 1)
                {
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                    Console.WriteLine("반갑습니다. " + player.Name + " 님\n");
                    break;
                }
            }

            while (true)
            {
                gm.OpenTown();
                gm.CheckSelect(3);

                switch (gm.selectNum)
                {
                    case 1:  //상태보기
                        player.OpenStatus();
                        gm.CheckSelect(0);
                        break;

                    case 2:  //인벤토리
                        player.OpenInventory();
                        gm.CheckSelect(2);
                        if (gm.selectNum == 2)
                            break;
                        else
                        {
                            player.OpenEquipments();
                            break;
                        }
                       
                    case 3:  //상점
                        player.OpenShop();
                        gm.CheckSelect(2);
                        break;
                    case 4:  //던전입장
                        Console.WriteLine();
                        break;
                    case 5: //휴식하기
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
