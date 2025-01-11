# PatikaLibrary

This project demonstrates the usage of a `Books` class to manage book-related information using C#. The class features properties, constructors, and methods to create and handle book objects effectively.

## Features

### Class: `Books`
The `Books` class encapsulates the attributes and behaviors of a book, including:

- **Properties**:
  - `BookName`: Name of the book.
  - `AuthorName`: First name of the author.
  - `AuthorSurname`: Last name of the author.
  - `PageNumber`: Number of pages in the book.
  - `Publisher`: Publisher of the book.
  - `RegisterDate`: Registration date (automatically assigned during object creation).

- **Constructors**:
  1. **Default Constructor**:
     - Automatically assigns the current date and time to `RegisterDate`.
     - Does not require parameters.
  2. **Parameterized Constructor**:
     - Takes `BookName`, `AuthorName`, `AuthorSurname`, `PageNumber`, and `Publisher` as parameters.
     - Automatically assigns the current date and time to `RegisterDate`.

## How to Use

### 1. Using the Default Constructor
Create a new `Books` object without providing any initial values:

```csharp
Books book1 = new Books();

book1.BookName = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PageNumber = 398;
book1.Publisher = "Remzi Kitabevi";
book1.RegisterDate = DateTime.Now;

Console.WriteLine("Kitap Adı: " + book1.BookName +
                  "\nYazar Adı, Soyadı : " + book1.AuthorName + " " + book1.AuthorSurname +
                  "\nSayfa Sayısı: " + book1.PageNumber +
                  "\nYayınevi: " + book1.Publisher +
                  "\nKayıt Tarihi: " + book1.RegisterDate);
```

### 2. Using the Parameterized Constructor
Create a new `Books` object and assign values directly during object initialization:

```csharp
Books book2 = new Books("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

Console.WriteLine("Kitap Adı: " + book2.BookName +
                  "\nYazar Adı, Soyadı : " + book2.AuthorName + " " + book2.AuthorSurname +
                  "\nSayfa Sayısı: " + book2.PageNumber +
                  "\nYayınevi: " + book2.Publisher +
                  "\nKayıt Tarihi: " + book2.RegisterDate);
```

## Example Output

When you run the program, the output will look like this:

```
Kitap Adı: Adı Aylin
Yazar Adı, Soyadı : Ayşe Kulin
Sayfa Sayısı: 398
Yayınevi: Remzi Kitabevi
Kayıt Tarihi: 21/12/2024 12:34:56 PM

Kitap Adı: Adı Aylin
Yazar Adı, Soyadı : Ayşe Kulin
Sayfa Sayısı: 398
Yayınevi: Remzi Kitabevi
Kayıt Tarihi: 21/12/2024 12:34:56 PM
```

## Concepts Demonstrated

- **Class**: The `Books` class serves as a blueprint for creating book objects.
- **Properties**: Attributes such as `BookName`, `AuthorName`, etc., are defined as properties of the `Books` class.
- **Constructors**:
  - Default constructor initializes an object without parameters.
  - Parameterized constructor assigns values during object creation.
- **New Keyword**: Used to create new instances of the `Books` class.





