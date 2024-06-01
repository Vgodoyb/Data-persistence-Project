using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class Basketball : MonoBehaviour
{
	public GameObject ball;
	public static bool gameOver;
		
	GameObject Score;
	GameObject timeObject;
	
	public static int score;
	float time;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI timeText;
	
	Transform spawnpoint;
	
	void Start()
	{
		Time.timeScale = 1.0f;
		score = 0;
		time = 60f;
		scoreText.text = "Score: " + score;
		timeText.text = "Time left: " + time;
	
		spawnpoint = GameObject.Find("spawnpoint").transform;
		gameOver = false;
	}
	
	void Update()
	{
		//if the game is playing, show time left and score
		if(!gameOver )
		{
			scoreText.text = "Score: " + score;
			timeText.text = "Time left: " + time.ToString("N0");
			time -= Time.deltaTime;
		}
	
		//if time is over, game is over
		if(time <= 0)
		{
			gameOver = true;
		}
	}
	//instantiate new basketball at the spawnposition
	public void spawnBall()
	{
		if(!gameOver)
		{
			Instantiate(ball, spawnpoint.position, spawnpoint.rotation);	
		}
	}
	
	public void startGame()
	{
		Score.SetActive(true);
		spawnBall();
	}
	
	//quit app
	public void quitGame()
	{
		Application.Quit();
	}
	
	//restart current scene
	public void restartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
