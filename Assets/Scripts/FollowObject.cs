using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    
    void Update()
    {
        this.transform.position = objectToFollow.position;
        this.transform.rotation = objectToFollow.rotation;
    }
}
