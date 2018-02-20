﻿using System;
using Newtonsoft.Json;

namespace Nest
{
	public partial interface IPutIndexTemplateRequest : ITemplateMapping
	{
	}

	public partial class PutIndexTemplateRequest
	{
		[Obsolete("Removed in NEST 6.x.")]
		public string Template { get; set; }

		public int? Order { get; set; }

		public int? Version { get; set; }

		public IIndexSettings Settings { get; set; }

		public IMappings Mappings { get; set; }

		public IAliases Aliases { get; set; }
	}

	[DescriptorFor("IndicesPutTemplate")]
	public partial class PutIndexTemplateDescriptor
	{
		[Obsolete("Removed in NEST 6.x.")]
		string ITemplateMapping.Template { get; set; }

		int? ITemplateMapping.Order { get; set; }

		int? ITemplateMapping.Version { get; set; }

		IIndexSettings ITemplateMapping.Settings { get; set; }

		IMappings ITemplateMapping.Mappings { get; set; }

		IAliases ITemplateMapping.Aliases { get; set; }

		public PutIndexTemplateDescriptor Order(int order) => Assign(a => a.Order = order);

		public PutIndexTemplateDescriptor Version(int version) => Assign(a => a.Version = version);

		public PutIndexTemplateDescriptor Template(string template)=> Assign(a => a.Template = template);

		public PutIndexTemplateDescriptor Settings(Func<IndexSettingsDescriptor, IPromise<IIndexSettings>> settingsSelector) =>
			Assign(a => a.Settings = settingsSelector?.Invoke(new IndexSettingsDescriptor())?.Value);

		public PutIndexTemplateDescriptor Mappings(Func<MappingsDescriptor, IPromise<IMappings>> mappingSelector) =>
			Assign(a => a.Mappings = mappingSelector?.Invoke(new MappingsDescriptor())?.Value);

		public PutIndexTemplateDescriptor Aliases(Func<AliasesDescriptor, IPromise<IAliases>> aliasDescriptor) =>
			Assign(a => a.Aliases = aliasDescriptor?.Invoke(new AliasesDescriptor())?.Value);
	}
}
