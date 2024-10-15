Random points = new Random();
int attack;

int hero=10,monster=10;
int turn=0; //if even-hero, off-monster

Console.WriteLine("Both hero and monster initially have 10 health points. Hero attacks first!");

while((hero>0)&&(monster>0)) {
    Console.WriteLine($"\nHealth points left: Hero = {hero} , Monster = {monster}");
    attack=points.Next(1,4);
     if(turn%2==0)    
     {
         Console.WriteLine($"Hero attacks monster with {attack} points");
         monster-=attack;         
     }
     else   
     {
         Console.WriteLine($"Monster attacks hero with {attack} points");
         hero-=attack;         
     } 

    turn++;
}

if(turn%2!=0) 
    Console.WriteLine("\nMonster is dead. Hero wins!");
else
    Console.WriteLine("\nHero is dead. Monster wins!");
