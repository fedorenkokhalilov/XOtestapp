using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoardController : MonoBehaviour {


	private Image spriteRenderer;

	private PlayerController playerStatus;

	void Start () {
		spriteRenderer = this.gameObject.GetComponent<Image> ();
		playerStatus = FindObjectOfType<PlayerController> ();
	}
	
	public void ChangeToXorO () {
		if (playerStatus.XO == PlayerController.PlyerSide.X) {
			spriteRenderer.sprite = playerStatus.PlayerList [0];
			playerStatus.stat = PlayerController.StatusOfGame.Play;
		}
		if (playerStatus.XO == PlayerController.PlyerSide.O) {
			spriteRenderer.sprite = playerStatus.PlayerList [1];
			playerStatus.stat = PlayerController.StatusOfGame.Play;
		}

	}

	void Update(){
		if ((playerStatus.XO == PlayerController.PlyerSide.X||playerStatus.XO == PlayerController.PlyerSide.O) && playerStatus.stat== PlayerController.StatusOfGame.Wait) {
			spriteRenderer.sprite = playerStatus.PlayerList [2];
		}
	}
}
