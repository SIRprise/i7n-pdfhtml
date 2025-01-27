/*
This file is part of the iText (R) project.
Copyright (c) 1998-2019 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

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

namespace iText.Html2pdf {
    /// <summary>Class that bundles all the error message templates as constants.</summary>
    public sealed class LogMessageConstant {
        /// <summary>The Constant ACROFORM_NOT_SUPPORTED_FOR_SELECT.</summary>
        public const String ACROFORM_NOT_SUPPORTED_FOR_SELECT = "AcroForm fields creation for select fields (ComboBoxField and ListBoxField) is not supported. They will be flattened instead.";

        public const String ANCHOR_LINK_NOT_HANDLED = "The anchor link was not handled. Could not create a destination for element \"{0}\" with ID \"{1}\", which is processed by \"{2}\" tag worker class.";

        /// <summary>The Constant CONTENT_PROPERTY_INVALID.</summary>
        public const String CONTENT_PROPERTY_INVALID = "Content property \"{0}\" is either invalid or uses unsupported function.";

        /// <summary>The Constant CSS_PROPERTY_IN_PERCENTS_NOT_SUPPORTED.</summary>
        public const String CSS_PROPERTY_IN_PERCENTS_NOT_SUPPORTED = "Css property {0} in percents is not supported";

        public const String DEFAULT_VALUE_OF_CSS_PROPERTY_UNKNOWN = "Default value of the css property \"{0}\" is unknown.";

        /// <summary>The Constant ERROR_LOADING_FONT.</summary>
        public const String ERROR_LOADING_FONT = "Error while loading font";

        /// <summary>The Constant ERROR_PARSING_CSS_SELECTOR.</summary>
        public const String ERROR_PARSING_CSS_SELECTOR = "Error while parsing css selector: {0}";

        /// <summary>The Constant ERROR_RESOLVING_PARENT_STYLES.</summary>
        public const String ERROR_RESOLVING_PARENT_STYLES = "Element parent styles are not resolved. Styles for current element might be incorrect.";

        /// <summary>The Constant ERROR_WHILE_LAYOUT_OF_FORM_FIELD.</summary>
        public const String ERROR_WHILE_LAYOUT_OF_FORM_FIELD = "Cannot layout form field field. It won't be displayed";

        /// <summary>The Constant ERROR_WHILE_LAYOUT_OF_FORM_FIELD_WITH_TYPE.</summary>
        public const String ERROR_WHILE_LAYOUT_OF_FORM_FIELD_WITH_TYPE = "Error during layout of form filed with type {0}.";

        /// <summary>The Constant HEIGHT_VALUE_IN_PERCENT_NOT_SUPPORTED.</summary>
        [Obsolete]
        public const String HEIGHT_VALUE_IN_PERCENT_NOT_SUPPORTED = "Height value in percent not supported";

        /// <summary>The Constant INPUT_FIELD_DOES_NOT_FIT.</summary>
        public const String INPUT_FIELD_DOES_NOT_FIT = "Input field doesn't fit in outer object. It will be clipped";

        /// <summary>The Constant INPUT_SUPPORTS_ONLY_POINT_WIDTH.</summary>
        [Obsolete]
        public const String INPUT_SUPPORTS_ONLY_POINT_WIDTH = "Input field supports only point width";

        /// <summary>The Constant INPUT_TYPE_IS_INVALID.</summary>
        public const String INPUT_TYPE_IS_INVALID = "Input type {0} is invalid. The default text type will be used instead.";

        /// <summary>The Constant INPUT_TYPE_IS_NOT_SUPPORTED.</summary>
        public const String INPUT_TYPE_IS_NOT_SUPPORTED = "Input type {0} is not supported";

        /// <summary>The Constant INVALID_CSS_PROPERTY_DECLARATION.</summary>
        public const String INVALID_CSS_PROPERTY_DECLARATION = "Invalid css property declaration: {0}";

        /// <summary>The Constant MARGIN_VALUE_IN_PERCENT_NOT_SUPPORTED.</summary>
        public const String MARGIN_VALUE_IN_PERCENT_NOT_SUPPORTED = "Margin value in percents not supported";

        /// <summary>The Constant NOT_SUPPORTED_LIST_STYLE_TYPE.</summary>
        public const String NOT_SUPPORTED_LIST_STYLE_TYPE = "Not supported list style type: {0}";

        /// <summary>The Constant NOT_SUPPORTED_TH_SCOPE_TYPE.</summary>
        public const String NOT_SUPPORTED_TH_SCOPE_TYPE = "Not supported th scope type: {0}. Document may not be compliant with PDF/UA standards.";

        /// <summary>The Constant NO_CONSUMER_FOUND_FOR_CONTENT.</summary>
        public const String NO_CONSUMER_FOUND_FOR_CONTENT = "No consumer found for content";

        /// <summary>The Constant NO_CSS_APPLIER_FOUND_FOR_TAG.</summary>
        public const String NO_CSS_APPLIER_FOUND_FOR_TAG = "No css applier found for tag {0}";

        /// <summary>The Constant NO_IPROPERTYCONTAINER_RESULT_FOR_THE_TAG.</summary>
        public const String NO_IPROPERTYCONTAINER_RESULT_FOR_THE_TAG = "Tag worker does not produce IPropertyContainer for \"{0}\" tag. An outline for \"{0}\" tag will not be created.";

        /// <summary>The Constant NO_WORKER_FOUND_FOR_TAG.</summary>
        public const String NO_WORKER_FOUND_FOR_TAG = "No worker found for tag {0}";

        /// <summary>The Constant PADDING_VALUE_IN_PERCENT_NOT_SUPPORTED.</summary>
        public const String PADDING_VALUE_IN_PERCENT_NOT_SUPPORTED = "Padding value in percents not supported";

        public const String PAGE_MARGIN_BOX_CONTENT_CANNOT_BE_DRAWN = "Page margin box {0} content cannot be drawn.";

        public const String PAGE_MARGIN_BOX_SOME_PROPERTIES_NOT_PROCESSED = "Page margin box margin, padding, height and width properties are not processed. Passed styles container shall be of PageMarginBoxContextNode type.";

        /// <summary>The Constant PAGE_SIZE_VALUE_IS_INVALID.</summary>
        public const String PAGE_SIZE_VALUE_IS_INVALID = "Page size value {0} is invalid.";

        /// <summary>The Constant PDF_DOCUMENT_NOT_PRESENT</summary>
        public const String PDF_DOCUMENT_NOT_PRESENT = "PdfDocument is not present";

        /// <summary>The Constant QUOTES_PROPERTY_INVALID.</summary>
        public const String QUOTES_PROPERTY_INVALID = "Quote property \"{0}\" is invalid. It should contain even number of <string> values.";

        /// <summary>The Constant RULE_IS_NOT_SUPPORTED.</summary>
        public const String RULE_IS_NOT_SUPPORTED = "The rule @{0} is unsupported. All selectors in this rule will be ignored.";

        /// <summary>The Constant TEXT_DECORATION_BLINK_NOT_SUPPORTED.</summary>
        public const String TEXT_DECORATION_BLINK_NOT_SUPPORTED = "text-decoration: blink not supported";

        /// <summary>The Constant TEXT_WAS_NOT_PROCESSED.</summary>
        [Obsolete]
        public const String TEXT_WAS_NOT_PROCESSED = "Text was not processed: {0}";

        /// <summary>The Constant UNABLE_TO_PROCESS_EXTERNAL_CSS_FILE.</summary>
        public const String UNABLE_TO_PROCESS_EXTERNAL_CSS_FILE = "Unable to process external css file";

        /// <summary>The Constant UNABLE_TO_PROCESS_IMAGE_AS_SVG</summary>
        public const String UNABLE_TO_PROCESS_IMAGE_AS_SVG = "Unable to process image found at {0} as an SVG";

        /// <summary>The Constant UNABLE_TO_RESOLVE_COUNTER.</summary>
        public const String UNABLE_TO_RESOLVE_COUNTER = "Unable to resolve counter \"{0}\"";

        /// <summary>The Constant UNABLE_TO_RESOLVE_FONT.</summary>
        [Obsolete]
        public const String UNABLE_TO_RESOLVE_FONT = "Unable to resolve font: {0}. The default one will be used instead";

        /// <summary>The Constant UNABLE_TO_RETRIEVE_FONT.</summary>
        public const String UNABLE_TO_RETRIEVE_FONT = "Unable to retrieve font:\n {0}";

        /// <summary>The Constant UNABLE_TO_RETRIEVE_IMAGE_WITH_GIVEN_BASE_URI.</summary>
        public const String UNABLE_TO_RETRIEVE_IMAGE_WITH_GIVEN_BASE_URI = "Unable to retrieve image with given base URI ({0}) and image source path ({1})";

        /// <summary>The Constant UNABLE_TO_RETRIEVE_STREAM_WITH_GIVEN_BASE_URI.</summary>
        public const String UNABLE_TO_RETRIEVE_STREAM_WITH_GIVEN_BASE_URI = "Unable to retrieve stream with given base URI ({0}) and source path ({1})";

        /// <summary>The Constant UNKNOWN_MARGIN_BOX_CHILD.</summary>
        public const String UNKNOWN_MARGIN_BOX_CHILD = "Unknown margin box child";

        /// <summary>The Constant WORKER_UNABLE_TO_PROCESS_IT_S_TEXT_CONTENT.</summary>
        public const String WORKER_UNABLE_TO_PROCESS_IT_S_TEXT_CONTENT = "Worker of type {0} unable to process it`s text content";

        /// <summary>The Constant WORKER_UNABLE_TO_PROCESS_OTHER_WORKER.</summary>
        public const String WORKER_UNABLE_TO_PROCESS_OTHER_WORKER = "Worker of type {0} unable to process {1}";

        private LogMessageConstant() {
        }
    }
}
