﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Cards Logic/Hand Card ")]
public class HandCard : GE_Logic
{
   public CardVariable currentCard;
    public State holdingCard;  //na jaki state ma sie zmienic karta którą wezmiemy
    public State highlightCard;  //na jaki state ma sie zmienic karta którą wezmiemy

    public override void OnClick(CardInstance inst)
    {
        //  Debug.Log("this card is in hand");
        currentCard.Set(inst);
        Settings.gameManager.SetState(holdingCard);

        GameObject GameCard = GameObject.FindGameObjectWithTag("Selected");
        CurrentSelected c = GameCard.GetComponent<CurrentSelected>();
        c.LoadCard();

        GameObject GameArea = GameObject.FindGameObjectWithTag("AreaParent");
        GameArea.SetActiveRecursively(true);

    }

    public override void OnHighlight(CardInstance inst)
    {
        if (currentCard.value !=null)
        {
            return;
        }
        currentCard.Set(inst);
        Settings.gameManager.SetState(highlightCard);

        
        GameObject GameCard = GameObject.FindGameObjectWithTag("Selected2");
        CurrentSelected2 c = GameCard.GetComponent<CurrentSelected2>();
        c.LoadCard();
    }
}