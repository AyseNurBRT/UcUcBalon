using UnityEngine;
using UnityEngine.UI;

public class AnaOyun : MonoBehaviour
{
    public Sprite SesAcikS, SesKapaliS;
    public Image SesButonuI;
    private bool AcikMi = false, MenuB =true;
    public GameObject MenuGorunumu, OyunGorunumu, Bomba ,Para, Spawn;
    public static int score=0;
    public Text puanT;
    public float spawnaraligi = 2f;   
    public float xMin = -2f, xMax = 2f; 
    public float spawnY = 6f;
    public float hiz = 4f;
    private bool isPaused = false;
    void Start()
    {
            InvokeRepeating(nameof(SpawnObject), 0f, spawnaraligi);
    }
    private void SpawnObject()
    {   
        GameObject prefab = Random.value < 0.5f ? Para : Bomba;
        float randomX = Random.Range(xMin, xMax);

        Instantiate(prefab, new Vector3(randomX, spawnY, 0), Quaternion.identity);
        prefab.AddComponent<BalonÇarpma>();

        

    }


    public void AyarlarButonu()
    {
        if(AcikMi == true)
        {
            AcikMi=false;
            SesButonuI.gameObject.SetActive(false);
        }
        else
        {
            AcikMi=true;
            SesButonuI.gameObject.SetActive(true);
        }
    }
    public void SesAcmaKapamaButonu()
    {
        if(SesButonuI.sprite== SesAcikS)
        {
            SesButonuI.sprite = SesKapaliS;
        }
        else
        {
            SesButonuI.sprite= SesAcikS;
        }

    }

    public void BaslamaButonu()
    {
        MenuB = false;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f; // Duraklat veya devam ettir
        Debug.Log(isPaused ? "Oyun durdu." : "Oyun devam ediyor.");
    }

    void Update()
    {
        if (MenuB == true)
        {
            MenuGorunumu.SetActive(true);
            OyunGorunumu.SetActive(false);
        }
        else
        {
            puanT.text = score.ToString();
            MenuGorunumu.SetActive(false);
            OyunGorunumu.SetActive(true);
        }

        
    }
}
