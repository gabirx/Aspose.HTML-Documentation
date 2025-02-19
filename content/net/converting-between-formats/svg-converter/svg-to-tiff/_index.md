---
title: Convert SVG to TIFF | C#
linktitle: Convert SVG to TIFF
keywords: svg to tiff, convert svg to tiff, svg to tiff conversion, svg to tiff converter
description: This article provides information on how to convert SVG to TIFF
  using the Aspose.HTML API. You will learn about the supported SVG to TIFF
  conversion scenarios and consider examples to illustrate them.
weight: 60
type: docs
url: /net/converting-between-formats/svg-to-tiff/
lastmod: 2022-01-11
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

With Aspose.HTML, you can convert SVG to TIFF format programmatically with full control over a wide range of conversion parameters. In this article, you find information on how to convert SVG to {{%TIFF%}} by using [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters/converter/methods/convertsvg/index) methods of the Converter class and applying  [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions).

{{% alert color="primary" %}}
Aspose.HTML offers a free online <a href="https://products.aspose.app/svg/conversion/svg-to-tiff" target="_blank">**SVG to TIFF Converter**</a> that converts SVG to TIFF image with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-tiff" target="_blank">![Text "Banner SVG to TIFF Converter"](svg-to-tiff.png#center)</a>

## **SVG to TIFF by a single line of code**

The static methods of the [Converter](https://apireference.aspose.com/html/net/aspose.html.converters/converter) class are primarily used as the easiest way to convert an SVG file into various formats. You can convert SVG to TIFF in your C# application literally with a single line of code!

In the following example, we take an SVG file in a local file system ([shapes.svg](/html/net/converting-between-formats/svg-to-jpg/shapes.svg)), convert and save it in the local file system.

{{< highlight java >}}
using System.IO;

using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
     // Invoke the ConvertSVG method for SVG to TIFF conversion          
     Converter.ConvertSVG(Path.Combine(DataDir, "shapes.svg"), new ImageSaveOptions(ImageFormat.Tiff), Path.Combine(OutputDir, "convert-with-single-line.tiff"));
{{< /highlight >}}

## **Convert SVG to TIFF**
Converting a file to another format using the ConvertSVG() method is a sequence of operations among which document loading and saving. In the following example, we create an SVG file from code. 

1. Prepare code for an SVG document.
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG(`content`, `baseUri`, `options`, `outputPath`)](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/51) method of the Converter class to save SVG as a TIFF image. 

Please take a look over the following C# code snippet which shows the process of converting SVG to TIFF using Aspose.HTML for .NET.

{{< highlight java >}}
using System.IO;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
...
    // Prepare SVG code 
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx ='100' cy ='100' r ='50' fill='none' stroke='red' stroke-width='10' />" +
               "</svg>";

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "circle.tiff");
    
    // Initialize ImageSaveOptions 
    var options = new ImageSaveOptions(ImageFormat.Tiff);
    
    // Convert SVG to TIFF
    Converter.ConvertSVG(code, ".", options, savePath);
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).
{{% /alert %}}

### **Free App**
You can convert SVG to TIFF with Aspose.HTML API in real time. First, load an SVG file from your local drive and then run the example. In this example, the save options are set by default. You will immediately receive the result as a separate TIFF file.

{{< svg-converter SVG TIFF  >}}
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;

   using var document = new SVGDocument("input.svg");
   var options = new ImageSaveOptions(ImageFormat.Tiff);
   Converter.ConvertSVG(document, options, "output.tiff");    
{{< /svg-converter >}}

## **Convert SVG to TIFF using ImageSaveOptions**

To convert SVG to TIFF with ImageSaveOptions specifying, you should follow a few steps: 

1. Load an SVG file using one of the SVGDocument() constructors of the [SVGDocument](https://apireference.aspose.com/html/net/aspose.html.dom.svg/svgdocument) class. ([gradient.svg](/net/converting-between-formats/svg-to-gif/gradient.svg)). 
1. Create a new [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions) object with TIFF ImageFormat and specify save options. By default, the Format property is [PNG](https://apireference.aspose.com/html/net/aspose.html.rendering.image/imageformat).
1. Use the [ConvertSVG()](https://apireference.aspose.com/html/net/aspose.html.converters.converter/convertsvg/methods/3) method to save SVG as a TIFF image. You need to pass the SVGDocument, ImageSaveOptions, and output file path to the ConvertSVG() method to convert SVG to TIFF.

The following C# code snippet shows how to convert SVG to TIFF using custom save options:

{{< highlight java >}}
using System.IO;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;
using System.Drawing;
...
    // Prepare a path to a source SVG file
    string documentPath = Path.Combine(DataDir, "gradient.svg");

    // Prepare a path for converted file saving 
    string savePath = Path.Combine(OutputDir, "gradient-options.tiff");
    
    // Initialize an SVG document from the file
    using var document = new SVGDocument(documentPath);
    
    // Initialize ImageSaveOptions. Set up the compression, resolutions, and change the background color to AliceBlue 
    var options = new ImageSaveOptions(ImageFormat.Tiff)
    {
        Compression = Compression.None,
        HorizontalResolution = 200,
        VerticalResolution = 200,
        BackgroundColor = Color.AliceBlue                
    };
    
    // Convert SVG to TIFF
    Converter.ConvertSVG(document, options, savePath);
{{< /highlight >}}

The [ImageSaveOptions()](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions class that is passed to ConvertSVG() method. The ConvertSVG() method takes the `document`, `options`,  output file path `savePath` and performs the conversion operation.

In the example, we use:
 - Compression property that sets TIFF compression. We use None compression schema. By default, this property is [LZW](https://apireference.aspose.com/html/net/aspose.html.rendering.image/compression).
 - BackgroundColor property that sets the color that will fill the background. The default BackgroundColor is Transparent.
 - HorizontalResolution and VerticalResolution properties that set horizontal/vertical resolution for output images in pixels per inch. By default, these properties are 300 dpi.

The ImageSaveOptions class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to Image formats. Among these properties, the Compression that enables you to set a compression value for TIFF images.  Available values are LVZ, CCITT3, CCITT4, Rle, and None. To learn more about [ImageSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/imagesaveoptions), please read the [Fine-Tuning Converters](/html/net/converting-between-formats/fine-tuning-converters/) article.



The figure illustrates the fragment of the gradient-options.tiff file.

![Text "gradient-options image"](../gradient-options.png#center)



{{% alert color="primary" %}} 

Check the quality of SVG to TIFF conversion with our online [**SVG to TIFF Converter**](https://products.aspose.app/svg/conversion/svg-to-tiff). Upload, convert your files and get results in a few seconds. Try our forceful SVG to TIFF Converter for free now!

You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-html/Aspose.HTML-Documentation/tree/main/content/tests-net).

{{% /alert %}}







