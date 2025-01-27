/*
This file is part of the iText (R) project.
Copyright (c) 1998-2019 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using Common.Logging;
using iText.Html2pdf.Attach;
using iText.Html2pdf.Util;
using iText.Layout;
using iText.Layout.Element;
using iText.StyledXmlParser.Node;
using iText.Svg.Exceptions;
using iText.Svg.Processors;
using iText.Svg.Processors.Impl;

namespace iText.Html2pdf.Attach.Impl.Tags {
    /// <summary>
    /// TagWorker class for the
    /// <c>svg</c>
    /// element.
    /// </summary>
    public class SvgTagWorker : ITagWorker {
        private Image svgImage;

        private ISvgProcessorResult processingResult;

        /// <summary>
        /// Creates a new
        /// <see cref="SvgTagWorker"/>
        /// instance.
        /// </summary>
        /// <param name="element">the element</param>
        /// <param name="context">the context</param>
        public SvgTagWorker(IElementNode element, ProcessorContext context) {
            svgImage = null;
            try {
                SvgConverterProperties props = new SvgConverterProperties().SetBaseUri(context.GetBaseUri());
                processingResult = new DefaultSvgProcessor().Process((INode)element, props);
                context.StartProcessingInlineSvg();
            }
            catch (SvgProcessingException pe) {
                LogManager.GetLogger(typeof(iText.Html2pdf.Attach.Impl.Tags.SvgTagWorker)).Error(iText.Html2pdf.LogMessageConstant
                    .UNABLE_TO_PROCESS_IMAGE_AS_SVG, pe);
            }
        }

        public virtual void ProcessEnd(IElementNode element, ProcessorContext context) {
            if (context.GetPdfDocument() != null && processingResult != null) {
                SvgProcessingUtil util = new SvgProcessingUtil();
                svgImage = util.CreateImageFromProcessingResult(processingResult, context.GetPdfDocument());
                context.EndProcessingInlineSvg();
            }
        }

        public virtual bool ProcessContent(String content, ProcessorContext context) {
            return false;
        }

        public virtual bool ProcessTagChild(ITagWorker childTagWorker, ProcessorContext context) {
            return false;
        }

        public virtual IPropertyContainer GetElementResult() {
            return svgImage;
        }
    }
}
