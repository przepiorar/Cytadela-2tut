﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards Logic/Down Card ")]
public class DownCard: CardLogic
{
    public override void OnClick(CardInstance inst)
    {
        if (Library.gameManager.currentPlayer.currentHero.value ==8 && Library.gameManager.destroyBuilding)
        {
            if (Library.gameManager.currentPlayer.currentGold >= inst.viz.card.value-1 && inst.player.currentHero.value !=5 && inst.viz.card.sprite.name != "fort" &&
                inst.player.cardsDown.Count < Library.gameManager.cardsToEndGame)
            {
                inst.player.cardsDown.Remove(inst);
                inst.viz.gameObject.SetActive(false);

                Library.gameManager.actionButton.gameObject.SetActive(false);
                Library.gameManager.currentPlayer.currentGold -= (inst.viz.card.value - 1);
                Library.gameManager.currentPlayer.UpdateGold();
                Library.gameManager.destroyBuilding = false;
                Library.gameManager.textForGeneral.gameObject.SetActive(false);
            }
            else
            {
                Library.gameManager.ActionButton();
            }
        }
    }

    public override void OnHighlight(CardInstance inst)
    {
        Library.gameManager.cardVariable= inst;
        GameObject GameCard = GameObject.FindGameObjectWithTag("Highlighted");
        CurrentHighlighted c = GameCard.GetComponent<CurrentHighlighted>();
        c.LoadCard();
    }
}

