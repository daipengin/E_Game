using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Game_Manager : MonoBehaviour
{
    [SerializeField]
    GameObject Point_Text_obj;

    [SerializeField]
    GameObject GameOVER_Text;

    Text Point_Text;
    public int Point;
    public int Max_size = 1;


    // Start is called before the first frame update
    void Start()
    {
        Point = 0;
        Point_Text = Point_Text_obj.GetComponent<Text>();
        GameOVER_Text.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Point_Text.text ="Point:"+ Point.ToString();
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReLodeScene();
        }
    }


    public void Game_Over()
    {
        GameOVER_Text.SetActive(true);
        Time.timeScale = 0;
    }

    void ReLodeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
