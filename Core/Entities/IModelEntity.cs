namespace Core.Entities
{
    public class IModelEntity
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public bool IsError { get; set; } = false;
        public int Code { get; set; }

    }
}
