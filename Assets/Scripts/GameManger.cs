using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject []playerPrefabs;

    public static Vector2 lastCheckPointPos = new Vector2(-3, 0);
    int characterIndex;

    private void Start()
    {
       characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        
        //player.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }
}
