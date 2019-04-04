using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public interface IRenderElement
    {
        string RenderElement();
        string Tag { get; }
    }

    public interface ICssClass
    {

    }

    // public interface IAttribute<T>
    //     where T : IHtmlAttributeList
    // {

    // }

    public interface INestableElement
    {
        void AddElement(IRenderElement element);
    }

    public interface IValueElement
    {
        string Value { get; }
    }


}