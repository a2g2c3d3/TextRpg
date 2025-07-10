namespace TextRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해주세요.\n\n");

                string playerName = Console.ReadLine();

                Console.WriteLine("\n입력하신 이름은 " + playerName + " 입니다.");

                Console.WriteLine("원하시는 항목을 선택해 주세요.");
                Console.WriteLine("1. 저장\n2.취소");

                string isYourName = Console.ReadLine();
                if(int.Parse(isYourName) == 1)
                {
                    dd
                }

                break;
            }


        }
    }
}
