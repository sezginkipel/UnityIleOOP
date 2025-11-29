using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed = 150;

    [SerializeField] private int score;

    void Awake()
    {
        if (PlayerPrefs.HasKey("PlayerScore"))
        {
            score = PlayerPrefs.GetInt("PlayerScore");
        }
        else
        {
            score = 0;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    void Update()
    {
        Walk();



        // Sonra sil
        if (Input.GetKeyDown(KeyCode.P))
        {
            IncreaseScore();
        }else if (Input.GetKeyDown(KeyCode.K))
        {
            SaveScore();
        }else if (Input.GetKeyDown(KeyCode.L))
        {
            LoadScore();
        }


    }


    void Walk()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(horizontalInput * (speed * Time.deltaTime), 0, verticalInput * (speed * Time.deltaTime)), ForceMode.Impulse);
    }

    void IncreaseScore()
    {
        Debug.Log("Score artırıldı");
        score += 10;
    }

    void SaveScore()
    {
        Debug.Log("Score kaydedildi.");
        PlayerPrefs.SetInt("PlayerScore", score);
    }
    
    void LoadScore()
    {
        Debug.Log(PlayerPrefs.GetInt("PlayerScore"));
    }
}


