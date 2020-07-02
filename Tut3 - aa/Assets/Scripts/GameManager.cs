using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rotator rotator;
    public PinSpawn spawner;
    public Animator animator;

    public void EndGame()
    {
        rotator.enabled = false;
        spawner.enabled = false;

        FindObjectOfType<Animate>().AnimateEndGame();
        //animator.SetTrigger("EndGame");

        //RestartScene();
    }

    
}
