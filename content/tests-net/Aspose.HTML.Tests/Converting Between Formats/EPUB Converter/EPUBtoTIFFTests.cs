﻿using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Drawing;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.HTML.Tests.Converting_Between_Formats.EPUB_Converter
{
    public class EPUBtoTIFFTests : TestsBase
    {
        public EPUBtoTIFFTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("epub-converter/epub-to-tiff");
        }


        [Fact(DisplayName = "Convert EPUB to TIFF by Two Lines")]
        public void ConvertEPUBbyTwoLinesTest()
        {
            // Open an existing EPUB file for reading.
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Invoke the ConvertEPUB method to convert the EPUB code to TIFF image           
            Converter.ConvertEPUB(stream, new ImageSaveOptions(ImageFormat.Tiff), Path.Combine(OutputDir, "convert-by-two-lines.tiff"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "convert-by-two-lines.tiff")));
        }


        [Fact(DisplayName = "Convert EPUB to TIFF")]
        public void ConvertEPUBtoTIFFTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-output.tiff");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Tiff);

            // Call the ConvertEPUB method to convert EPUB to TIFF
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-output.tiff")));
        }


        [Fact(DisplayName = "Convert EPUB to TIFF with ImageSaveOptions")]
        public void ConvertEPUBtoGTIFFWithImageSaveOptionsTest()
        {
            // Open an existing EPUB file for reading
            using var stream = File.OpenRead(DataDir + "input.epub");

            // Prepare a path for converted file saving 
            string savePath = Path.Combine(OutputDir, "input-options.tiff");

            // Initialize ImageSaveOptions 
            var options = new ImageSaveOptions(ImageFormat.Tiff)
            {
                Compression = Compression.None,
                SmoothingMode = SmoothingMode.HighQuality,
                HorizontalResolution = 400,
                VerticalResolution = 400,
                BackgroundColor = Color.AliceBlue
            };
            options.PageSetup.AnyPage = new Page(new Aspose.Html.Drawing.Size(800, 500), new Margin(30, 20, 10, 10));

            // Call the ConvertEPUB method to convert EPUB to TIFF
            Converter.ConvertEPUB(stream, options, savePath);

            Assert.True(File.Exists(Path.Combine(OutputDir, "input-options.tiff")));
        }
    }

}
