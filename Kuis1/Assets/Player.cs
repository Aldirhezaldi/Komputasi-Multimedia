using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;

    public Text starText;

    private int totalStars = 0;

    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        UpdateStarText();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Ruby"))
        {
            totalStars++;
            UpdateStarText();
            playerInventoryDisplay.OnChangeStarTotal (totalStars);
            Destroy(hit.gameObject);
        }
    }

    private void UpdateStarText()
    {
        string starMessage = "Ruby = " + totalStars;
        starText.text = starMessage;
    }
}
