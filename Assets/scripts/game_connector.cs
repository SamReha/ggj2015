using UnityEngine;
using System.Collections;

public class game_connector : MonoBehaviour {
	void Awake() {
		MasterServer.ClearHostList();
		MasterServer.RequestHostList("LarusTest");
	}
	void Update() {
		if (MasterServer.PollHostList().Length != 0) {
			HostData[] hostData = MasterServer.PollHostList();
			int i = 0;
			while (i < hostData.Length) {
				Debug.Log("Game name: " + hostData[i].gameName);
				i++;
			}
			MasterServer.ClearHostList();
		}
	}
}