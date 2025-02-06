using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float maxDistanceDelta = 0.1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, maxDistanceDelta * Time.deltaTime);
    }
}
