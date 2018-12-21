// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.Linq;

// public class PlayerScore {
// 	public string playerName;
// 	public int playerScore;

// 	public PlayerScore (string playerName, int playerScore) {
// 		this.playerName = playerName;
// 		this.playerScore = playerScore;
// 	}

// 	public string GetFormat() {
// 		return playerName + "-S-" + playerScore;
// 	}
// }
// public class scoreboard : MonoBehaviour {

// public int scoreCount = 10;
// static scoreboard scoreBoard;
// static string separator = "-S-";


// 	// Use this for initialization
// 	void Start () {
// 		scoreBoard = this;
// 	}

// 	void Update() {

// 		if(Input.GetKeyDown(KeyCode.S)) {
// 			print("testS");
// 			SaveScore("test", 100);
// 			SaveScore("test1", 50);
// 		}
// 		if(Input.GetKeyDown(KeyCode.P)){
// 			print("testP");
// 			List<PlayerScore> playerScores = GetScores();
// 			foreach (PlayerScore p in playerScores){
// 				print(p.playerName + "    " + p.playerScore);
// 			}
// 		}
// 	}

// 	void SaveScore(string name, int score) {
// 		List<PlayerScore> playerScores = new List<PlayerScore>();
// 		for (int i = 0; i < scoreBoard.scoreCount; i++) {
// 			if(PlayerPrefs.HasKey("Score" + i)) {
// 				string[] scoreFormat = PlayerPrefs.GetString("Score" + i).Split(new string[] {separator}, System.StringSplitOptions.RemoveEmptyEntries);
// 				playerScores.Add(new PlayerScore(scoreFormat[0], int.Parse(scoreFormat[1])));
// 			} else {
// 				break;
// 			}
// 		}

// 		if (playerScores.Count < 1) {
// 			PlayerPrefs.SetString("Score0", name + separator + score);
// 			return;
// 		}

// 		playerScores.Add(new PlayerScore(name, score));
// 		playerScores = playerScores.OrderByDescending(o => o.playerScore).ToList();

// 		for (int i = 0; i < scoreBoard.scoreCount; i++) {
// 			if (i >= playerScores.Count) { break; }
// 			PlayerPrefs.SetString("Score" + i, playerScores[i].GetFormat());
// 		}
// 	}

// 	public List<PlayerScore> GetScores() {
// 		List<PlayerScore> playerScores = new List<PlayerScore>();
// 		for (int i = 0; i < scoreBoard.scoreCount; i++) {
// 			if (PlayerPrefs.HasKey("Score" + i)) {
// 				string[] scoreFormat = PlayerPrefs.GetString("Score" + i).Split(new string[] {separator}, System.StringSplitOptions.RemoveEmptyEntries);
// 				playerScores.Add(new PlayerScore(scoreFormat[0], int.Parse(scoreFormat[1])));
// 			} else {
// 				break;
// 			}
// 		}
// 		return playerScores;
// 	}
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {
	public static int updatedScore;
	Text score;

	void Start() {
		score = GetComponent<Text>();
		score.text = "Score: 0";
	}
	void Update() {
		score.text = "Score: " + updatedScore;
	}
}