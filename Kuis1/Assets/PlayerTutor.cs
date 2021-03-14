using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTutor : MonoBehaviour
{
    public Text starText;

    private int totalStars = 0;

    void Start()
    {
        UpdateStarText();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Ruby"))
        {
            totalStars++;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
    }

    private void UpdateStarText()
    {
        string starMessage = "Ruby = " + totalStars;
        starText.text = starMessage;
    }
}
