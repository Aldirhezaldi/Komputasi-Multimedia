using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text starText;
    private bool carryingStar = false; void Start()
    {
        UpdateStarText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Ruby"))
        {
            carryingStar = true; UpdateStarText(); Destroy(hit.gameObject);
        }
    }
    private void UpdateStarText()
    {
        string starMessage = "Tidak  Bawa  Ruby  :-(";
        if (carryingStar) starMessage = "Bawa  Ruby  :-)"; starText.text = starMessage;
    }
}