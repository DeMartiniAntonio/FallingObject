using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FallingObject[] prefab;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private GameObject mainMenuPanel;


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

        if (gameOverPanel.active == false && mainMenuPanel.active == false) {
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
