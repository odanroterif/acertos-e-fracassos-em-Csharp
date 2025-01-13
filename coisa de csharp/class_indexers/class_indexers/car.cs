namespace class_indexers;

public class Car
{
    private static float[] maxSpeed = new float[11];
    //private List<float> maxSpeed = new List<float>(); <--- isso também pode ser usado
    public int length = maxSpeed.Length;
    public float this[int i] { get => maxSpeed[i]; set => maxSpeed[i] = value; }
}