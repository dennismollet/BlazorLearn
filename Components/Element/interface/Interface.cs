using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public interface IRenderElement
    {
        string RenderElement();
        string Tag { get; }
        string InnerHtmlText { get; }
        void SetInnerHtmlText(string text);
    }

    public interface INestableElement : IRenderElement
    {
        void AddElement(IRenderElement element);
        string RenderChildren();
    }

    public interface IValueElement
    {
        string Value { get; }
    }

    public interface IAttributeElement
    {
        IBuildAttributesString Attributes {get;}
    }

    public interface IBuildAttributesString
    {
        void AddAttribute(IBuildAttributeString attribute);
        string BuildAttributesString();
    }
    public interface IBuildAttributeString
    {
        
        string BuildAttributeString();
        string Key {get;}
    }

    public interface IAreaShape
    {
        IBuildAttributeString BuildAreaAttribute();
    }
    
    public interface IAreaCoordinates
    {
        IBuildAttributeString BuildCoordinatesAttribute();
    }

}