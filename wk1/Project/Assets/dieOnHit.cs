﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieOnHit : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
