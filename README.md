# Elmahdi.Phone

[![Nuget downloads](https://img.shields.io/nuget/v/elmahdiphone.svg)](https://www.nuget.org/packages/Elmahdi.Phone/)
[![GitHub license](https://img.shields.io/github/license/khaledelmahdi/phone)](https://github.com/khaledelmahdi/phone)

Simple and common phone extensions to format and validate phone numbers.

## Installation

Available on [nuget]()

```
PM> Install-Package Elmahdi.Phone -Version 1.0.0
```

## Usage

### Formatting:

```c#
var phone = "0141 4 0 400 50";
phone.ToLocalPhoneNumber(); // returns 0141 404 0050
phone.ToInternationalPhoneNumber() // returns +441414040050
```

By default, these extensions are based on United Kingdom numbers. 
You may override them by passing the country code to the extension.

```c#
var phone = "05 06 850 900";
phone.ToLocalPhoneNumber("EG"); // returns 050 6850900
phone.ToInternationalPhoneNumber("EG") // returns +20506850900
```

### Validating

```c#
var validPhone = "0141 4 0 400 50";
var invalidPhone = "abc";

validPhone.IsValidPhoneNumberFor(); // returns true;
invalidPhone.IsValidPhoneNumberFor(); // returns false;
```


