using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Change the color of the object when it hits another object
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        //Debug.Log("Object hit: " + gameObject.name);
    }
}
