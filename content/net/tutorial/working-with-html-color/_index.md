---
title: Working with HTML Color | Background Color and Text Color 
linktitle: Working with HTML Color
type: docs
weight: 20
description: In this article, you  will find information about HTML color codes for your website - HTML color names with hex color codes, RGB, RGBA, HSL and HSLA values.
keywords: html colors, color names, hex color, rgb color, background color, text color, border color, color values, color codes, html style, html style tag
lastmod: "2022-03-17"
sitemap:
    changefreq: "weekly"
    priority: 0.7
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

## **How to Use HTML Color**

Design is not a central feature of HTML, so, there is no special HTML color tag.  However, you can change the color of any text using the following ways:
1. **Using inline `style` attribute.** Adding color to a web page is a part of inline CSS styling. To set the text or background color in HTML you need to use the `style` attribute. You can apply the `style` attribute with the HTML `<body>`, `<p>`,  `<table>`, `<div>`, `<h1>` or `<h2>`  tags and etc. Keep in mind, that the usage of a style attribute overrides any style set in the HTML `<style>` tag or external style sheet.

2. **Using internal CSS.** The internal CSS styling option is popular for applying properties to individual pages by encasing all styles in the `<style>`  element placed it in the `<head>` of HTML documents.

{{% alert color="primary" %}} 
For more information on how to use HTML color codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.

