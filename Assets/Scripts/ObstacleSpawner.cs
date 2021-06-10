using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private const float V = 6f;

    //TODO Making List of Spawn Points
    public Transform[] spawnPoints;

    //TODO Getting prefab of Block
    public GameObject obstacleBlock;

    //TODO Increamenting position of Obstacle BLocks
    public Vector3 positionIncreament;

    //TODO Recording Time
    public float timeToSpawn = 2;
    public float timeBetweenWaves = 6;


    //? Inputting Spawn Point Position
    public Transform spawnPoint0;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;




    // Start is called before the first frame update
    void Update()
    {

        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();

            // Increamenting Time.
            timeToSpawn = Time.time + timeBetweenWaves;


            //! Increamenting Position Manually because I am Dumb.

            spawnPoint0.position = spawnPoint0.position + positionIncreament;
            spawnPoint1.position = spawnPoint1.position + positionIncreament;
            spawnPoint2.position = spawnPoint2.position + positionIncreament;
            spawnPoint3.position = spawnPoint3.position + positionIncreament;
            spawnPoint4.position = spawnPoint4.position + positionIncreament;

        }


    }

    void SpawnObstacles()
    {

        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex1 = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {

            //! Do something

            if (randomIndex != i)
            {
                // do something
                Instantiate(obstacleBlock, spawnPoints[i].position, Quaternion.identity);


                Debug.Log("Spawned Objects");
            }
        }
    }

}
