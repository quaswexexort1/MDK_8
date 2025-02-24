public class Book
{
    public string Title { get; set; } // Хранит название книги
    public double Price { get; set; } // Хранит цену книги

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }
}

public class abc
{
    public static void Main()
    {
        // Создаем стек для хранения информации о книгах (название и цена)
        Stack<Book> bookStack = new Stack<Book>();

        // Добавляем несколько книг в стек
        bookStack.Push(new Book("Властелин колец", 999));
        bookStack.Push(new Book("Гордость и предубеждение", 599));
        bookStack.Push(new Book("1984", 799));

        // Выводим информацию о книгах в стеке и вычисляем среднюю цену
        double totalPrice = 0; // Переменная для общей цены
        int bookCount = 0;    // Переменная для количества книг

        Console.WriteLine("Книги в стеке:");
        foreach (Book book in bookStack)
        {
            Console.WriteLine($"Название: {book.Title}, Цена: {book.Price}");
            totalPrice += book.Price;
            bookCount++;
        }

        // Вычисляем и выводим среднюю цену
        if (bookCount > 0)
        {
            double averagePrice = totalPrice / bookCount;
            Console.WriteLine($"\nСредняя цена книги: {averagePrice:F2}");
        }
        else
        {
            Console.WriteLine("\nВ стеке нет книг.");
        }
    }
}

