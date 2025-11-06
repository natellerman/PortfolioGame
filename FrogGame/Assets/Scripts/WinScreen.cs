using UnityEngine;
using TMPro;

public class WinScreen : MonoBehaviour
{
    public TextMeshProUGUI collectiblesText;
    public int collectiblesCount = 0;

    void Start()
    {
        if (CollectiblesManager.Instance != null)
        {
            collectiblesText.text = "Fruit Collected: " + CollectiblesManager.Instance.collectiblesCount;
        }
        else
        {
            collectiblesText.text = "Fruit Collected: 0";
        }
    }

    // Update is called once per frame
    public void ResetCollectibles()
    {
        collectiblesCount = 0;
    }
}
