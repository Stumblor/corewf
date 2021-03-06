// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace Test.Common.TestObjects.XmlDiff
{
    [Flags]
    public enum XmlDiffOption
    {
        None = 0x0,
        IgnoreEmptyElement = 0x1,
        IgnoreWhitespace = 0x2,
        IgnoreComments = 0x4,
        IgnoreAttributeOrder = 0x8,
        IgnoreNS = 0x10,
        IgnorePrefix = 0x20,
        IgnoreDTD = 0x40,
        IgnoreChildOrder = 0x80,
        InfosetComparison = 0xB, //sets IgnoreEmptyElement, IgnoreWhitespace and IgnoreAttributeOrder
        CDataAsText = 0x100,
        NormalizeNewline = 0x200, // ignores newlines in text nodes only
        ConcatenateAdjacentTextNodes = 0x400, // treats adjacent text nodes as a single node
        TreatWhitespaceTextAsWSNode = 0x800, // if a text node contains only whitespaces, it will be considered a whitespace node
        ParseAttributeValuesAsQName = 0x1000, // <a xmlns:p1="n1" t="p1:foo"/> will be treated the same as <a xmlns:p2="n1" t="p2:foo"/>
        DontWriteMatchingNodesToOutput = 0x2000, // output will only contain different nodes
        DontWriteAnythingToOutput = 0x4000, // output will not contain anything (needed for very large XML docs, which could trigger OOM)
        IgnoreEmptyTextNodes = 0x8000, // empty text nodes (sometimes produced by the binary reader) are ignored
        WhitespaceAsText = 0x10000, // consider whitespace nodes as text nodes
    }

    public class XmlDiffAdvancedOptions
    {
        private string _ignoreNodesExpr;
        private string _ignoreValuesExpr;
        private string _ignoreChildOrderExpr;
        private XmlNamespaceManager _mngr;

        public XmlDiffAdvancedOptions()
        {
        }
        public string IgnoreNodesExpr
        {
            get
            {
                return _ignoreNodesExpr;
            }
            set
            {
                _ignoreNodesExpr = value;
            }
        }
        public string IgnoreValuesExpr
        {
            get
            {
                return _ignoreValuesExpr;
            }
            set
            {
                _ignoreValuesExpr = value;
            }
        }
        public string IgnoreChildOrderExpr
        {
            get
            {
                return _ignoreChildOrderExpr;
            }
            set
            {
                _ignoreChildOrderExpr = value;
            }
        }
        public XmlNamespaceManager Context
        {
            get
            {
                return _mngr;
            }
            set
            {
                _mngr = value;
            }
        }
    }
}
