﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenByHand : InterObjjj
{
    public GameObject obj;
    public Camera camera;
    public Animator animator;

    public Vector3 force;

    public string objName;
    float minDist = 6f;
    public bool pointingAtThis;

    // Use this for initialization
    void Start()
    {
        if (animator != null)
            animator.enabled = false;
        pointingAtThis = false;
    }

    public override void Activate()
    {
        obj.tag = "Untagged";
        if (animator != null)
        {
            print("Enabling");
            animator.enabled = true;
        }
        else obj.GetComponent<Rigidbody>().velocity = force;
    }
}
