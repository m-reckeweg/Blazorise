﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
#endregion

namespace Blazorise.Bulma
{
    public static class Config
    {
        public static IServiceCollection AddBulmaProviders( this IServiceCollection serviceCollection )
        {
            serviceCollection.AddSingleton<IClassProvider, BulmaClassProvider>();
            serviceCollection.AddSingleton<IStyleProvider, BulmaStyleProvider>();
            serviceCollection.AddSingleton<IJSRunner, JSRunner>();

            var componentMapper = new ComponentMapper();

            componentMapper.Register<Blazorise.Addons, Bulma.Addons>();
            componentMapper.Register<Blazorise.BarToggler, Bulma.BarToggler>();
            componentMapper.Register<Blazorise.Breadcrumb, Bulma.Breadcrumb>();
            componentMapper.Register<Blazorise.BreadcrumbLink, Bulma.BreadcrumbLink>();
            componentMapper.Register<Blazorise.CardImage, Bulma.CardImage>();
            componentMapper.Register<Blazorise.CardSubtitle, Bulma.CardSubtitle>();
            componentMapper.Register<Blazorise.CheckEdit, Bulma.CheckEdit>();
            componentMapper.Register<Blazorise.DateEdit, Bulma.DateEdit>();
            componentMapper.Register<Blazorise.DropdownDivider, Bulma.DropdownDivider>();
            componentMapper.Register<Blazorise.DropdownMenu, Bulma.DropdownMenu>();
            componentMapper.Register<Blazorise.DropdownToggle, Bulma.DropdownToggle>();
            componentMapper.Register<Blazorise.Field, Bulma.Field>();
            componentMapper.Register<Blazorise.FieldLabel, Bulma.FieldLabel>();
            componentMapper.Register<Blazorise.FieldHelp, Bulma.FieldHelp>();
            componentMapper.Register<Blazorise.FieldBody, Bulma.FieldBody>();
            componentMapper.Register<Blazorise.Fields, Bulma.Fields>();
            componentMapper.Register<Blazorise.FileEdit, Bulma.FileEdit>();
            componentMapper.Register<Blazorise.MemoEdit, Bulma.MemoEdit>();
            componentMapper.Register<Blazorise.SelectEdit, Bulma.SelectEdit>();
            componentMapper.Register<Blazorise.SimpleButton, Bulma.SimpleButton>();
            componentMapper.Register<Blazorise.Tabs, Bulma.Tabs>();
            componentMapper.Register<Blazorise.TextEdit, Bulma.TextEdit>();

            serviceCollection.AddSingleton<IComponentMapper>( componentMapper );

            return serviceCollection;
        }
    }
}
