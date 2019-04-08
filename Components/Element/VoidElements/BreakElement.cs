namespace Blazor.HtmlElements
{
    public class BreakElement : HtmlBaseElement, IRenderElement
    {
        public BreakElement()
            : base()
        {

        }

        public override string Tag => "br";
    }
}