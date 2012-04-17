/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */
namespace NPOI.XWPF.UserModel
{
    using System;
    using NPOI.OpenXmlFormats.Wordprocessing;

    public class XWPFLatentStyles
    {
        private CT_LatentStyles latentStyles;
        protected XWPFStyles styles; //LatentStyle shall know styles

        protected XWPFLatentStyles()
        {
        }

        protected XWPFLatentStyles(CT_LatentStyles latentStyles)
            : this(latentStyles, null)
        {
            ;
        }

        protected XWPFLatentStyles(CT_LatentStyles latentStyles, XWPFStyles styles)
        {
            this.latentStyles = latentStyles;
            this.styles = styles;
        }

        /**
         * Checks wheter specific LatentStyleID is a latentStyle
        */
        protected bool IsLatentStyle(String latentStyleID)
        {
            /*foreach ( CTLsdException lsd in latentStyles.LsdExceptionList) {
                if(lsd.Name.Equals(latentStyleID));
                    return true;
            }
            return false;*/
            throw new NotImplementedException();
        }
    }

}