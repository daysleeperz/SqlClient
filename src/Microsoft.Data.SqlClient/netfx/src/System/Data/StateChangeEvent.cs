//------------------------------------------------------------------------------
// <copyright file="StateChangeEvent.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <owner current="true" primary="true">markash</owner>
// <owner current="true" primary="false">laled</owner>
//------------------------------------------------------------------------------

namespace Microsoft.Data {
    using System;
    using System.Data;

    public sealed class StateChangeEventArgs : System.EventArgs {
        private ConnectionState originalState;
        private ConnectionState currentState;

        public StateChangeEventArgs(ConnectionState originalState, ConnectionState currentState) {
            this.originalState = originalState;
            this.currentState = currentState;
        }

        public ConnectionState CurrentState {
            get {
                return this.currentState;
            }
        }

        public ConnectionState OriginalState {
            get {
                return this.originalState;
            }
        }
    }
}