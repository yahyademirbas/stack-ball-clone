using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    static int scoreHolder;
    public static Score instance;
    private void Awake()
    {
        instance  = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public TextMeshProUGUI scoreText;


    public void GainScore()
    {
        scoreHolder++;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(scoreHolder);
        scoreText.text = scoreHolder.ToString();
    }
}
