using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Hero> heroList = new List<Hero>();

    public List<Stealth> canStealth = new List<Stealth>();
    public List<Horse> hasHorse = new List<Horse>();


    // Start is called before the first frame update
    void Start()
    {

        heroList.Add(new Knight());
        heroList.Add(new Knight());
        heroList.Add(new Ninja());
        heroList.Add(new Ninja());
        heroList.Add(new Samurai());

        hasHorse.Add(new Knight());
        hasHorse.Add(new Knight());
        canStealth.Add(new Ninja());
        canStealth.Add(new Ninja());
        canStealth.Add(new Samurai());


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Hero hero in heroList)
            {
                if (hero == null) { break; }
                hero.AttackPower();
                hero.Move();


            }

            /*
            foreach( Knight knight in heroList)
            {
                    knight.GetArmour();
            }
            
            
            
            foreach (Ninja ninja in heroList)
            {
                if (ninja == null) { break; }
                ninja.Honor(); ;

            }

            
            foreach (Samurai hero in heroList)
            {
                if (hero == null) { break; }
                hero.Honor(); ;

            }
            */
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Horse horse in hasHorse)
            {
                if (horse == null) { break; }
                horse.HorseSpeed();
            }

            foreach (Stealth stealth in canStealth)
            {
                if (stealth == null) { break; }
                stealth.Stealth();
            }

        }
    }
}