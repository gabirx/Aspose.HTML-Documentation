---
title: MHTML to XPS Conversion
type: docs
weight: 140
aliases: /java/mhtml-to-xps-conversion/
---

In this article, you will find information on how to convert an {{%MHTML%}} to {{%XPS%}} and how to use [XpsSaveOptions](https://apireference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) and [MemoryStreamProvider](https://apireference.aspose.com/html/java/com.aspose.html/package-frame) parameters.

{{% alert color="primary" %}} 

<https://products.aspose.app/html/en/conversion/mhtml-to-xps>

{{% /alert %}} 

The static methods of the [Converter](https://apireference.aspose.com/html/java/com.aspose.html.converters/converter) class are primarily used as the easiest way to convert an {{%MHTML%}} code into various formats. You can convert {{%MHTML%}} to {{%XPS%}} in your Java application literally with a single line of code!

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertMHTMLToXPS_WithASingleLine.java" >}}

The following Java code snippet shows how to convert MHTML to {{%XPS%}} using Aspose.HTML for Java.

1. Open an existing MHTML file;
1. Create an instance of [XpsSaveOptions](https://apireference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions);
1. Use the `Converter.convertMHTML` method of [Converter](https://apireference.aspose.com/html/java/com.aspose.html.converters/converter) class to save MHTML as a {{%XPS%}} file. You need to pass the MHTML file stream, [XpsSaveOptions](https://apireference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions), and output file path to the `Converter.convertMHTML` method to convert MHTML to {{%XPS%}} .

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertMHTMLToXPS_ConvertMHTMLFileToXPS.java" >}}
## **Save Options** ## 
[XpsSaveOptions](https://apireference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) allows you to customize the rendering process. You can specify the [page size](https://apireference.aspose.com/html/java/com.aspose.html.rendering/RenderingOptions#getPageSetup--), [margins](https://apireference.aspose.com/html/java/com.aspose.html.drawing/Page#getMargin--), [CSS media-type](https://apireference.aspose.com/html/java/com.aspose.html.rendering/MediaType), etc. The following example shows how to use [XpsSaveOptions](https://apireference.aspose.com/html/java/com.aspose.html.saving/xpssaveoptions) *and* create an {{%XPS%}} file with custom page-size and background color:

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertMHTMLToPDF_SpecifyPdfSaveOptions.java" >}}

To learn more about [XpsSaveOptions](https://apireference.aspose.com/html/java/aspose.html.saving/xpssaveoptions) please read [Fine-Tuning Converters](/html/java/converting-between-formats/fine-tuning-converters/) article.
## **Output Stream Providers** ## 
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [MemoryStreamProvider](https://apireference.aspose.com/html/java/com.aspose.html/package-frame) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

Aspose.HTML for Java provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, {{%XPS%}}), others create multiple files (Image formats JPG, PNG, etc.).

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "MemoryStreamProvider.java" >}}

{{< gist "aspose-com-gists" "b2199f957c72708d4d2b0de93bca3098" "Examples_Java_ConvertingBetweenFormats_ConvertMHTMLToPDF_SpecifyCustomStreamProvider.java" >}}
