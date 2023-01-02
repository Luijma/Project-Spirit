using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMembersBox : MonoBehaviour
{
    // Start is called before the first frame update

    #region Icon Variables
    public List<BattleCharacterInfo> battleCharacterInfoList = new List<BattleCharacterInfo>();
    public BattleCharacterInfo BattleCharacterInfoPrefab;
    #endregion Icon Variables

    #region Panel Settings

    #endregion Panel Settings

    private void PopulateCharacterInfoBox()
    {
        if (MainManager.Instance != null)
        {
            foreach(string bp in MainManager.Instance.CurrentParty)
            {
                if (MainManager.Instance.PlayerParty.ContainsKey(bp))
                {
                    Debug.Log("Trying to populate info for " + bp);
                    BattleCharacterInfo infoIcon = Instantiate(BattleCharacterInfoPrefab, gameObject.transform);
                    infoIcon.InitialSetup(BattlePlayer.PlayerCharIconNums[bp], bp);
                    battleCharacterInfoList.Add(infoIcon);
                }
            }
        }
    }


    void Start()
    {
        PopulateCharacterInfoBox();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
