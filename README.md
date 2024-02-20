# RiderFSharpIssue

This project illustrates an issue with Rider and F#.

I have an F# project which depends on a C# project.
I'm trying to use an object returned from C# method, but the IDE doesn't show properties which have overload with interfaces.

It also doesn't compile if I try to use properties.

Instead of properties, it shows setter methods (and doesn't show getter methods), however those properties must be get-only.

Expected behavior: The IDE should show the properties instead of the setter methods.