using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Janggi_Type
{
    JA,
    HOO,
    JANG,
    SANG,
    WANG,
    JANGGI_TYPE_CNT
}

public abstract class Janggi : MonoBehaviour
{
    [SerializeField] private Janggi_Type janggiType;

    private void Start()
    {
        
    }

    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        switch (janggiType)
        {
            case Janggi_Type.JA:
                break;
                case Jan
        }
    }
}
