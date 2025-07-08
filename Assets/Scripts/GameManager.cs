using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab;
    

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        RandomSpawnPoint();
        yield return Start();
    }

    private float RandomDistanceX()
    {
        return Random.Range(-0.7f, 0.55f);
    }

    private void RandomSpawnPoint() {
        Instantiate(prefab[RandomIndex()], new Vector3(RandomDistanceX(), 8, 0), Quaternion.identity);
    }

    private int RandomIndex()
    {
        return Random.Range(0, prefab.Length);
    }
}
