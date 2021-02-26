using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text starText;
    public void OnChangeCarryingStar(bool carryingStar)
    {
        string starMessage = "Tidak  Bawa  Ruby  :-(";
        if (carryingStar) starMessage = "Bawa  Ruby  :-)"; starText.text = starMessage;
    }
}