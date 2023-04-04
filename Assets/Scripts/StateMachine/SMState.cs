using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MemSM))]
public class SMState : State
{
    protected MemSM StateMachine { get; private set; }

    void Awake()
    {
        StateMachine = GetComponent<MemSM>();
    }
}