﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Action/MouseHoldWithCard")]
public class MouseHoldWithCard : Actions
{
    public State playerControlState;
    public override void Execute(float d)
    {
        bool mouseIsDown = Input.GetMouseButton(0);
        if (!mouseIsDown)
        {
            List<RaycastResult> results = Settings.GetUIObjects();
            foreach (RaycastResult r in results)
            {
                //check for dropable area
            }
            Settings.gameManager.SetState(playerControlState);

            GameObject GameCard = GameObject.FindGameObjectWithTag("Selected");
            CurrentSelected c = GameCard.GetComponent<CurrentSelected>();
            c.CloseCard();
            return;
        }
    }
}