If you want to change text, background, or border color in an HTML file programmatically, please visit the [**How-to Articles**](https://docs.aspose.com/html/net/how-to-articles/) chapter. The articles in this chapter answer popular questions and contain C# examples that provide the necessary information about using the Aspose.HTML class library to solve specific tasks.
{{% /alert %}}

## **Text Color**

You can use the inline  `style` attribute or the `<style>`  element to change the text color and then set the value using the `color` property. The `color` property sets the foreground color value for an element's text and text decoration. The `color` property accepts color names, RGB, RGBA, HEX, HSL, or HSLA values.

### **Text Color Using HTML Color Names**

The color name depicts the specific name for the HTML color. Modern browsers support <a href="https://www.w3.org/TR/css-color-4/#named-colors" rel='noopener nofollow' target="_blank">140+ HTML color names</a>, and you can use any of them for your elements. For example, you can colorize text using inline `style` attribute as shown in the following example:

```html
<html>
	<body>
		<h2 style="color:DarkCyan;">How to set text color using HTML color names?</h2>
		<h3 style="color:DarkRed;">Add a style attribute to the text element you want to colorize and use the color name to specify the color.</h3>
        <h4 style="color:DarkBlue;">There are over 140 named colors to choose from that you can use.</h4>
	</body>
</html>
```

The same text colorization result can be achieved using internal CSS, as shown in the following example:

```html
<html>
<head>  
<style>  
h2 {  
	color:DarkCyan;  
}  
h3 {  
	color:DarkRed;  
} 
h4 {
	color:DarkBlue;
}
</style>  
</head> 
	<body>
		<h2>How to set text color using HTML color names?</h2>
		<h3>Add a style attribute to the text element you want to colorize and use the color name to specify the color.</h3>
        <h4>There are over 140 named colors to choose from that you can use.</h4>
	</body>
</html>
```

The rendered HTML code looks as follows:

![Text "The image renders the html code above"](text-color.png#center)

{{% alert color="primary" %}} 
You can learn more about applying inline, internal and external CSS and editing them using Aspose.HTML API from the [**Edit CSS**](https://docs.aspose.com/html/net/working-with-documents/editing-a-document/#edit-css) section. C# examples of how to change text color using Aspose.HTML API you can find in the article [**How to Change Text Color in HTML**](/html/net/how-to-articles/how-to-change-text-color/).
{{% /alert %}} 

### **Text color using RGB, RGBA or HEX color codes**

For coloring HTML text, you can use RGB or HEX that are the most used color codes. The RGB value determines the HTML color by mixing red, green, and blue values. The HEX color value works almost the same as RGB but looks different. If you want to know more about RGB, RGBA and HEX codes, please visit the [**HTML Color Codes**](https://docs.aspose.com/html/net/tutorial/html-colors/) article.

Using RGB or HEX color codes is the most common way to add color to web pages. It is necessary to add a `style` attribute to the text element you want to color. In the example below, we use the `<h2>` and `<h3>` elements to apply the inline  `style` attribute and  `color` property with RGB, RGBA and HEX codes:

```html
<html>
	<body>
		<h2 style="color:rgb(50,150,200);">How to use Text Color?</h2>
		<h3 style="color:rgba(220,30,100,1);"> 1. To colorize HTML text, add a style attribute to the text element you want to color.</h3>
        <h3 style="color:#1A8D7E"> 2. Apply the color property to specify the color using RGB, RGBA or HEX code.</h3>
	</body>
</html>
```

 The rendered HTML code is as follows:

![Text "The image renders the html code for setting text color using HEX or RGB color codes"](text-color-hex-rgb.png#center)

### **Text color using HSL or HSLA color codes**

HSL(hue, saturation, lightness) is a representation of the RGB color model in cylindrical coordinates. Hue defines the basic color and measures it in degrees from 0 to 360 on the RGB color wheel. Saturation is the intensity or purity of a color, and it is defined in percentages from 0 (black and white) to 100 (vivid color). Lightness is the amount of brightness or light in color. It is defined in percentages from 0 (black) to 100 (white).

HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. The HSLA color value is specified with hue, saturation, lightness, and alpha, where the alpha parameter specifies the opacity. The alpha parameter is a number between 0.0, meaning "fully transparent", and 1.0, meaning "fully opaque".

Using the same `style` attribute like before, replace the RGB/RGBA/HEX code or color name with an HSL or HSLA value in `color` property:

```html
<html>
	<body>
		<h2 style="color:hsl(200,100%,40%);">HSL and HSLA color codes</h2>
		<p  style="color:hsla(200,100%,40%,0.9); font-size:18px;">HSL(hue, saturation, lightness) is a representation of the RGB color model in cylindrical coordinates.</p>
		<p  style="color:hsla(200,100%,40%,0.6); font-size:18px;">HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color.</p>       
	</body>
</html>
```

The rendered HTML code looks as follows:

![Text "The image renders the html code for setting text color using HSL and HSLA color codes"](text-color-hsl-hsla.png#center)

  

 ## **Background Color**

### **Background Color for Specific HTML Element**

You can use the `style` attribute to specify the background color for the HTML element and then set the value using the `background-color` property. The `background-color` property accepts color names, RGB, RGBA, HEX, HSL, or HSLA values.

Determine which element you want to change the background color for. If it's a paragraph, look for the `<p>` opening tag. It can also be an `<h1`>...`<h6>`, `<div>` or `<table>` tag. In this example, we are adding a background color to the` <h2> `elements:

```html
<html>
	<body>
		<p>The color name is "YellowGreen":</p>
		<h2 style="background-color:rgb(154, 205, 50);">rgb(154, 205, 50)</h2>
		<h2 style="background-color:#9ACD32;">#9ACD32</h1>
		<h2 style="background-color:hsl(80, 61%, 50%);">hsl(80, 61%, 50%)</h2>

		<p>RGBA values of name "YellowGreen" color, with different transparent:</p>
		<h2 style="background-color:rgba(154, 205, 50, 0.2);">rgba(154, 205, 50, 0.2)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 0.5);">rgba(154, 205, 50, 0.5)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 0.8);">rgba(154, 205, 50, 0.8)</h2>

		<p>HSLA values of name "YellowGreen" color, with different transparent:</p>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.2);">hsla(80, 61%, 50%, 0.2)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.5);">hsla(80, 61%, 50%, 0.5)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 0.8);">hsla(80, 61%, 50%, 0.8)</h2>
	</body>
</html>
```



The rendered HTML code looks as follows:

![Text "The image renders the html code for setting background color using HEX, RGB, RGBA, HSL and HSLA color codes"](background-color.png#center)

### **Background Color for the Entire Web Page**
It's important to note that in the example above, the `background-color` property provides a color for the background of the text, but not for the whole document. If you wish to change the HTML color for the whole page, you should use the `background-color` property of the `style` attribute in the opening tag of the `<body>` section:
```html
<html>
	<body style="background-color:#e0e0e0">
		<h2 style="background-color:YellowGreen;">YellowGreen</h2>
		<h2 style="background-color:rgb(154, 205, 50);">rgb(154, 205, 50)</h2>
		<h2 style="background-color:rgba(154, 205, 50, 1.0);">rgba(154, 205, 50, 1.0)</h2>
		<h2 style="background-color:#9ACD32;">#9ACD32</h2>
		<h2 style="background-color:hsl(80, 61%, 50%);">hsl(80, 61%, 50%)</h2>
		<h2 style="background-color:hsla(80, 61%, 50%, 1.0);">hsla(80, 61%, 50%, 1.0)</h2>
	</body>
</html>
```
The image renders the HTML code for setting the background color for the text (YellowGreen color name is specified in different color codes) and the whole web page.

![Text "The image renders the html code for setting background color for both the text and the whole web page."](background-color-body.png#center)

One more example to achieve the effect of colorizing the background for the whole web page by using the `style` attribute with the `background-color` property in the opening tag of the `<body>` section:
```html
<html>
	<body style="background-color:#ffe0e0;">
		<h2>How to set Background Color for the whole web page?</h2>
		<p>Add the style attribute to the body section and apply the background-color property to specify a color using color name, RGB, HEX or HSL code.</p>
	</body>
</html>
```
![Text "The image renders the html code for setting background color for the whole web page."](background-color-body1.png#center)

 ## **Border Color**

You can use the `style` attribute with the `border-style`  and  `border-color` properties to specify the border color for the text elements. CSS `border-color` property defines the color of the four borders of element. The `border-color` property will only work when the `border-style` property is defined first, which is used to set the borders. This property will not work alone. If this property is not set, it inherits the element's colour. The `border-color` property accepts color names, RGB, RGBA, HEX, HSL, or HSLA values.
```html
<html>
	<body>
		<p> The border-color property only works when the border-style property is defined first, which is used to set the borders.</p>	
		<h2 style="color:rgb(50,150,200); border-style:solid;  border-color:rgb(220,30,100);">How to define border color?</h2>
		<p> If the border-style property is defined and the border-color property is not set, the border inherits the element's color.</p>
		<h2 style="color:rgb(50,150,200); border-style:solid;">How to define border color?</h2>
	</body>
</html>
```
![Text "The image renders the html code for setting border color for the text. "](border-color.png#center)

{{% alert color="primary" %}} 
Aspose.HTML offers a free online <a href="https://products.aspose.app/html/color-wheel" target="_blank">**Color Wheel Picker**</a>  that allows you to create a set of colors in the HEX color code. You can use this free online application to find color harmonies by using the rules of color combinations, but also it is essential to experiment with color. Color Wheel Picker suggests an excellent way to experiment with color and create exciting color combinations independently. The application runs for computers, tablets and mobile devices. So make your unique palette for any project! 
{{% /alert %}} 

<a href="https://products.aspose.app/html/color-wheel" target="_blank">![Text "Banner Color Wheel Picker"](../color-wheel-picker.png#center)</a> 







