using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4_2 : MonoBehaviour
{
    public float _speed;
    public GameObject _egg;
    private bool enabled;
    
    
    private void OnEnable()
    {
        Script4.OnSamuraiClose += MoveToEgg;
    }

    private void OnDisable()
    {
        Script4.OnSamuraiClose -= MoveToEgg;
    }

    private void Update()
    {
        if (enabled)
        {
            transform.position = Vector3.MoveTowards(transform.position, _egg.transform.position, _speed * Time.deltaTime);
        }
    }

    private void MoveToEgg()
    {
        enabled = true;
    }
}
