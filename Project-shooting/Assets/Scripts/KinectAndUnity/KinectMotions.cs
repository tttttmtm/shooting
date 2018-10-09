using UnityEngine;
using System.Collections;
using Windows.Kinect;
using System.Collections.Generic;
using System.Linq;

public class KinectMotions : MonoBehaviour
{
    public s_shooting shooting;
    public UnityController control;

    public BodySourceManager _BodyManager;

    HandState beforeHandRightState;
    bool isClosed = true;
    bool wasClosed = true;
    const int judgeNotClosed = 2;
    const int judgeClosed = 5;
    int notClosedCount = 0;
    int closedCount = 0;



    HandState[] pastHandRightState = new HandState[10];
    //public GameObject testObject;

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
        //var joints = body.JointOrientations;

        var joints = body.Joints;
        //頭
        var Head = joints[JointType.Head].Position;
        //首
        var Neck = joints[JointType.Neck].Position;
        //腰の中心
        var SpineBase = joints[JointType.SpineBase].Position;
        //胸の中心
        var SpineMid = joints[JointType.SpineMid].Position;
        //肩の中心
        var SpineShoulder = joints[JointType.SpineShoulder].Position;
        //左肩
        var ShoulderLeft = joints[JointType.ShoulderLeft].Position;
        //右肩
        var ShoulderRight = joints[JointType.ShoulderRight].Position;
        //左肘
        var ElbowLeft = joints[JointType.ElbowLeft].Position;
        //左手首
        var WristLeft = joints[JointType.WristLeft].Position;
        //左手
        var HandLeft = joints[JointType.HandLeft].Position;
        //右肘
        var ElbowRight = joints[JointType.ElbowRight].Position;
        //右手首
        var WristRight = joints[JointType.WristRight].Position;
        //右手
        var HandRight = joints[JointType.HandRight].Position;
        //左膝
        var KneeLeft = joints[JointType.KneeLeft].Position;
        //左足首
        var AnkleLeft = joints[JointType.AnkleLeft].Position;
        //右膝
        var KneeRight = joints[JointType.KneeRight].Position;
        //右足首
        var AnkleRight = joints[JointType.AnkleRight].Position;

        //左尻
        var HipLeft = joints[JointType.HipLeft].Position;
        //右尻
        var HipRight = joints[JointType.HipRight].Position;


        if (body.HandRightState == HandState.Closed) //閉じている手の形
        {
            closedCount++;
            notClosedCount = 0;
        }
        else if (body.HandRightState == HandState.Open || body.HandRightState == HandState.Lasso || body.HandRightState == HandState.Unknown) //閉じていない手の形
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

        if (closedCount == judgeClosed) //閉じた判定
        {
            isClosed = true;
        }
        if (notClosedCount == judgeNotClosed) //閉じてない判定
        {
            isClosed = false;
        }

        if (!wasClosed && isClosed) //手を閉じたとき
        {
            Debug.Log("Bung!");
            //Instantiate(testObject);
            shooting.Shoot();
            notClosedCount = 0;
        }


        //// 右手が右肩より高い
        //if (joints[JointType.HandRight].Orientation.Y > joints[JointType.ShoulderRight].Orientation.Y)
        //{
        //    Debug.Log("A");
        //}

        //if (body.HandRightState == HandState.Closed) //閉じている手の形
        //{
        //    closedCount++;
        //    notClosedCount = 0;
        //}
        //else if (body.HandRightState == HandState.Open || body.HandRightState == HandState.Lasso) //閉じていない手の形
        //{
        //    notClosedCount++;
        //    closedCount = 0;
        //}
        //else
        //{ //body.HandRightState == HandState.NotTracked
        //    closedCount = 0;
        //    notClosedCount = 0;
        //}
        //wasClosed = isClosed;

        //if (closedCount == judgeClosed) //閉じている判定
        //{
        //    isClosed = true;
        //}

        //if (notClosedCount == judgeNotClosed) //閉じていない判定
        //{
        //    isClosed = false;
        //}

        //if (!wasClosed && isClosed) //手を閉じたとき
        //{
        //    Debug.Log("B");
        //    Instantiate(testObject);
        //    //shooting.Shoot();
        //    notClosedCount = 0;
        //}

        ////体を右に傾ける
        //if (Mathf.Pow(SpineShoulder.X + HipRight.X, 2) + Mathf.Pow(SpineShoulder.Z + HipRight.Z, 2) < Mathf.Pow(SpineShoulder.X + SpineBase.X, 2) + Mathf.Pow(SpineShoulder.Z + SpineBase.Z, 2))
        //{

        //    Debug.Log("Turn Right");
        //}
        //else if (Mathf.Pow(SpineShoulder.X + HipLeft.X, 2) + Mathf.Pow(SpineShoulder.Z + HipLeft.Z, 2) < Mathf.Pow(SpineShoulder.X + SpineBase.X, 2) + Mathf.Pow(SpineShoulder.Z + SpineBase.Z, 2)) //体を左に傾ける
        //{
        //    Debug.Log("Turn Left");
        //}
        //else
        //{ //傾けていない

        //}

        ////左手を上げる
        //if (HandLeft.Y > ShoulderLeft.Y)
        //{
        //    Debug.Log("Up Left Hand");
        //}
        ////右手を上げる
        //if (HandRight.Y > ShoulderRight.Y)
        //{
        //    Debug.Log("Up Right Hand");
        //}

        float ofset = 0.15f;
        //左手が肘より上にある
        if (HandLeft.Y > ElbowLeft.Y + ofset)
        {
            Debug.Log("Go Back");
            control.GoBack();
        }//左手が肘より下にある
        else if (HandLeft.Y < ElbowLeft.Y - ofset)
        {
            Debug.Log("Go Forward");
            control.GoForward();
        }
        else {
            control.Idle();
        }

        //左手が肘より右にある
        if (HandLeft.X > ElbowLeft.X + ofset)
        {
            Debug.Log("Turn Right");
            control.TurnRight();
        }//左手が肘より左にある
        else if (HandLeft.X < ElbowLeft.X - ofset)
        {
            Debug.Log("Turn Left");
            control.TurnLeft();
        }
    }

}


