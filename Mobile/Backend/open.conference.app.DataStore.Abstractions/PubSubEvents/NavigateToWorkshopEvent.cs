﻿using open.conference.app.DataStore.Abstractions.DataObjects;
using Prism.Events;

namespace open.conference.app.DataStore.Abstractions.PubSubEvents
{
    public class NavigateToWorkshopEvent : PubSubEvent<Workshop>
    {
    }
}
