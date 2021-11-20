using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class Highscore : MonoBehaviour
{

    public static Highscore Instance;

    public TMP_InputField nameAsset;
    public string nameOfPlayer;
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    [System.Serializable]
    public class Score
    {
       public string name;
       public int score;
    }

   

   


   public void AddName()
    {
        nameOfPlayer = nameAsset.text;
    }
}
