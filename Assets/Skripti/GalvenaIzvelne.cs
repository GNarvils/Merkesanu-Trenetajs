using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalvenaIzvelne : MonoBehaviour {
	public MDropDown mizvelne;
	//Iet Uz Scene Pirmsspele
	public void Pirmsspele(){
			SceneManager.LoadScene ("Pirmsspele", LoadSceneMode.Single);
		}
		//Iet Uz Scene Iestatijumi
		public void Iestatijumi(){
			SceneManager.LoadScene ("Iestatijumi", LoadSceneMode.Single);
		}
	public void Izvelne(){
		SceneManager.LoadScene ("GalvenaIzvelne", LoadSceneMode.Single);
	}
	public void doExitGame() {
		Application.Quit();
	}
	public void Spele()
	{
		SceneManager.LoadScene("Spele", LoadSceneMode.Single);
	}
}
