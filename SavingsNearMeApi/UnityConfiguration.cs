﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
﻿using SavingsNearMeApi.Data.Contracts;
using SavingsNearMeApi.Data;

namespace SavingsNearMeApi
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer(bool useMock = false)
        {
            var container = new UnityContainer();

            if (useMock)
            {

            }
            else
            {
                container.RegisterType<ISavingsNearMeUow, SavingsNearMeUow>();
                container.RegisterType<ISavingsNearMeContext, SavingsNearMeContext>();
            }

            return container;

        }
    }
}