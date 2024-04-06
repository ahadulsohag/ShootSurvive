using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text Text;
    private float ScorePlus = 100;
    void Update()
    {
        Text.text = Time.time.ToString("0");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Text.text = Time.time + ScorePlus.ToString("0");
        }
    }
}