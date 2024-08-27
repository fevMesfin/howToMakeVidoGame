using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
   public Transform player;
   public TMP_Text scoreText;
    
    void Update()
    {
       scoreText.text = player.position.z.ToString("0");
    }
}
