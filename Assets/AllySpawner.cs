using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawner : MonoBehaviour
{
    #region Prefab Variables

    public List<PlayerBattlePawn> battlePawns = new List<PlayerBattlePawn>();
    public PlayerBattlePawn linneusPrefab;
    public PlayerBattlePawn rayPrefab;

    #endregion Prefab Variables

    #region Spawns
    public GameObject[] spawnLocations;
    #endregion Spawns

    // Start is called before the first frame update
    void Start()
    {
        SpawnPawns();
    }

    private void SpawnPawns()
    {
        foreach (string bp in MainManager.Instance.CurrentParty)
        {
            Debug.Log("Spawning Pawn for " + bp);

            switch (bp)
            {
                case "Linneus":
                    createNewPawn(linneusPrefab, spawnLocations[0]);
                    Debug.Log("Spawned Pawn for " + bp);
                    break;
                case "Ray":
                    createNewPawn(rayPrefab, spawnLocations[1]);
                    Debug.Log("Spawned Pawn for " + bp);
                    break;
                case "Pepper":
                    Debug.Log("No Prefab for Pepper exists yet");
                    break;
                default:
                    Debug.Log("Failed to spawn character: Name invalid");
                    break;
            }
        }
    }

    public PlayerBattlePawn createNewPawn(PlayerBattlePawn prefab, GameObject spawnLocation)
    {
        PlayerBattlePawn newPawn = Instantiate(prefab, spawnLocation.transform);
        newPawn.InitialSetup();
        battlePawns.Add(newPawn);
        return newPawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
