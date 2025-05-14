using UnityEngine;

public class Answer : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Wrong"))
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                Destroy(player);
                Debug.Log("Game Over!");
                QuitGame();
            }
        }
        else if (gameObject.CompareTag("True"))
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
            if (enemy != null)
            {
                Destroy(enemy);
                Debug.Log("You Win!");
                QuitGame();
            }
        }
    }

    private void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}