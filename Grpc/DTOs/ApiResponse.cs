namespace Grpc.DTOs;

public class ApiResponse
{
    private object? _value;

    public bool Success { get; set; }
    public string? ErrorMessage { get; set; }

    public object? Value
    {
        get
        {
            //checking if this object is a Task object
            if (_value is Task<object?> val)
            {
                val.Wait();
                _value = val.Result;// assign result to _value
            }
            return _value;
        }
        set => _value = value;
    }
}
