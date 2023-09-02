using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private PlayerComponents components;
    private PlayerActions actions;
    private PlayerUtilities utilities;
    [SerializeField]
    private PlayerStats stats;

    public PlayerComponents Components {
        get
        {
            return components;
        } 
  }

    public PlayerStats Stats { get
        {
            return stats;
        }
        }

    private void Awake()
    {
        actions = new PlayerActions(this);
        utilities=new PlayerUtilities(this);
        stats.Speed = stats.WalkSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        utilities.HandleInput();
    }

    private void FixedUpdate()
    {
        actions.Move(transform);
    }
}
