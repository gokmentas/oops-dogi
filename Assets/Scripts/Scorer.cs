using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    // score is incremented when the player bumps into a thing
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            //Debug.Log("Score: " + score);
        }
    }
}
