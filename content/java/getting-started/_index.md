---
title: Getting Started
type: docs
weight: 10
aliases: 
   - /java/getting-started/
   - /java/getting-started-test-redirects/
---

## **Getting Started**

## **What is HTML?**
Since you are reading this page, we are assuming you know the answer. But, we are giving brief information to refresh your memory. HyperText Markup Language (HTML) is the standard markup language for creating Web pages. It defines the structure of web content. It can be assisted by other technologies such as Cascading Style Sheets (CSS) to describe a web page’s appearance/presentation and scripting languages such as JavaScript to describe functionality/behavior.
## **Benefits of using Aspose.Java**
Using Aspose.HTML for Java in your project gives you the following benefits:

- Rich set of features
- Performance and scalability
- Minimal learning curve
### **Rich set of features**
Aspose.HTML for Java is designed to process not only HTML but all the related formats: CSS, SVG, JavaScript, EPUB, MHTML. That's why it offers you a lot of features in many different areas:

- Document object model - created according to the official HTML documentation, which allows you to edit, create and remove nodes.
- Many accurate, high-performance converters. You can visit [Features List](/html/java/getting-started/features-list/) or [Converting](/html/java/converting-between-formats/) articles to see the full list of supported file formats.
- Work with CSS, JavaScript and other built-in formats.

You can learn more about all these and other features in **Features List** article.
### **Performance and scalability**
Aspose.HTML is a single file assembly, written in Java, which supports JSE 1.6 versions. It is a fast, lightweight component which creates, converts and edits {{%XHTML%}}, SVG, MHTML and EPUB documents efficiently.

Aspose.HTML for Java is multi-thread safe as long as only one thread works on a document at a time. It is a typical scenario to have one thread working on one document. Different threads can safely work on different documents at the same time.
### **Minimal learning curve**
Although there are many public classes, interfaces and enumerations in Aspose.HTML, the learning curve is minimal. We have achieved this by designing our public API with the following goals in mind:

- API defined in the official HTML, SVG and CSS documentation should be implemented as is.
- Provide a balance between easy usage and detailed customization.

By fulfilling the first goal, we have achieved that our API is similar to those used by modern browsers, which means that our API is well structured and described.

The example of fulfilling the second goal can be seen in Converter API. On the one hand, you can convert {{%XHTML%}}, EPUB, MHTML or SVG to many output formats with just one line of code.

{{< highlight java >}}

com.aspose.html.converters.Converter.convertHTML(
   "<span>Hello World!!</span>", ".",
   new com.aspose.html.saving.PdfSaveOptions(), "output.pdf");

{{< /highlight >}}

but on the other hand, you can [fine-tune the conversion process](/html/java/converting-between-formats/fine-tuning-converters/), if you want to.
## **Technical Support**
Aspose provides unlimited free technical support for all its products. The support is available to all users, including evaluation. If you need help with Aspose.HTML, consider the following:

- The main avenue for support is the [Aspose.Forums](https://forum.aspose.com/) . Post your question in the [Aspose.HTML Forum](https://forum.aspose.com/c/html/29) and it will be answered within a few hours.
- Please note, Aspose does not provide technical support over the phone. Phone support is only available for sales and purchase questions.
- When expecting a reply in the forums, please consider the time zone differences.

If you have an issue with Aspose.HTML, follow these simple steps to make sure it is resolved in the most efficient way:

- Make sure you use the latest Aspose.HTML version before reporting the issue, see [Aspose.HTML for Java Downloads](https://repository.aspose.com/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-html) to find out about the latest version.
- Have a look through the forums, this documentation and API Reference before reporting the issue; maybe your question was already answered.
- When reporting an issue, please include the original document and possibly a fragment of your code that causes the problem. If you need to attach multiple files, zip them into one.  It is safe to attach your documents in Aspose.Forums if the thread is marked/created as Private since only you and Aspose developers will have access to the attached files.
- Please try to report one issue per thread. If you have another issue, report it in a separate thread.


