using System;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public GameObject _triggerSpider;
    public float _distanceTreshold;
    private GameObject _player;
    
    public delegate void MoveSpiderToEgg();
    public delegate void DuplicateSpeed();

    public static event MoveSpiderToEgg OnSamuraiClose;
    public static event DuplicateSpeed OnDuplicateSpeed;
    
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Vector3.Distance(_player.transform.position, _triggerSpider.transform.position) < _distanceTreshold)
        {
            if (OnSamuraiClose != null)
            { 
                OnSamuraiClose();
            }

            if (OnDuplicateSpeed != null)
            {
                OnDuplicateSpeed();
            }
        }
    }
}
