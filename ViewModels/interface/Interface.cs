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
    /// Should be implemented on the 'viewmodel' that has components that can be dragged.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHandleDrag<T>
    {
        IDragEvents<T> GetDragEventHandler(string key);
    }

    /// <summary>
    /// Should be implemented on the 'viewmodel' that has componenents that can be dropped on.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHandleDrop<T>
    {
        IDropEvents<T> GetDropEventHandler(string key);
    }

    /// <summary>
    /// Should be implemented on the 'viewmodel' that has components that should react to a drag over
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHandleDragOver<T>
    {
        IDragOverEvents<T> GetDragOverEventHandler(string key);
    }

    /// <summary>
    /// Should be implemented on each individual component that can be dragged.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDragEvents<T>
    {
        void OnItemDrag(UIDragEventArgs e, T dataTransfer);
        void OnItemDragStart(UIDragEventArgs e, T dataTransfer);
        void OnItemDragEnd(UIDragEventArgs e, T dataTransfer);
    }

    /// <summary>
    /// Should be implemented on each individual component that can be dropped on.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDropEvents<T>
    {
        void OnContainerDrop(UIDragEventArgs e, T dataTransfer);
    }

    /// <summary>
    /// Should be implemented on each individual compononet that should react to a drag over.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDragOverEvents<T>
    {
        void OnContainerDragEnter(UIDragEventArgs e, T dataTransfer);
        void OnContainerDragLeave(UIDragEventArgs e, T dataTransfer);
        void OnDragOver(UIDragEventArgs e, T dataTransfer);
    }
}