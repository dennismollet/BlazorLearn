namespace Blazor.HtmlElements
{
    public class BreakElement : VoidElement, IRenderElement
    {
        public BreakElement()
            : base()
        {

        }

        public override string Tag => "br";
    }
}