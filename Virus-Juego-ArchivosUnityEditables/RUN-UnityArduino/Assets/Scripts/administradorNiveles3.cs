using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles3 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(3);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
