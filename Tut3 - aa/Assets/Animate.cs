using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animate : MonoBehaviour
{
    public Animator animator;
    public void AnimateEndGame()
    {
        animator.SetTrigger("EndGame");

    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
