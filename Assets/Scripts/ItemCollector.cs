using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coints = 0;
    [SerializeField] TextMeshProUGUI coinsText;
    private void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coints++;
            coinsText.text = "Coints: " + coints;
        }
    }
}
