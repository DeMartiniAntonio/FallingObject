using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Sfera je usla iz kocke");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sfera je izasla iz kocke");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Sfera je u kocki");
    }
}
