using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MonsterFactory : MonoBehaviour
    {
        public GameObject PizzaPrefab;
        public GameObject BurgerPrefab;
        public GameObject SpaghettiPrefab;
        public GameObject GummyBearPrefab;

        private GameObject monsterToSpawn;

        public GameObject CreateMonster(string type)
        {
            monsterToSpawn = null;

            if (type.Equals("Pizza"))
            {
                monsterToSpawn = PizzaPrefab;
            }
            else if (type.Equals("Burger"))
            {
                monsterToSpawn = BurgerPrefab;
            }
            else if (type.Equals("Spaghetti"))
            {
                monsterToSpawn = SpaghettiPrefab;
            }
            else if (type.Equals("GummyBear"))
            {
            monsterToSpawn = GummyBearPrefab;
            }
            return monsterToSpawn;
        }

    }
