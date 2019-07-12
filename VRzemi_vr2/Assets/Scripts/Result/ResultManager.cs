using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : ScenesManager {
    int a = 0;

    Controller controller = new Controller();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (controller.getCotrollerInput(Controller.INPUT_TYPE.TRIGGER_DOWN) == true) {

            NextScene();
        }
		
	}

    protected override void NextScene()
    {
        _scene_changer.SceneChange(StringConstantRegistry.SCENE_NAME.START);
    }


}
