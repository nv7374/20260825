using NUnit.Framework;
using System.Collections;
using UnityEngine;

namespace BETA7
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] Enemy = new GameObject[5];
        public Vector3 spawnValue;
        public int enemyCount;
        public float spawnWait;
        public float startWait;

        public List<GameObject> listEnemys = new List<GameObject>();

        public enum GameStatus
        {
            none = 0,
            play = 11,
            gameOver,
            gameClear
        }
        public GameStatus gameStatus = GameStatus.none;

        void Start()
        {
            gameStatus = GameStatus.play;
            StartCoroutine
        }

        IEnumerator SpawnEnemy()
        {
            yield return new WaitForSeconds(startWait);
            while (true)
            {
                for(int i=0; i < enemyCount; i++)
                {
                    GameObject enemy =
                        Enemys[Random.Range(0, Enemys.Length)];
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    listEnemys.Add(Instantiate(enemy, spawnPosition, spawnRotation));
                    yield return new WaitForSeconds(spawnWait);
                }
            }
        }
    }
}
