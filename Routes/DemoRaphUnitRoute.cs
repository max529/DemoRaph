using AventusSharp.Routes;
using AventusSharp.Routes.Attributes;
using DemoRaph.Logic;
using DemoRaph.Data;
using Path = AventusSharp.Routes.Attributes.Path;

namespace DemoRaph.Routes
{
    [TypescriptPath("DemoRaphUnit")]
    public class DemoRaphUnitRoute : StorableRoute<DemoRaphUnit>
    {
        [Get, Path("/custom")]
        public List<DemoRaphUnit> MyCustomRoute()
        {
           return DemoRaphUnitDM.GetInstance().Where(p => p.Name.StartsWith("Example"));
        }


    }
}
