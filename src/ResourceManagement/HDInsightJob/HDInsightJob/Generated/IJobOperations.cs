// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.HDInsight.Job.Models;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    /// <summary>
    /// Operations for managing jobs against HDInsight clusters.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Gets the list of jobs from the specified HDInsight cluster.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        Task<JobGetResponse> GetJobAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of jobs from the specified HDInsight cluster.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        Task<JobGetResponse> KillJobAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of jobs from the specified HDInsight cluster.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Job operation response.
        /// </returns>
        Task<JobListResponse> ListJobsAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Submits an Hive job to an HDINSIGHT cluster.
        /// </summary>
        /// <param name='parameters'>
        /// Hive job parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobSubmissionResponse> SubmitHiveJobAsync(HiveJobSubmissionParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Submits a MapReduce job to an HDINSIGHT cluster.
        /// </summary>
        /// <param name='parameters'>
        /// MapReduce job parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobSubmissionResponse> SubmitMapReduceJobAsync(MapReduceJobSubmissionParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Submits a MapReduce streaming job to an HDINSIGHT cluster.
        /// </summary>
        /// <param name='parameters'>
        /// MapReduce job parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobSubmissionResponse> SubmitMapReduceStreamingJobAsync(MapReduceStreamingJobSubmissionParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Submits an Hive job to an HDINSIGHT cluster.
        /// </summary>
        /// <param name='parameters'>
        /// Pig job parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobSubmissionResponse> SubmitPigJobAsync(PigJobSubmissionParameters parameters, CancellationToken cancellationToken);
    }
}