namespace FlameFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Reflection;

    using Ensage.SDK.Service;
    using Ensage.SDK.Service.Metadata;

    using log4net;

    using PlaySharp.Toolkit.Logging;

    [ExportPlugin("FlameFramework", author: "h3h3")]
    public class FlameFrameworkEntryPoint : Plugin, IPartImportsSatisfiedNotification
    {
        private static readonly ILog Log = AssemblyLogs.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [ImportingConstructor]
        public FlameFrameworkEntryPoint([Import] IServiceContext context)
        {
            this.Context = context;
        }

        public IServiceContext Context { get; }

        [ImportMany(typeof(IFlameDictionary), AllowRecomposition = true)]
        public IEnumerable<Lazy<IFlameDictionary, IFlameDictionaryMetadata>> Dictionaries { get; set; }

        public void OnImportsSatisfied()
        {
            // TODO: update text cache
            Log.Info($"Flames imported!!!");
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }

        protected override void OnDeactivate()
        {
            base.OnDeactivate();
        }
    }
}