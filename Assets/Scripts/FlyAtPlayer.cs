using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float maxDistanceDelta = 0.1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    // Awake is called once before the first execution of Update
    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    // Moves the object towards the player
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, maxDistanceDelta * Time.deltaTime);
    }

    // Destroys the object when it reaches the player
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
