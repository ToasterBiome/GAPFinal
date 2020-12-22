using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x + rotationSpeed.x * Time.deltaTime, transform.rotation.eulerAngles.y + rotationSpeed.y * Time.deltaTime, transform.rotation.eulerAngles.z + rotationSpeed.z * Time.deltaTime);

    }
}
