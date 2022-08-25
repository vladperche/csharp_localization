# csharp_localization
Example with CSharp for Localization Resources

# Getting started
At first, just create a Resource Class, and insert some text.
If you have a Solution with multiple projetcs, put this class in a shared projetc.
In this case, just remember to change the Class to Public.

## Example

**Messages.resx**
WELCOME|Welcome!
--|--
GOOD_MORNING|Goog morning!
GOOD_EVENING|Good evening!
GOOD_NIGHT|Good night!

# Translations
Then, create a file for each Language you need, with the same name, plus the languague code, and use the same Keys that are in the original file

## Examples

**Messages.pt.resx** (for Portuguese translation)
WELCOME|Bem vindo!
--|--
GOOD_MORNING|Bom dia!
GOOD_EVENING|Boa tarde!
GOOD_NIGHT|Boa noite!

**Messages.de.resx** (for German translation)
WELCOME|Willkomen!
--|--
GOOD_MORNING|Guten Morgen!
GOOD_EVENING|Guten Abend!
GOOD_NIGHT|Gute Nacht!

# Using translations
Don't worry, just refer the texts in the class/keys.

## Example

```
	Console.WriteLine(Messages.GOOD_MORNING);
```

The text will be replaced by the System's default languague.
If it runs on different users configurations, the correct file will be selected.

To _force_ a different languague to be used, just use the following command:

```
	Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("culture_name");
```

