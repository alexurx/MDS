using System;


class Book
{
    public string Title { get; set; }
    public int Year { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, int year)
    {
        Title = title;
        Year = year;
        IsBorrowed = false;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Title} ({Year}) - {(IsBorrowed ? "На руках" : "В наличии")}");
    }
}

class Library
{
    private Book[] books;

    public Library()
    {
        books = new Book[]
        {
            new Book("1984", 1949),
            new Book("Мастер и Маргарита", 1967),
            new Book("Три мушкетёра", 1844),
            new Book("Война и мир", 1869),
            new Book("Преступление и наказание", 1866)
        };
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\nСписок всех книг:");
        foreach (Book b in books)
        {
            b.PrintInfo();
        }
    }

    public void BorrowBook(string title)
    {
        foreach (Book b in books)
        {
            if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (b.IsBorrowed)
                {
                    Console.WriteLine("Эта книга уже взята!");
                    return;
                }

                b.IsBorrowed = true;
                Console.WriteLine($"Книга «{b.Title}» успешно выдана.");
                return;
            }
        }
        Console.WriteLine("Книга с таким названием не найдена.");
    }


    public void ReturnBook(string title)
    {
        foreach (Book b in books)
        {
            if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (!b.IsBorrowed)
                {
                    Console.WriteLine("Эта книга уже в библиотеке!");
                    return;
                }

                b.IsBorrowed = false;
                Console.WriteLine($"Книга «{b.Title}» возвращена в библиотеку.");
                return;
            }
        }
        Console.WriteLine("Ошибка: такой книги нет в библиотеке.");
    }
}



class Program
{
    static void Main()
    {
        Library library = new Library();
        // Menu(library);
        library.ShowAllBooks();
        library.BorrowBook("1984");
        library.ShowAllBooks();
        library.ReturnBook("1984");
        library.ShowAllBooks();

    }

    static void Menu(Library library)
    {
        int choice;

        do
        {
            Console.WriteLine("\nБиблиотека — выберите действие:");
            Console.WriteLine("1. Просмотреть все книги");
            Console.WriteLine("2. Взять книгу");
            Console.WriteLine("3. Вернуть книгу");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1:
                    library.ShowAllBooks();
                    break;
                case 2:
                    Console.Write("Введите название книги: ");
                    string take = Console.ReadLine();
                    library.BorrowBook(take);
                    break;
                case 3:
                    Console.Write("Введите название книги: ");
                    string ret = Console.ReadLine();
                    library.ReturnBook(ret);
                    break;
                case 0:
                    Console.WriteLine("Выход из программы...");
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        } while (choice != 0);
    }
}
