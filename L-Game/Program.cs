int heroHealt = 10;
int monsterHealth = 10;

Random random = new Random();

// hero first hit
do {
    int hitHero = random.Next(1,10);
    monsterHealth -= hitHero;
    Console.WriteLine($"Monster was damaged and lost {hitHero} health and now has {monsterHealth} health.");

    if(monsterHealth >= 0) {
        int hitMonster = random.Next(1,10);
        heroHealt -= hitMonster;
        Console.WriteLine($"Hero was damaged and lost {hitMonster} health and now has {heroHealt} health.");
    }
} while (heroHealt > 0 && monsterHealth > 0);

if(heroHealt <= 0 && monsterHealth <= 0) {
    Console.WriteLine("Remis");
} else if (heroHealt > monsterHealth) {
    Console.WriteLine("Hero win!");
} else if (monsterHealth > heroHealt) {
    Console.WriteLine("Monster win!");
}