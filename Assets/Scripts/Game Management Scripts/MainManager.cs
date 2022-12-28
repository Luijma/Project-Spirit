using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public List<BattlePlayer> PlayerParty;

    public List<string> CurrentParty;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadDefaults();
    }
    private void LoadDefaults()
    {
            Instance.CurrentParty = new List<string>();

            Instance.CurrentParty.Add("Linneus");

            Instance.PlayerParty = new List<BattlePlayer>();

            Instance.PlayerParty.Add(new BattlePlayer("", "Linneus", 100, 50, 100, 50));
            Instance.PlayerParty.Add(new BattlePlayer("", "Ray", 200, 50, 250, 50));
            Instance.PlayerParty.Add(new BattlePlayer("", "Pepper", 65, 100, 65, 100));
    }
}
