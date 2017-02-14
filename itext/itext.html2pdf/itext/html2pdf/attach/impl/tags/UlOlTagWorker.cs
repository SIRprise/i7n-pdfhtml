/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2017 iText Group NV
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
    address: sales@itextpdf.com */
using System;
using iText.Html2pdf.Attach;
using iText.Html2pdf.Attach.Util;
using iText.Html2pdf.Css;
using iText.Html2pdf.Html.Node;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace iText.Html2pdf.Attach.Impl.Tags {
    public class UlOlTagWorker : ITagWorker {
        private List list;

        private WaitingInlineElementsHelper inlineHelper;

        public UlOlTagWorker(IElementNode element, ProcessorContext context) {
            list = new List().SetListSymbol("");
            inlineHelper = new WaitingInlineElementsHelper(element.GetStyles().Get(CssConstants.WHITE_SPACE), element.
                GetStyles().Get(CssConstants.TEXT_TRANSFORM));
        }

        public virtual void ProcessEnd(IElementNode element, ProcessorContext context) {
            ProcessUnlabeledListItem();
        }

        public virtual bool ProcessContent(String content, ProcessorContext context) {
            inlineHelper.Add(content);
            return true;
        }

        public virtual bool ProcessTagChild(ITagWorker childTagWorker, ProcessorContext context) {
            IPropertyContainer child = childTagWorker.GetElementResult();
            if (childTagWorker is SpanTagWorker) {
                bool allChildrenProcessed = true;
                foreach (IPropertyContainer propertyContainer in ((SpanTagWorker)childTagWorker).GetAllElements()) {
                    if (propertyContainer is ILeafElement) {
                        inlineHelper.Add((ILeafElement)propertyContainer);
                    }
                    else {
                        allChildrenProcessed = AddBlockChild(propertyContainer) && allChildrenProcessed;
                    }
                }
                return allChildrenProcessed;
            }
            else {
                return AddBlockChild(child);
            }
        }

        public virtual IPropertyContainer GetElementResult() {
            return list;
        }

        private void ProcessUnlabeledListItem() {
            Paragraph p = inlineHelper.CreateParagraphContainer();
            inlineHelper.FlushHangingLeaves(p);
            if (p.GetChildren().Count > 0) {
                AddUnlabeledListItem(p);
            }
        }

        private void AddUnlabeledListItem(IBlockElement item) {
            ListItem li = new ListItem();
            li.Add(item);
            li.SetProperty(Property.LIST_SYMBOL, null);
            list.Add(li);
        }

        private bool AddBlockChild(IPropertyContainer child) {
            ProcessUnlabeledListItem();
            if (child is ListItem) {
                list.Add((ListItem)child);
                return true;
            }
            else {
                if (child is IBlockElement) {
                    AddUnlabeledListItem((IBlockElement)child);
                    return true;
                }
            }
            return false;
        }
    }
}
