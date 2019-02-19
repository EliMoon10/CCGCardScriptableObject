using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------------------------------------
// by 2018 Team UBG Programmer Moongijun
//---------------------------------------------------------------------
public class CardInstantiate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateCard(Card CardValue, GameObject CardBody, GameObject PlayerHand)
    {
        CardBody.GetComponent<CardDisplay>().card = CardValue; //카드 디스플레이 호출
        NGUITools.AddChild(PlayerHand, CardBody); //NGUI 버전

        //Instantiate(CardBody, transform.position, transform.rotation).transform.parent = PlayerHand.transform; //UGUI 버전

    }
}
