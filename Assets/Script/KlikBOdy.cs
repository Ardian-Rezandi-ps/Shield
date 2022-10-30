using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KlikBOdy : MonoBehaviour
{
public Text Uitex;
public string deskripsiPenjelasan;
public Sprite ilustrasiSprite;

public string kata="kaki tersentuh";
    void OnMouseUp()
    {
        GameStatus.instance.uiBalonkata.SetActive(true);
        Uitex.text=kata;
        GameStatus.instance.deskripsiPenjelasantx.text= deskripsiPenjelasan;
        GameStatus.instance.ilustrasiImgPenjelasan.sprite=ilustrasiSprite;
    }
    
   
}
