﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 1, -2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GameManager.I.gun.transform.position + offset;
    }
}
