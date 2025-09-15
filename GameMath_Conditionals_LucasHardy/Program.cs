using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath_Conditionals_LucasHardy
{

    internal class Program
    {
        static int enemyHealth = 100;
        
        static int health = 100;
        static string healthName = "Health:";
        static string healthStatus = HealthStatus(health);
        static string healthStatusName = "Health Status:";
        static WeaponType weapon = WeaponType.Fist;
        static string weaponName = "Weapon:";


        enum WeaponType
        {
            Fist,
            Slingshot,
            Axe,
            Pistol,
            Shotgun,
            AssaultRifle
        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,0}{1,10}{2,20}", healthName, weaponName, healthStatusName);
            Console.WriteLine("{0,0}{1,10}{2,20}", health, weapon, HealthStatus(health));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();


        }

        static int heal(int healthRecovered)
        {
            health = health + healthRecovered;
            return healthRecovered;
        }
        static void changeWeapon(WeaponType newWeapon)
        {
            weapon = newWeapon;



        }
        static void dealDamage(int WeaponType)
        {
            enemyHealth = enemyHealth - WeaponType;
        }

       


        
        static int takeDamage(int damageTaken)
        {
            health = health - damageTaken;
            return damageTaken;
        }
        static void Main(string[] args)
        {


            changeWeapon(WeaponType.Fist);
            ShowHUD();

            

            Console.WriteLine("You start your adventure off empty handed, Be careful!");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You notice a green silouette approaching...");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Goblin punches you in the face and runs off dealing {takeDamage(27)} damage");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
           

            Console.WriteLine("The goblin ran away");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            ShowHUD();

            Console.WriteLine("You reach into your pocket for a health potion you stored earlier.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"It heals {heal(27)} health");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            ShowHUD();

            Console.WriteLine("You swap to your Slingshot incase something else comes up on you.");
            changeWeapon(WeaponType.Slingshot);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            ShowHUD();




            changeWeapon(WeaponType.Slingshot);
            changeWeapon(WeaponType.Axe);
            changeWeapon(WeaponType.Pistol);
            changeWeapon(WeaponType.Shotgun);
            changeWeapon(WeaponType.AssaultRifle);

            
        }

        static string HealthStatus(int health)
        { 
            if (health >= 100)
            {
                return "Health is Perfect";
            }
            
              else if (health <= 99)
            {
                return "Health is Good";
            }

            else if (health <= 75)
            {
                return "Health is Fair";
            }

            else if (health <= 50)
            {
                return "Health is Very Low";
            }

            if (health <= 10)
            {
                return "Health is Critically Low";
            }

            return "Unknown Health Statue";
       }     
          


    }
}
