using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Previous_scene : MonoBehaviour
{
    public void TransitionBack()
    {
        SceneManager.LoadScene(0);
    }
}
