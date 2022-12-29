using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Dictionary<string, BattlePlayer> PlayerParty;

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
        Instance.CurrentParty.Add("Ray");

        Instance.PlayerParty = new Dictionary<string, BattlePlayer>();

        Instance.PlayerParty.Add("Linneus", new BattlePlayer("", "Linneus", 100, 50, 100, 50));
        Instance.PlayerParty.Add("Ray", new BattlePlayer("", "Ray", 200, 50, 250, 50));
        Instance.PlayerParty.Add("Pepper", new BattlePlayer("", "Pepper", 65, 100, 65, 100));
    }
}
