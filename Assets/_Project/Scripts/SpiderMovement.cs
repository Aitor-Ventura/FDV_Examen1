using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    public Vector3 beginningPoint;
    public Vector3 endPoint;
    public float _speed;

    private bool isEndPoint;
    
    private void OnEnable()
    {
        Script4.OnDuplicateSpeed += DuplicateSpeed;
    }

    private void OnDisable()
    {
        Script4.OnDuplicateSpeed -= DuplicateSpeed;
    }
    
    private void Update()
    {
        if (isEndPoint)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, beginningPoint, _speed * Time.deltaTime);
            if (transform.position == beginningPoint)
            {
                isEndPoint = false;
            }
        }
        else
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, endPoint, _speed * Time.deltaTime);
            if (transform.position == endPoint)
            {
                isEndPoint = true;
            }
        }
    }

    private void DuplicateSpeed()
    {
        if (_speed < 40f)
        {
            _speed *= 2;    
        }
    }
}
