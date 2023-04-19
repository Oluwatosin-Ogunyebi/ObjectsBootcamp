using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        // Association (know of)
        //Create a Player
        Player player = new Player();

        // Create 2 enemies
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();

        //Create weapons
        Weapon gun1 = new Weapon();
        Weapon gun2 = new Weapon();
        Weapon machineGun = new Weapon();


        //Enums
        EnemyType enemyType1 = EnemyType.Melee;
        enemy1.SetEnemyType(enemyType1);


        //Aggregation (has a)
        player.weapon = gun1;
        enemy1.weapon = gun2;
        enemy2.weapon = machineGun;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
