using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform v;
    public Vector3 offset = new Vector3(0, 2.0f, 3.0f);
    void Start()
    {

    }

    void Update()
    {
        transform.position = v.position + offset;
    }
}