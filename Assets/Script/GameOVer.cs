using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour {

    float timer = 0;
	
	void Update () {
		timer += Time.deltaTime;
        if (timer > 2) {
            Data.score = 0;
            SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
        }
    }
}
