/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// General properties describing a fleet.
    /// </summary>
    public partial class FleetAttributes
    {
        private string _buildId;
        private DateTime? _creationTime;
        private string _description;
        private string _fleetId;
        private List<string> _logPaths = new List<string>();
        private string _name;
        private string _serverLaunchParameters;
        private string _serverLaunchPath;
        private FleetStatus _status;
        private DateTime? _terminationTime;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for a build.
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this object was created. Format is an integer representing
        /// the number of seconds since the Unix epoch (Unix time).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of the fleet.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property LogPaths. 
        /// <para>
        /// Path to game-session log files generated by your game server. Once a game session
        /// has been terminated, Amazon GameLift captures and stores the logs on Amazon S3. Use
        /// the GameLift console to access the stored logs.
        /// </para>
        /// </summary>
        public List<string> LogPaths
        {
            get { return this._logPaths; }
            set { this._logPaths = value; }
        }

        // Check to see if LogPaths property is set
        internal bool IsSetLogPaths()
        {
            return this._logPaths != null && this._logPaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label associated with this fleet. Fleet names do not need to be unique.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        /// Parameters required to launch your game server. These parameters should be expressed
        /// as a string of command-line parameters. Example: "+sv_port 33435 +start_lobby".
        /// </para>
        /// </summary>
        public string ServerLaunchParameters
        {
            get { return this._serverLaunchParameters; }
            set { this._serverLaunchParameters = value; }
        }

        // Check to see if ServerLaunchParameters property is set
        internal bool IsSetServerLaunchParameters()
        {
            return this._serverLaunchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ServerLaunchPath. 
        /// <para>
        /// Path to the launch executable for the game server. A game server is built into a <code>C:\game</code>
        /// drive. This value must be expressed as <code>C:\game\[launchpath]</code>. Example:
        /// If, when built, your game server files are in a folder called "MyGame", your log path
        /// should be <code>C:\game\MyGame\server.exe</code>.
        /// </para>
        /// </summary>
        public string ServerLaunchPath
        {
            get { return this._serverLaunchPath; }
            set { this._serverLaunchPath = value; }
        }

        // Check to see if ServerLaunchPath property is set
        internal bool IsSetServerLaunchPath()
        {
            return this._serverLaunchPath != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the fleet. Possible fleet states include: <ul><li>NEW: A new fleet
        /// has been defined and hosts allocated.</li><li>DOWNLOADING/VALIDATING/BUILDING/ACTIVATING:
        /// The new fleet is being set up with the game build, and new hosts are being started.</li><li>ACTIVE:
        /// Hosts can now accept game sessions.</li><li>ERROR: An error occurred when downloading,
        /// validating, building, or activating the fleet.</li><li>DELETING: Hosts are responding
        /// to a delete fleet request.</li><li>TERMINATED: The fleet no longer exists.</li></ul>
        /// </para>
        /// </summary>
        public FleetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// Time stamp indicating when this fleet was terminated. Format is an integer representing
        /// the number of seconds since the Unix epoch (Unix time).
        /// </para>
        /// </summary>
        public DateTime TerminationTime
        {
            get { return this._terminationTime.GetValueOrDefault(); }
            set { this._terminationTime = value; }
        }

        // Check to see if TerminationTime property is set
        internal bool IsSetTerminationTime()
        {
            return this._terminationTime.HasValue; 
        }

    }
}