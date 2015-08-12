﻿/*
   Copyright 2012-2015 Marco De Salvo

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Linq;
using System.Collections.Generic;
using RDFSharp.Model;
using RDFSharp.Store;
using RDFSharp.Query;

namespace RDFSharp.Semantics
{

    /// <summary>
    /// RDFOntologyClass represents a class definition within an ontology model.
    /// </summary>
    public class RDFOntologyClass: RDFOntologyResource {

        #region Ctors
        /// <summary>
        /// Default-ctor to build an ontology class with the given name
        /// </summary>
        public RDFOntologyClass(RDFResource className) {
            if (className != null) {
                this.Value           = className;
                this.PatternMemberID = className.PatternMemberID;
            }
            else {
                throw new RDFSemanticsException("Cannot create RDFOntologyClass because given \"className\" parameter is null.");
            }
        }
        #endregion

    }

}