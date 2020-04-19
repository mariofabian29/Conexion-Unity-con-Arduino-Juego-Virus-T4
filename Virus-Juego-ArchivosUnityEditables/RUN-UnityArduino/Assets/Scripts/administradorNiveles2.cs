using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles2 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(2);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
