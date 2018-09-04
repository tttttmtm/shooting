using UnityEngine;
using System.Collections;
using Windows.Kinect;
using System.Collections.Generic;
using System.Linq;


public class KinectMotion : MonoBehaviour
{

    //public s_shooting shooting;

    public BodySourceManager _BodyManager;

    HandState beforeHandRightState;
    bool isClosed = true;
    bool wasClosed = true;
    const int judgeNotClosed = 3;
    const int judgeClosed = 1;
    int notClosedCount = 0;
    int closedCount = 0;


    HandState[] pastHandRightState = new HandState[10];
    public GameObject testObject;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (_BodyManager == null)
        {
            Debug.Log("_BodyManager == null");
            return;
        }

        // Bodyデータを取得する
        var data = _BodyManager.GetData();
        if (data == null)
        {
            return;
        }

        // 最初に追跡している人を取得する
        var body = data.FirstOrDefault(b => b.IsTracked);
        if (body == null)
        {
            return;
        }

        // 床の傾きを取得する
        var floorPlane = _BodyManager.FloorClipPlane;
        var comp = Quaternion.FromToRotation(
            new Vector3(floorPlane.X, floorPlane.Y, floorPlane.Z), Vector3.up);

        // 関節の回転を取得する
        var joints = body.JointOrientations;

        // 右手が右肩より高い
        if (joints[JointType.HandRight].Orientation.Y > joints[JointType.ShoulderRight].Orientation.Y)
        {
            Debug.Log("A");
        }


        if (body.HandRightState == HandState.Closed) //閉じている手の形
        {
            closedCount++;
            notClosedCount = 0;
        }
        else if (body.HandRightState == HandState.Open || body.HandRightState == HandState.Lasso) //閉じていない手の形
        {
            notClosedCount++;
            closedCount = 0;
        }
        else
        { //body.HandRightState == HandState.NotTracked
            closedCount = 0;
            notClosedCount = 0;
        }
        wasClosed = isClosed;

        if (closedCount == judgeClosed) //閉じている判定
        {
            isClosed = true;
        }

        if (notClosedCount == judgeNotClosed) //閉じていない判定
        {
            isClosed = false;
        }

        if (!wasClosed && isClosed) //手を閉じたとき
        {
            Debug.Log("B");
            Instantiate(testObject);
            //shooting.Shoot();
            notClosedCount = 0;
        }

    }
}
