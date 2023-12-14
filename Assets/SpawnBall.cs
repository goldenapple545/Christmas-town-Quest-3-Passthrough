using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject prefab;
    public float spawnSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            GameObject spawnedObject = Instantiate(prefab, transform.position, Quaternion.identity);
            Rigidbody spawnedObjectRB = spawnedObject.GetComponent<Rigidbody>();
            spawnedObjectRB.velocity = transform.forward * spawnSpeed;
        }
    }
}
