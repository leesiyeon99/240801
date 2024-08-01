using static 딕셔너리_기본실습.Program;
using System.Xml.Linq;

namespace 딕셔너리_기본실습
/*과제 1. 몬스터 데이터베이스 구현하기
다음의 조건을 충족하는 프로그램을 구현하시오
구현 클래스
MonsterData
Monster
프로그램 시작 시 MonsterData는 몬스터 이름 기준의 string Key 값으로 딕셔너리에 저장한다.
최소 5종류 이상 저장한다.
Monster 클래스의 인스턴스 생성 시, 생성자를 사용해 딕셔너리에 저장된 MonsterData 
클래스의 정보를 불러와 인스턴스의 데이터를 초기화해야 한다.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonsterData monsterData = new MonsterData();
            monsterData.DisplayMonsters();
        }

        class Monster
        {
            public string name;
            public int hp;
            public int attack;

            public Monster(string name, int hp, int attack)
            {
                this.name = name;
                this.hp = hp;
                this.attack = attack;
            }
        }

        public class MonsterData
        {
            Dictionary<string, Monster> monsterdata = new Dictionary<string, Monster>();

            public MonsterData()
            {
                monsterdata.Add("오크", new Monster("오크", 100, 20));
                monsterdata.Add("슬라임", new Monster("슬라임", 80, 10));
                monsterdata.Add("마녀", new Monster("마녀", 120, 40));
                monsterdata.Add("드래곤", new Monster("드래곤", 300, 100));
                monsterdata.Add("좀비", new Monster("좀비", 70, 10));
            }

            public void DisplayMonsters()
            {
                Console.WriteLine("몬스터 목록: ");
                foreach (Monster monster in monsterdata.Values)
                {
                    Console.WriteLine($"이름: {monster.name}, HP: {monster.hp}, 공격력: {monster.attack}");
                }
            }
        }
    }
}
