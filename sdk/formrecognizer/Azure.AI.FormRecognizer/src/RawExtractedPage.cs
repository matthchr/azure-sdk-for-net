﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public class RawExtractedPage
    {
        internal RawExtractedPage(ReadResult_internal readResult)
        {
            Page = readResult.Page;
            TextAngle = readResult.Angle;
            Width = readResult.Width;
            Height = readResult.Height;
            Unit = readResult.Unit;

            if (readResult.Lines != null)
            {
                Lines = ConvertLines(readResult.Lines, Page);
            }
        }

        /// <summary> The 1-based page number in the input document. </summary>
        public int Page { get; set; }

        /// <summary> The general orientation of the text in clockwise direction, measured in degrees between (-180, 180]. </summary>
        public float TextAngle { get; set; }

        /// <summary> The width of the image/PDF in pixels/inches, respectively. </summary>
        public float Width { get; set; }

        /// <summary> The height of the image/PDF in pixels/inches, respectively. </summary>
        public float Height { get; set; }

        /// <summary> The unit used by the width, height and boundingBox properties. For images, the unit is &quot;pixel&quot;. For PDF, the unit is &quot;inch&quot;. </summary>
        public LengthUnit Unit { get; set; }

        /// <summary> When includeTextDetails is set to true, a list of recognized text lines. The maximum number of lines returned is 300 per page. The lines are sorted top to bottom, left to right, although in certain cases proximity is treated with higher priority. As the sorting order depends on the detected text, it may change across images and OCR version updates. Thus, business logic should be built upon the actual line location instead of order. </summary>
        public ICollection<RawExtractedLine> Lines { get; set; }

        private static ICollection<RawExtractedLine> ConvertLines(IReadOnlyList<TextLine_internal> textLines, int pageNumber)
        {
            List<RawExtractedLine> rawLines = new List<RawExtractedLine>();

            foreach (TextLine_internal textLine in textLines)
            {
                rawLines.Add(new RawExtractedLine(textLine, pageNumber));
            }

            return rawLines;
        }
    }
}
