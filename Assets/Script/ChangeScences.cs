using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScences : MonoBehaviour
{
    public void changeSence(string scenceName)
    {
       SceneManager.LoadScene(scenceName);
    }
}
