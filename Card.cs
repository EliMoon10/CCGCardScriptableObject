using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------------------------------------
// by 2018 Team UBG Programmer Moongijun
//---------------------------------------------------------------------

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{

    public new string name; //카드이름
    public string description; //카드 설명

    public Sprite artwork; //카드 캐릭터 그림
    public Sprite CardBackGround; //카드 배경

    public int manaCost; //마나
    public int attack; //공격력
    public int health; //체력

    public int Pieces;

    public void Print() //사용되지 않음, 태스트용
    {
        Debug.Log(name + ": " + description + " The card costs: " + manaCost);
    }

}