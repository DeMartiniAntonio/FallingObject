using UnityEngine;

public class vjezbe1 : MonoBehaviour
{
    [SerializeField] private int score;
    public void Score(int amount) {
        score += amount;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("OnCollisionEnter");    
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("OnCollisionExit");

    }

    private void OnCollisionStay(Collision collision)
    {
       // Debug.Log("OnCollisionStay");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Sphere collider)) {
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
       // Debug.Log("OnTriggerExit");
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("OnTriggerStayr");
    }

}
