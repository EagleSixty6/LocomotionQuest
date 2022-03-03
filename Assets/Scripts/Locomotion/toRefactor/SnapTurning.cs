using UnityEngine;

public class SnapTurning : MonoBehaviour
{
    #region Public Fields
    [Tooltip("Defines the time between two jumps.")]
    public float _rotationalJumpSaturationTime;

    public float _maxContinuousRotationSpeed;

    // the jumping threshold is given by rotational degree per second, this should make the threshold independent of the method used but
    // (be carefull) dependet of the transfer function
    public float _rotationalJumpingThresholdDegreePerSecond;
    #endregion

    [Tooltip("Defines the default, unmodified size of a jump rotation in degree.")]
    [Range(0f, 90f)]
    public float _rotationalJumpSize;

    private float _jumpSaturationTimer;
    private GameObject _camera;

    void Start()
    {
        _camera = GameObject.Find("Camera");
        _jumpSaturationTimer = _rotationalJumpSaturationTime;
    }

    void FixedUpdate()
    {
        // in best case use a calibrated rotational center here, not the camera positionn
        Rotate(this.transform, _camera.transform);     
    }

    private void Rotate(Transform trans, Transform rotationalCenter)
    {
        // the interface was used with a axis calculated from the head yaw and can be replaced by any other input axis [-1, 1] > [left, right]
        float signedAnglePerSecond = _maxContinuousRotationSpeed * _locomotionControl.GetHeadYawAxis();
        _jumpSaturationTimer -= Time.deltaTime;
 
        // apply the rotation
        // jump when maximum turning speed is exceeded and timer is over
        if (Mathf.Abs(signedAnglePerSecond) > _rotationalJumpingThresholdDegreePerSecond &&
            _jumpSaturationTimer < 0)
        {
            trans.RotateAround(rotationalCenter.position, Vector3.up, _rotationalJumpSize * Mathf.Sign(signedAnglePerSecond));

            // reset saturation time
            _jumpSaturationTimer = _rotationalJumpSaturationTime;
        }
        // else rotate continuously 
        else
        {
            signedAnglePerSecond = Mathf.Min(Mathf.Abs(signedAnglePerSecond), _rotationalJumpingThresholdDegreePerSecond) * Mathf.Sign(signedAnglePerSecond);
            trans.RotateAround(rotationalCenter.position, Vector3.up, signedAnglePerSecond * Time.deltaTime);
        }
    }
}
