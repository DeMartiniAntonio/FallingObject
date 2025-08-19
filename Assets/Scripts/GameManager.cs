using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FallingObject[] prefab;
    [SerializeField] private GameObject gameOverPanel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(Random.Range(0.2f,1.5f));
        RandomSpawnPoint();
        yield return Start();
    }

    private float RandomDistanceX()
    {
        return Random.Range(-0.7f, 0.55f);
    }

    private void RandomSpawnPoint() {

        if (gameOverPanel.active == false) {
            FallingObject gameObject = Instantiate(prefab[RandomIndex()], new Vector3(RandomDistanceX(), 0.95f, 0), Quaternion.identity);
            if (gameObject.name == "apple(Clone)")
            {
                gameObject.transform.Rotate(90, 0, 0);
            }
        }
    }

    private int RandomIndex()
    {
        return Random.Range(0, prefab.Length);
    }

}
