﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
