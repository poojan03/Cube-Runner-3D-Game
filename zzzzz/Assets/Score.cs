using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform cube;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
       scoreText.text = cube.position.z.ToString("0"); 
    }
}
