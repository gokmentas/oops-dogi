using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    // score is incremented when the player bumps into a thing
    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("You've bumped into a thing this many times: " + score);
    }
}
