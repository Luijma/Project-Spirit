using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // There will eventually be code here
        LoadDefaults();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadDefaults()
    {
        if (MainManager.Instance.CurrentParty == null)
        {
            MainManager.Instance.CurrentParty = new List<string>();

            MainManager.Instance.CurrentParty.Add("Linneus");
        }
        if (MainManager.Instance.PlayerParty == null)
        {
            MainManager.Instance.PlayerParty = new List<BattlePlayer>();

            MainManager.Instance.PlayerParty.Add(new BattlePlayer("", "Linneus", 100, 50, 100, 50));
            MainManager.Instance.PlayerParty.Add(new BattlePlayer("", "Ray", 200, 50, 250, 50));
            MainManager.Instance.PlayerParty.Add(new BattlePlayer("", "Pepper", 65, 100, 65, 100));
        }
    }
}
