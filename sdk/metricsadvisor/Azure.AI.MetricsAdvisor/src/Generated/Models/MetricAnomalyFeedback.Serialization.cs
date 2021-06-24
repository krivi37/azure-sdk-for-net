// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricAnomalyFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime");
            writer.WriteStringValue(EndTime, "O");
            writer.WritePropertyName("value");
            writer.WriteObjectValue(ValueInternal);
            if (Optional.IsDefined(DetectionConfigurationId))
            {
                if (DetectionConfigurationId != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationId");
                    writer.WriteStringValue(DetectionConfigurationId);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationId");
                }
            }
            if (Optional.IsDefined(DetectionConfigurationSnapshot))
            {
                if (DetectionConfigurationSnapshot != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationSnapshot");
                    writer.WriteObjectValue(DetectionConfigurationSnapshot);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationSnapshot");
                }
            }
            writer.WritePropertyName("feedbackType");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("metricId");
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter");
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricAnomalyFeedback DeserializeMetricAnomalyFeedback(JsonElement element)
        {
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            AnomalyFeedbackValue value = default;
            Optional<string> anomalyDetectionConfigurationId = default;
            Optional<AnomalyDetectionConfiguration> anomalyDetectionConfigurationSnapshot = default;
            MetricFeedbackKind feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            GetAllFeedbackFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = AnomalyFeedbackValue.DeserializeAnomalyFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationId = null;
                        continue;
                    }
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationSnapshot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationSnapshot = null;
                        continue;
                    }
                    anomalyDetectionConfigurationSnapshot = AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"))
                {
                    feedbackType = new MetricFeedbackKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"))
                {
                    dimensionFilter = GetAllFeedbackFilter.DeserializeGetAllFeedbackFilter(property.Value);
                    continue;
                }
            }
            return new MetricAnomalyFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, startTime, endTime, value, anomalyDetectionConfigurationId.Value, anomalyDetectionConfigurationSnapshot.Value);
        }
    }
}
