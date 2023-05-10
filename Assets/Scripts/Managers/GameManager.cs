using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{   
    [Header("Game Entities")]
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPositions;

    [Header("Game Variables")]
    [SerializeField] private float enemySpawnRate;

    public ScoreManager scoreManager;
    public PickupSpawner pickupSpawner;

    private Player player;
    private GameObject tempEnemy;
    private bool isEnemySpawning;
    private bool isGameRunning;

    private Weapon meleeWeapon = new Weapon("Melee", 1, 0);

    private static GameManager instance;

    public Action OnGameStart;
    public Action OnGameEnd;


    private void Awake()
    {
        SetSingleton();
    }

    void SetSingleton()
    {
        if (instance != null && instance != this)
            Destroy(this.gameObject);

        instance = this;
    }
    public bool IsGameRunning()
    {
        return isGameRunning;
    }
    public static GameManager GetInstance()
    {
        return instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        FindPlayer();

        isEnemySpawning = true;
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    CreateEnemy();
        //}
    }

    public void CreateEnemy()
    {
        tempEnemy = Instantiate(enemyPrefab);
        tempEnemy.transform.position = spawnPositions[UnityEngine.Random.Range(0, spawnPositions.Length)].position;
        tempEnemy.GetComponent<Enemy>().weapon = meleeWeapon;
        tempEnemy.GetComponent<MeleeEnemy>().SetMeleeEnemy(2, 0.25f);
    }

    IEnumerator EnemySpawner()
    {
        while (isEnemySpawning)
        {
            yield return new WaitForSeconds(1.0f/enemySpawnRate);
            CreateEnemy();
        }
    }

    public void NotifyDeath(Enemy enemy)
    {
        pickupSpawner.SpawnPickup(enemy.transform.position);
    }

    public void FindPlayer()
    {
        try
        {
            player = GameObject.FindWithTag("Player").GetComponent<Player>();
        }
        catch (NullReferenceException e)
        {

            Debug.Log("Player not found");
        }
    }

    public Player GetPlayer() { return player; }
}
