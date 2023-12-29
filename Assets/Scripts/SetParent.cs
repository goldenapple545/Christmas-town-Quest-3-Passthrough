using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour
{
    [SerializeField] private Transform parent;

    public void ParentSet()
    {
        this.transform.parent = parent;
    }
}
