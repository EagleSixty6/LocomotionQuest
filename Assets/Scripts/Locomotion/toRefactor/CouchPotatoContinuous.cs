using UnityEngine;

public class CouchPotatoContinuous : MonoBehaviour
{
    #region Public Fields
    [Tooltip("in ° per seoncond")]
    public float _maxRotationSpeed;

    [Tooltip("in m per seoncond")]
    public float _maxTranslationSpeed;
    #endregion

    // should range from 0 no break to 1 full break;
    private float _breakState = 0f;
    private float _currentBrakingVelocity = 0f;

    private GameObject _camera;

    void Start()
    {   
        _camera = GameObject.Find("Camera");
    }

    void Update()
    {
       
        // you can use another rotational center here if you like
        Rotate(this.transform, _camera.transform);   
        Translate(this.transform, _camera.transform);

    }

    private void Translate(Transform trans, Transform cameraTrans)
    {
        // braking   
        float brakeTarget;
        if (_locomotionControl.IsBraked())
        {
            brakeTarget = 1f;
        }
        else
        {
            brakeTarget = 0f;
        }
        _breakState = Mathf.SmoothDamp(_breakState, brakeTarget, ref _currentBrakingVelocity, 0.5f);
        
        // it is couche potato, so we are moving into the direction of the locomotion platform, of course we have to make sure that this is aligned with the user orientation up front
        Vector3 movementDirection = trans.forward;
        float movementAxis = _locomotionControl.Get2DLeaningAxis().y;
        float distanceToTravel = movementAxis * _maxTranslationSpeed * Time.deltaTime;

        RaycastHit hit;
        int layerMask = 1 << 8; // terrain

        // when there is no obstacle in moving direction...
        if (!Physics.Raycast(trans.position, movementDirection * Mathf.Sign(movementAxis),
            out hit, 1f))
        {
                trans.position += (1f - _breakState) * distanceToTravel * movementDirection;
        }
    }

    private void Rotate(Transform trans, Transform rotationalCenter)
    {
        // Here the head yaw is used for virtual rotation. of course you can use s.t. else
        float angle = _maxRotationSpeed * Time.deltaTime * _locomotionControl.GetHeadYawAxis();
        trans.RotateAround(rotationalCenter.position, Vector3.up, angle);
    }
}
