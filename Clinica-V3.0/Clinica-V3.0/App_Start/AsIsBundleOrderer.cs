﻿using System.Collections.Generic;
using System.Web.Optimization;

namespace Clinica_V3._0
{
    public class AsIsBundleOrderer : IBundleOrderer
    {

        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}