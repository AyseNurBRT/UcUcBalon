using UnityEngine;
using UnityEngine.SceneManagement;

public class BalonÇarpma : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Balon"))
        {
            // Balon'a çarptığında objeyi yok et
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Bomba") && collision.CompareTag("Balon"))
        {
            Time.timeScale = 0f; 
            Debug.Log("Oyun durdu! Bomba balona çarptı.");
            SceneManager.LoadScene(1);
        }
        else if (CompareTag("Para"))
        {
            AnaOyun.score = AnaOyun.score + 10;
            Destroy(gameObject);
        }
        else if (CompareTag("Engel"))
        {

            Destroy(gameObject);
        }
    }
}

