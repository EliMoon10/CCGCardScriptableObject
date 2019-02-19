using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//---------------------------------------------------------------------
// by 2018 Team UBG Programmer Moongijun
//---------------------------------------------------------------------
public class CardDisplay : MonoBehaviour
{

    public Card card; //카드 정보 (aa.Card 파일)

    [Tooltip ("카드의 이름")]
    public UILabel nameText; //이름 라벨
    [Tooltip("카드의 설명")]
    public UILabel descriptionText;

    [Tooltip("카드 캐릭터")]
    public GameObject artworkImage;
    [Tooltip("카드의 배경")]
    public GameObject CardBackGround;

    [Tooltip("카드의 마나소모")]
    public UILabel manaText;
    [Tooltip("카드의 공격력")]
    public UILabel attackText;
    [Tooltip("카드의 체력")]
    public UILabel healthText;

    // Use this for initialization
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        artworkImage.GetComponent<SpriteRenderer>().sprite = card.artwork;
        CardBackGround.GetComponent<UI2DSprite>().sprite2D = card.CardBackGround;
    


    }

}