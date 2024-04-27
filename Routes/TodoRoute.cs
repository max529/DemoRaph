using AventusSharp.Routes;
using AventusSharp.Routes.Attributes;
using DemoRaph.Logic;
using DemoRaph.Data;
using Path = AventusSharp.Routes.Attributes.Path;

namespace DemoRaph.Routes
{
    [TypescriptPath("Todo")]
    public class TodoRoute : StorableRoute<Todo>
    {

    }
}
