using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // public Vector3 position = new Vector3(0, 0, 40);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(Vector3.forward + position);
        transform.Rotate(Vector3.forward, 40);
    }
}
