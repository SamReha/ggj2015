using UnityEngine;
using System.Collections;

public class start_game : MonoBehaviour {

	// Use this for initialization
	void find_game () {
		// Connect to Master Server

		// Get queue of waiting players
		MasterServer.RequestHostList ("supercooppuzzlefantastic");
		// If queue.length == 0, enter host mode (start waiting)

		// Otherwise, attempt to connect to game in order of longest-waiting player

	}
}
