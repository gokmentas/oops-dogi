using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Change the color of the object when it hits another object
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
        //Debug.Log("Object hit: " + gameObject.name);
    }
}
