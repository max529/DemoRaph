using AventusSharp.Data;

namespace DemoRaph.Data
{
    public class Todo : Storable<Todo>
    {
        public string Name { get; set; }
    }
}