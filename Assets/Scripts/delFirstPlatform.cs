﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delFirstPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            Destroy(transform.parent.gameObject);
        }
            
    }
}
