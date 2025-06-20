using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            Time.timeScale = 0;
            Debug.Log("You lost the game");
        }
    }
}
