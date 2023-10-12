using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScreenManager : MonoBehaviour
{
    // Display text
    public List<CharacterBase> characterbase;
    public TMP_Text name;
    public TMP_Text description;
    public TMP_Text hp;
    public TMP_Text atk;
    public TMP_Text def;

    public GameObject[] skins;
    private int selectedCharacter;
   
    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject player in skins)
            player.SetActive(false);
        skins[selectedCharacter].SetActive(true);

        name.text = characterbase[selectedCharacter].Name;
        description.text = characterbase[selectedCharacter].Description;
        hp.text = characterbase[selectedCharacter].MaxHP.ToString();
        atk.text = characterbase[selectedCharacter].Attack.ToString();
        def.text = characterbase[selectedCharacter].Deffense.ToString();

    }

    public void NextOption()
    {
        skins[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter == skins.Length)
        {
            selectedCharacter = 0;
        }
        skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);

        name.text = characterbase[selectedCharacter].Name;
        description.text = characterbase[selectedCharacter].Description;
        hp.text = characterbase[selectedCharacter].MaxHP.ToString();
        atk.text = characterbase[selectedCharacter].Attack.ToString();
        def.text = characterbase[selectedCharacter].Deffense.ToString();

        
    }

    public void BackOption()
    {
        skins[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter <0)
        {
            selectedCharacter = skins.Length - 1;
        }
        skins[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);

        name.text = characterbase[selectedCharacter].Name;
        description.text = characterbase[selectedCharacter].Description;
        hp.text = characterbase[selectedCharacter].MaxHP.ToString();
        atk.text = characterbase[selectedCharacter].Attack.ToString();
        def.text = characterbase[selectedCharacter].Deffense.ToString();
        //anim.SetInteger("selected", selectedCharacter);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
