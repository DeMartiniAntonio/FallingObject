using System.Collections;
using System.Threading;
using UnityEngine;

public class Zadatak1 : MonoBehaviour
{

    private float timer = 1;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (other.TryGetComponent(out HealthZadatak3 player))
            {
                timer -= Time.deltaTime;

                if (timer <= 0)
                {
                    player.playerHealt++;
                    timer = 1;
                }
            }
        }    
    }

}
