class Book:
    def __init__(self, author, title, year, genre, edition):
        self.author = author
        self.genre = genre
        self.edition = edition
        self.title = title
        self.year = year

    def __str__(self):
        return 'Book({}, {}, {}, {}, {})'.format(self.author, self.genre, self.edition, self.title, self.year)

    def __repr__(self):
        return 'Book({}, {}, {}, {}, {})'.format(self.author, self.genre, self.edition, self.title, self.year)

    def __eq__(self, other):
        return self.title == other.title and self.genre == other.genre and self.author == other.author and self.year == other.year  and self.edition == other.edition
book1 = Book("Стівен Кінг","фантастика","Книжковий клуб","Коли впаде темрява",2020   )
book2 = Book("Євген Чкалов","бойовик", "ДРУККНИГ","Stalker. Велика прогулянка", 2010,)
book3 = Book("Стівен Кінг","фантастика","Книжковий клуб","Коли впаде темрява",2020   )
print(Book.__str__(book1))
print(Book.__repr__(book1))
print(Book.__str__(book2))
print(Book.__repr__(book2))
print(Book.__eq__(book1, book2))
print(Book.__eq__(book1, book3))

