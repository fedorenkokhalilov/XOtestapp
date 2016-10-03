using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {



	public Sprite[] PlayerList;

	private SpriteRenderer spriteRenderer;

	public enum StatusOfGame{
		Play,
		Wait,
		ChuseSide
	}

	public enum PlyerSide
	{
		None,
		X,
		O
	}
	public PlyerSide XO;
	public StatusOfGame stat;

	void Awake () {
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer> ();
		stat = StatusOfGame.ChuseSide;
	}

	public void XChose () {
	XO = PlyerSide.X;
	stat = StatusOfGame.Wait;
	}

	public void OChose () {
	XO = PlyerSide.O;
		stat = StatusOfGame.Wait;
	}

	public void NoneChose () {
		XO = PlyerSide.None;
		spriteRenderer.sprite = null;
		stat = StatusOfGame.ChuseSide;
	}

	private void Update()
	{
		if (XO == PlyerSide.X) {
			spriteRenderer.sprite = PlayerList [0];
		}
		if (XO == PlyerSide.O) {
			spriteRenderer.sprite = PlayerList [1];
		}
	}
}
