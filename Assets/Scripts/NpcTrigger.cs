using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTrigger : MonoBehaviour
{
    public static NpcTrigger current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onNpcTriggerEnter;

    public void NpcTriggerEnter(int id)
    {
        if (onNpcTriggerEnter != null)
        {
            onNpcTriggerEnter(id);
        }
    }
    public event Action<int> onNpcTriggerExit;
    public void NpcTriggerExit(int id)
    {
        if (onNpcTriggerExit != null)
        {
            onNpcTriggerExit(id);
        }
    }

}
