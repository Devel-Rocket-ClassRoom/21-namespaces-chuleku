using System;
MyGame.Characters.Player hero = new MyGame.Characters.Player();
MyGame.Characters.Enemy Goblin = new MyGame.Characters.Enemy();
Console.WriteLine("=== 캐릭터 시스템 ===");
hero.Attack();
Goblin.TakeDamage();
Console.WriteLine();
MyGame.Items.Weapon FireSword = new MyGame.Items.Weapon();
MyGame.Items.Potion HealingPotion = new MyGame.Items.Potion();
Console.WriteLine("=== 아이템 시스템 ===");
FireSword.GetDamage(50);
HealingPotion.Use();




namespace MyGame.Characters
{
    class Player
    {
        public string Name = "용사";

        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }
    class Enemy
    {
        public string Type = "고블린";
        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}
namespace MyGame.Items
{
    class Weapon
    {
        public string Name = "불꽃 검";
        public void GetDamage(int damage)
        {
            Console.WriteLine($"무기 {Name}의 공격력: {damage}");
        }
    }
    class Potion
    {
        public string Name = "체력 포션";

        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}
