using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles0 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(0);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
