 using System;
 using System.Collections.Generic;
 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Canvas start;
    public Button exit;

    public void keluar()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
