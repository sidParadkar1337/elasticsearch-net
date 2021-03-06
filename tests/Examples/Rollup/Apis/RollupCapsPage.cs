// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Rollup.Apis
{
	public class RollupCapsPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("rollup/apis/rollup-caps.asciidoc:57")]
		public void Line57()
		{
			// tag::2d20c42e9664febeccaff61581605cbe[]
			var response0 = new SearchResponse<object>();
			// end::2d20c42e9664febeccaff61581605cbe[]

			response0.MatchesExample(@"PUT _rollup/job/sensor
			{
			    ""index_pattern"": ""sensor-*"",
			    ""rollup_index"": ""sensor_rollup"",
			    ""cron"": ""*/30 * * * * ?"",
			    ""page_size"" :1000,
			    ""groups"" : {
			      ""date_histogram"": {
			        ""field"": ""timestamp"",
			        ""fixed_interval"": ""1h"",
			        ""delay"": ""7d""
			      },
			      ""terms"": {
			        ""fields"": [""node""]
			      }
			    },
			    ""metrics"": [
			        {
			            ""field"": ""temperature"",
			            ""metrics"": [""min"", ""max"", ""sum""]
			        },
			        {
			            ""field"": ""voltage"",
			            ""metrics"": [""avg""]
			        }
			    ]
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("rollup/apis/rollup-caps.asciidoc:92")]
		public void Line92()
		{
			// tag::a00311843b5f8f3e9f7d511334a828b1[]
			var response0 = new SearchResponse<object>();
			// end::a00311843b5f8f3e9f7d511334a828b1[]

			response0.MatchesExample(@"GET _rollup/data/sensor-*");
		}

		[U(Skip = "Example not implemented")]
		[Description("rollup/apis/rollup-caps.asciidoc:164")]
		public void Line164()
		{
			// tag::944806221eb89f5af2298ccdf2902277[]
			var response0 = new SearchResponse<object>();
			// end::944806221eb89f5af2298ccdf2902277[]

			response0.MatchesExample(@"GET _rollup/data/_all");
		}

		[U(Skip = "Example not implemented")]
		[Description("rollup/apis/rollup-caps.asciidoc:173")]
		public void Line173()
		{
			// tag::f8cb1a04c2e487ff006b5ae0e1a7afbd[]
			var response0 = new SearchResponse<object>();
			// end::f8cb1a04c2e487ff006b5ae0e1a7afbd[]

			response0.MatchesExample(@"GET _rollup/data/sensor-1");
		}
	}
}
