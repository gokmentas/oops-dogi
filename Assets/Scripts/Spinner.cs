using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpin = 0f;
    [SerializeField] float ySpin = 0f;
    [SerializeField] float zSpin = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
    }
}
