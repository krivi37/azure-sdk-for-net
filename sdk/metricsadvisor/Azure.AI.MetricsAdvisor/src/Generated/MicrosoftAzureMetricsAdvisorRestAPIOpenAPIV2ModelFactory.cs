// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> Model factory for read-only models. </summary>
    internal static partial class MicrosoftAzureMetricsAdvisorRestAPIOpenAPIV2ModelFactory
    {
        /// <summary> Initializes new instance of AnomalyAlertConfiguration class. </summary>
        /// <param name="id"> anomaly alerting configuration unique id. </param>
        /// <param name="name"> anomaly alerting configuration name. </param>
        /// <param name="description"> anomaly alerting configuration description. </param>
        /// <param name="crossMetricsOperator">
        /// cross metrics operator
        /// 
        /// 
        /// 
        /// should be specified when setting up multiple metric alerting configurations.
        /// </param>
        /// <param name="dimensionsToSplitAlert"> dimensions used to split alert. </param>
        /// <param name="idsOfHooksToAlert"> hook unique ids. </param>
        /// <param name="metricAlertConfigurations"> Anomaly alerting configurations. </param>
        /// <returns> A new <see cref="Models.AnomalyAlertConfiguration"/> instance for mocking. </returns>
        public static AnomalyAlertConfiguration AnomalyAlertConfiguration(string id = default, string name = default, string description = default, DetectionConditionOperator? crossMetricsOperator = default, IList<string> dimensionsToSplitAlert = default, IList<string> idsOfHooksToAlert = default, IList<MetricAlertConfiguration> metricAlertConfigurations = default)
        {
            dimensionsToSplitAlert ??= new List<string>();
            idsOfHooksToAlert ??= new List<string>();
            metricAlertConfigurations ??= new List<MetricAlertConfiguration>();
            return new AnomalyAlertConfiguration(id, name, description, crossMetricsOperator, dimensionsToSplitAlert, idsOfHooksToAlert, metricAlertConfigurations);
        }

        /// <summary> Initializes new instance of AnomalyAlert class. </summary>
        /// <param name="id"> alert id. </param>
        /// <param name="timestamp"> anomaly time. </param>
        /// <param name="createdTime"> created time. </param>
        /// <param name="modifiedTime"> modified time. </param>
        /// <returns> A new <see cref="Models.AnomalyAlert"/> instance for mocking. </returns>
        public static AnomalyAlert AnomalyAlert(string id = default, DateTimeOffset timestamp = default, DateTimeOffset createdTime = default, DateTimeOffset modifiedTime = default)
        {
            return new AnomalyAlert(id, timestamp, createdTime, modifiedTime);
        }

        /// <summary> Initializes new instance of AnomalyDetectionConfiguration class. </summary>
        /// <param name="id"> anomaly detection configuration unique id. </param>
        /// <param name="name"> anomaly detection configuration name. </param>
        /// <param name="description"> anomaly detection configuration description. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="wholeSeriesDetectionConditions"> . </param>
        /// <param name="seriesGroupDetectionConditions"> detection configuration for series group. </param>
        /// <param name="seriesDetectionConditions"> detection configuration for specific series. </param>
        /// <returns> A new <see cref="Models.AnomalyDetectionConfiguration"/> instance for mocking. </returns>
        public static AnomalyDetectionConfiguration AnomalyDetectionConfiguration(string id = default, string name = default, string description = default, string metricId = default, MetricWholeSeriesDetectionCondition wholeSeriesDetectionConditions = default, IList<MetricSeriesGroupDetectionCondition> seriesGroupDetectionConditions = default, IList<MetricSingleSeriesDetectionCondition> seriesDetectionConditions = default)
        {
            seriesGroupDetectionConditions ??= new List<MetricSeriesGroupDetectionCondition>();
            seriesDetectionConditions ??= new List<MetricSingleSeriesDetectionCondition>();
            return new AnomalyDetectionConfiguration(id, name, description, metricId, wholeSeriesDetectionConditions, seriesGroupDetectionConditions, seriesDetectionConditions);
        }

        /// <summary> Initializes new instance of IncidentRootCause class. </summary>
        /// <param name="seriesGroupKey"> . </param>
        /// <param name="paths"> drilling down path from query anomaly to root cause. </param>
        /// <param name="contributionScore"> score of the root cause. </param>
        /// <param name="description"> description of the root cause. </param>
        /// <returns> A new <see cref="Models.IncidentRootCause"/> instance for mocking. </returns>
        public static IncidentRootCause IncidentRootCause(DimensionKey seriesGroupKey = default, IReadOnlyList<string> paths = default, double contributionScore = default, string description = default)
        {
            paths ??= new List<string>();
            return new IncidentRootCause(seriesGroupKey, paths, contributionScore, description);
        }

        /// <summary> Initializes new instance of DataFeedMetric class. </summary>
        /// <param name="id"> metric id. </param>
        /// <param name="name"> metric name. </param>
        /// <param name="displayName"> metric display name. </param>
        /// <param name="description"> metric description. </param>
        /// <returns> A new <see cref="Models.DataFeedMetric"/> instance for mocking. </returns>
        public static DataFeedMetric DataFeedMetric(string id = default, string name = default, string displayName = default, string description = default)
        {
            return new DataFeedMetric(id, name, displayName, description);
        }

        /// <summary> Initializes new instance of DataFeedIngestionStatus class. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest ingestion task status for this data slice. </param>
        /// <param name="message"> the trimmed message of last ingestion job. </param>
        /// <returns> A new <see cref="Models.DataFeedIngestionStatus"/> instance for mocking. </returns>
        public static DataFeedIngestionStatus DataFeedIngestionStatus(DateTimeOffset timestamp = default, IngestionStatusType status = default, string message = default)
        {
            return new DataFeedIngestionStatus(timestamp, status, message);
        }

        /// <summary> Initializes new instance of DataFeedIngestionProgress class. </summary>
        /// <param name="latestSuccessTimestamp">
        /// the timestamp of latest success ingestion job.
        /// 
        /// null indicates not available.
        /// </param>
        /// <param name="latestActiveTimestamp">
        /// the timestamp of latest ingestion job with status update.
        /// 
        /// null indicates not available.
        /// </param>
        /// <returns> A new <see cref="Models.DataFeedIngestionProgress"/> instance for mocking. </returns>
        public static DataFeedIngestionProgress DataFeedIngestionProgress(DateTimeOffset? latestSuccessTimestamp = default, DateTimeOffset? latestActiveTimestamp = default)
        {
            return new DataFeedIngestionProgress(latestSuccessTimestamp, latestActiveTimestamp);
        }

        /// <summary> Initializes new instance of MetricSeriesData class. </summary>
        /// <param name="definition"> . </param>
        /// <param name="timestamps"> timestamps of the data related to this time series. </param>
        /// <param name="metricValues"> values of the data related to this time series. </param>
        /// <returns> A new <see cref="Models.MetricSeriesData"/> instance for mocking. </returns>
        public static MetricSeriesData MetricSeriesData(MetricSeriesDefinition definition = default, IReadOnlyList<DateTimeOffset> timestamps = default, IReadOnlyList<double> metricValues = default)
        {
            timestamps ??= new List<DateTimeOffset>();
            metricValues ??= new List<double>();
            return new MetricSeriesData(definition, timestamps, metricValues);
        }

        /// <summary> Initializes new instance of MetricSeriesDefinition class. </summary>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimension"> dimension name and value pair. </param>
        /// <returns> A new <see cref="Models.MetricSeriesDefinition"/> instance for mocking. </returns>
        public static MetricSeriesDefinition MetricSeriesDefinition(string metricId = default, IReadOnlyDictionary<string, string> dimension = default)
        {
            dimension ??= new Dictionary<string, string>();
            return new MetricSeriesDefinition(metricId, dimension);
        }

        /// <summary> Initializes new instance of EnrichmentStatus class. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest enrichment status for this data slice. </param>
        /// <param name="message"> the trimmed message describes details of the enrichment status. </param>
        /// <returns> A new <see cref="Models.EnrichmentStatus"/> instance for mocking. </returns>
        public static EnrichmentStatus EnrichmentStatus(DateTimeOffset timestamp = default, string status = default, string message = default)
        {
            return new EnrichmentStatus(timestamp, status, message);
        }
    }
}
