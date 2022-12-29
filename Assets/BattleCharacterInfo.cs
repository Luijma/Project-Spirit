using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleCharacterInfo : MonoBehaviour
{
    #region UI Elements

    public TMP_Text characterName;
    public Image characterIcon;
    public TMP_Text healthPoints;

    #endregion UI Elements

    public Sprite[] characters;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void InitialSetup(int _charImage, string _charName)
    {
        if (MainManager.Instance != null)
        {
            Debug.Log("Attempting to perform initialSetup");
            
            characterIcon.sprite = characters[_charImage];
            characterName.text = _charName;

            if (MainManager.Instance.CurrentParty.Contains(_charName))
            {
                healthPoints.text = MainManager.Instance.PlayerParty[_charName].CurrentHP.ToString();

                Debug.Log("Successfully set healthPoints");
            }

            Debug.Log("Successfully performed initialSetup");
        }
        else
        {
            Debug.Log("Failed to set up name, using Defaults.");
            
            characterIcon.sprite = characters[0];
            characterName.text = "Linneus";

            healthPoints.text = "100";

            Debug.Log("Successfuly used Defaults for setup");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
