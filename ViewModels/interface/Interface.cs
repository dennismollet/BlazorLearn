using System.Collections.Generic;
using Microsoft.AspNetCore.Blazor;

namespace Blazor.ViewModels
{
    public interface IBindList
    {
        List<IBind> GetData();
    }

    public interface IBind
    {
        List<IProperty> GetProperties();
        IProperty GetProperty(string name);
    }

    public interface IProperty
    {
        string GetPropertyName();
        string GetPropertyValueString();
    }

    public interface IProperty<T>
    {
        T GetPropertyValue();
    }

    /// <summary>
    /// Should be implemented on the 'viewmodel' that has components that can be dragged or dropped
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDragDrop<T>
    {
        T GetDataTransferItem(string transferItemKey);
    }

    /// <summary>
    /// Should be implemented on each individual component that can be dragged.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDrag<T>
    {
        string GetDragKey();
        void OnItemDrag(UIDragEventArgs e, T dataTransfer);
        void OnItemDragStart(UIDragEventArgs e, T dataTransfer);
        void OnItemDragEnd(UIDragEventArgs e, T dataTransfer);
    }

    /// <summary>
    /// Should be implemented on each individual component that can be dropped on
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDrop<T>
    {
        void OnContainerDragEnter(UIDragEventArgs e, T dataTransfer);
        void OnContainerDrop(UIDragEventArgs e, T dataTransfer);
        void OnContainerDragLeave(UIDragEventArgs e, T dataTransfer);
        void OnDragOver(UIDragEventArgs e, T dataTransfer);
    }
}