﻿using System;
using Events.Models;
using Xamarin.Forms;
namespace Events.Controls
{
	public class EventsDataTemplate : DataTemplateSelector
	{
		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var info = item as IFeedMember;
			if (info.Type == MemberType.EventInfo)
			{
				return new DataTemplate(typeof(EventFeedViewCell));
			}
			return null;
		}
	}
}
