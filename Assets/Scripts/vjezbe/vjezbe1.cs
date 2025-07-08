using UnityEngine;

public class vjezbe1 : MonoBehaviour
{
    [SerializeField] private int score;
    public void Score(int amount)
    {
        score += amount;
    }

}
