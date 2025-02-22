// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using System;
using System.Diagnostics.CodeAnalysis;

namespace Esri.Calcite.WPF;

/// <summary>
/// Implements a weak event listener that allows the owner to be garbage
/// collected if its only remaining link is an event handler.
/// </summary>
/// <typeparam name="TListeningInstance">Type of instance listening for the event.</typeparam>
/// <typeparam name="TEventRaisingSource">Type of source for the event.</typeparam>
/// <typeparam name="TEventSender">Type of sender for the event handler.</typeparam>
/// <typeparam name="TEventArgs">Type of event arguments for the event.</typeparam>
[SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Used as link target in several projects.")]
internal sealed class WeakEventListener<TListeningInstance, TEventRaisingSource, TEventSender, TEventArgs>
    where TListeningInstance : class
{
    /// <summary>
    /// WeakReference to the instance listening for the event.
    /// </summary>
    private WeakReference _listeningInstance;
    private TEventRaisingSource? _eventSource;

    /// <summary>
    /// Gets or sets the method to call when the event fires.
    /// </summary>
    public Action<TListeningInstance, TEventSender?, TEventArgs>? OnEventAction { get; set; }

    /// <summary>
    /// Gets or sets the method to call when detaching from the event.
    /// </summary>
    public Action<TListeningInstance?, TEventRaisingSource?, WeakEventListener<TListeningInstance, TEventRaisingSource, TEventSender, TEventArgs>>? OnDetachAction { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WeakEventListener{TListeningInstance, TEventRaisingSource, TEventSender, TEventArgs}"/> class.
    /// </summary>
    /// <param name="instance">Instance subscribing to the event.</param>
    /// <param name="source">Source of the event.</param>
    public WeakEventListener(TListeningInstance instance, TEventRaisingSource? source)
    {
        if (instance == null)
        {
            throw new ArgumentNullException(nameof(instance));
        }

        _listeningInstance = new WeakReference(instance);
        _eventSource = source;
    }

    /// <summary>
    /// Handler for the subscribed event calls OnEventAction to handle it.
    /// </summary>
    /// <param name="sender">Event source.</param>
    /// <param name="eventArgs">Event arguments.</param>
    public void OnEvent(TEventSender? sender, TEventArgs eventArgs)
    {
        TListeningInstance? target = (TListeningInstance?)_listeningInstance.Target;
        if (target != null)
        {
            // Call registered action
            OnEventAction?.Invoke(target, sender, eventArgs);
        }
        else
        {
            // Detach from event
            Detach();
        }
    }

    /// <summary>
    /// Detaches from the subscribed event.
    /// </summary>
    public void Detach()
    {
        OnDetachAction?.Invoke(_listeningInstance.Target as TListeningInstance, _eventSource, this);
        OnDetachAction = null;
    }
}