using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_scene : MonoBehaviour
{
    public void TransitionForward()
    {
        SceneManager.LoadScene(1);
    }
}
