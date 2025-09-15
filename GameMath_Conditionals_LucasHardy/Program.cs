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

        static int playerHealth = 100;

        static string healthStatus = "";

        static WeaponType weapon = WeaponType.fist;


        enum WeaponType
        {
            fist,
            slingshot,
            axe,
            pistol,
            shotgun,
            assaultRifle
        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", playerHealth, weapon, healthStatus);
        }


        static void changeWeapon(WeaponType newWeapon)
        {
            //if weaponEquiped = 0;
            //dealDamage = 5;
            weapon = newWeapon;



        }
        static void dealDamage(int WeaponType)
        {
            enemyHealth = enemyHealth - WeaponType;
        }

        static void takeDamage(int damageTaken)
        {
            playerHealth = playerHealth - damageTaken;
        }
        static void Main(string[] args)
        {

            changeWeapon(WeaponType.fist);
            changeWeapon(WeaponType.slingshot);
            changeWeapon(WeaponType.axe);
            changeWeapon(WeaponType.pistol);
            changeWeapon(WeaponType.shotgun);
            changeWeapon(WeaponType.assaultRifle);

        }

        static void healthStatus()
        { 
            if (health == 0..10)
            {
                Console.Write("Health is Critically Low")
            }

            else if(health == 10..50)
            {
                Console.Write("Health is Very Low")
            }

            else if(health == 50..75)
            Console.Write("Health is Fair)

            else if health == 75..99
            Console.Write("Health is Good")

            else health == 100
            Console.Write("Health is Perfect")
       }     
            


    }
}
