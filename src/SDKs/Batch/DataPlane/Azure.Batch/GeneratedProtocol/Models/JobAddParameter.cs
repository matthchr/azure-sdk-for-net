// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch job to add.
    /// </summary>
    public partial class JobAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobAddParameter class.
        /// </summary>
        public JobAddParameter()
        {
            PoolInfo = new PoolInformation();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the job within
        /// the account.</param>
        /// <param name="poolInfo">The pool on which the Batch service runs the
        /// job's tasks.</param>
        /// <param name="displayName">The display name for the job.</param>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="constraints">The execution constraints for the
        /// job.</param>
        /// <param name="jobManagerTask">Details of a Job Manager task to be
        /// launched when the job is started.</param>
        /// <param name="jobPreparationTask">The Job Preparation task.</param>
        /// <param name="jobReleaseTask">The Job Release task.</param>
        /// <param name="commonEnvironmentSettings">The list of common
        /// environment variable settings. These environment variables are set
        /// for all tasks in the job (including the Job Manager, Job
        /// Preparation and Job Release tasks).</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in the job are in the completed
        /// state.</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any task in the job fails.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job as metadata.</param>
        /// <param name="usesTaskDependencies">Whether tasks in the job can
        /// define dependencies on each other. The default is false.</param>
        public JobAddParameter(string id, PoolInformation poolInfo, string displayName = default(string), int? priority = default(int?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), IList<EnvironmentSetting> commonEnvironmentSettings = default(IList<EnvironmentSetting>), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), IList<MetadataItem> metadata = default(IList<MetadataItem>), bool? usesTaskDependencies = default(bool?))
        {
            Id = id;
            DisplayName = displayName;
            Priority = priority;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            Metadata = metadata;
            UsesTaskDependencies = usesTaskDependencies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the job within the
        /// account.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters. The ID is case-preserving and case-insensitive (that
        /// is, you may not have two IDs within an account that differ only by
        /// case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the job.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. The default
        /// value is 0.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets details of a Job Manager task to be launched when the
        /// job is started.
        /// </summary>
        /// <remarks>
        /// If the job does not specify a Job Manager task, the user must
        /// explicitly add tasks to the job. If the job does specify a Job
        /// Manager task, the Batch service creates the Job Manager task when
        /// the job is created, and will try to schedule the Job Manager task
        /// before scheduling other tasks in the job. The Job Manager task's
        /// typical purpose is to control and/or monitor job execution, for
        /// example by deciding what additional tasks to run, determining when
        /// the work is complete, etc. (However, a Job Manager task is not
        /// restricted to these activities - it is a fully-fledged task in the
        /// system and perform whatever actions are required for the job.) For
        /// example, a Job Manager task might download a file specified as a
        /// parameter, analyze the contents of that file and submit additional
        /// tasks based on those contents.
        /// </remarks>
        [JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task.
        /// </summary>
        /// <remarks>
        /// If a job has a Job Preparation task, the Batch service will run the
        /// Job Preparation task on a compute node before starting any tasks of
        /// that job on that compute node.
        /// </remarks>
        [JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task.
        /// </summary>
        /// <remarks>
        /// A Job Release task cannot be specified without also specifying a
        /// Job Preparation task for the job. The Batch service runs the Job
        /// Release task on the compute nodes that have run the Job Preparation
        /// task. The primary purpose of the Job Release task is to undo
        /// changes to compute nodes made by the Job Preparation task. Example
        /// activities include deleting local files, or shutting down services
        /// that were started as part of job preparation.
        /// </remarks>
        [JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets the list of common environment variable settings.
        /// These environment variables are set for all tasks in the job
        /// (including the Job Manager, Job Preparation and Job Release tasks).
        /// </summary>
        /// <remarks>
        /// Individual tasks can override an environment setting specified here
        /// by specifying the same setting name with a different value.
        /// </remarks>
        [JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in the job are in the completed state.
        /// </summary>
        /// <remarks>
        /// Note that if a job contains no tasks, then all tasks are considered
        /// complete. This option is therefore most commonly used with a Job
        /// Manager task; if you want to use automatic job termination without
        /// a Job Manager, you should initially set onAllTasksComplete to
        /// noaction and update the job properties to set onAllTasksComplete to
        /// terminatejob once you have finished adding tasks. The default is
        /// noaction. Possible values include: 'noAction', 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any task
        /// in the job fails.
        /// </summary>
        /// <remarks>
        /// A task is considered to have failed if has a failureInfo. A
        /// failureInfo is set if the task completes with a non-zero exit code
        /// after exhausting its retry count, or if there was an error starting
        /// the task, for example due to a resource file download error. The
        /// default is noaction. Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'
        /// </remarks>
        [JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets whether tasks in the job can define dependencies on
        /// each other. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

    }
}
