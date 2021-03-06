﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    public Actions[] actions;

    public void Perform()
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Execute();
        }
    }
}