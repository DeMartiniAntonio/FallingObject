using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sphere[] prefab;
    //[SerializeField] private Transform[] spawnRange;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        RandomSpawnPoint();
        yield return Start();
    }

    private float RandomDistanceX()
    {
        return Random.Range(-7,8);
    }

    private void RandomSpawnPoint() {
        Instantiate(prefab[RandomIndex()], new Vector3(RandomDistanceX(), 8, 0), Quaternion.identity);
    }

    private int RandomIndex()
    {
        return Random.Range(0, prefab.Length);
    }
}
