using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats 
{
    [SerializeField]
    private float walkSpeed;
    private float runSpeed;

    public Vector2 Direction
    {
        get;set;
    }

    public float Speed
    {
        get;
        set;
    }
    public float WalkSpeed
    {
        get
        {
            return WalkSpeed;
        }
    }
}
