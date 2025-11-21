using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    bool sceneHasStopped = false;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       if (gameHasEnded && !sceneHasStopped)
        {
            StartCoroutine(RestartScene());
            return;
        }
        
    }

    public void GameOver()
    {
        gameHasEnded = true;
    }

    IEnumerator RestartScene()
    {
        sceneHasStopped = true;
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
