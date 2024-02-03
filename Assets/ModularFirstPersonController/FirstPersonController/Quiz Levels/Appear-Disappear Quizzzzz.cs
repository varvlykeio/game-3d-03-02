using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageShow : MonoBehaviour {

	public bool isImgOn;
	public GameObject Content;

	void Start () {

		Content.SetActive(true) ;
		isImgOn = true;
	}

	void Update () {
	
		if (Input.GetKeyDown ("i")) {

			if (isImgOn == true) {

				Content.SetActive(false);
				isImgOn = false;
			}

			else {

				Content.SetActive(true);
				isImgOn = true;
			}
		}
	}
}
