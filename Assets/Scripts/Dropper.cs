using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    // store the MeshRenderer and Rigidbody components
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the MeshRenderer and Rigidbody components
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
