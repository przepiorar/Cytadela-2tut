﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSelected2 : MonoBehaviour
{

    public CardVariable currentCard;
    public CardVizu cardViz;

    Transform mTransform;

    public void LoadCard()
    {
        if (currentCard.value == null)
        {
            return;
        }

       // currentCard.value.gameObject.SetActive(false);
        cardViz.LoadCard(currentCard.value.viz.card);
        cardViz.gameObject.SetActive(true);
        //if (Input.mousePosition.y < -300)
        //    mTransform.position = Input.mousePosition + new Vector3(0, 450, 0);
        //else
            mTransform.position = Input.mousePosition + new Vector3(0, 150, 0);  //zrobic sztuczke z sign
        Vector3 s = Vector3.one * 2;
        cardViz.gameObject.transform.localScale =s;
    }

    public void CloseCard()
    {
        cardViz.gameObject.SetActive(false);
    }
    private void Start()
    {
        mTransform = this.transform;
        CloseCard(); //bo na początku nie mamy wybranej zadnej karty
    }
}