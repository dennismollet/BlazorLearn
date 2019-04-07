namespace Blazor.HtmlElements
{
    public class BreakElement : HtmlElement, IRenderElement
    {
        public BreakElement()
            :base()
        {
            
        }

        public override string Tag => "br";
    }
}