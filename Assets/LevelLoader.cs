using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static void LoadNextScene(string scene_name)
    {
        SceneManager.LoadSceneAsync(scene_name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
