using UnityEngine;
using System.Collections;

public class MoveCat : MonoBehaviour 
{
    Rigidbody catBox;
    public float force = 10f;
    public float rotate = 10f;
    private void Start()
    {
        catBox = GetComponent<Rigidbody>();

        catBox.AddForce(Random.Range(1, force), Random.Range(1, force), Random.Range(1, force));
        catBox.AddTorque(Random.Range(1, rotate), Random.Range(1, rotate), Random.Range(1, rotate));
    }



}
