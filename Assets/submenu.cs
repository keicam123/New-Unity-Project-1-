using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class submenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("0", LoadSceneMode.Single);
    }
}
