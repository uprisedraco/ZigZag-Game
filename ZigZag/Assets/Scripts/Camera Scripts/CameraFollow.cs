﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform ballTarget;

    private Vector3 oldPosition;

    void Start()
    {
        ballTarget = GameObject.FindGameObjectWithTag("Ball").transform;
        oldPosition = ballTarget.position;
    }

    void FixedUpdate()
    {
        if (ballTarget)
        {
            Vector3 newPosition = ballTarget.position;
            Vector3 delta = oldPosition - newPosition;
            delta.y = 0f;
            transform.position = transform.position - delta;
            oldPosition = newPosition;
        }
        
    }
}
