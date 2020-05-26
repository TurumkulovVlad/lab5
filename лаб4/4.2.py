class Book:
    def __init__(self, author, title, year, genre, edition):
        self.author = author
        self.title = title
        self.year = year
        self.genre = genre
        self.edition = edition

    def __str__(self):
        return 'Book({}, {}, {}, {}, {})'.format(self.author, self.title, self.year, self.genre, self.edition)

    def __repr__(self):
        return 'Book({}, {}, {}, {}, {})'.format(self.author, self.title, self.year, self.genre, self.edition)

    def __eq__(self, other):
        return self.title == other.title and self.author == other.author and self.year == other.year and self.genre == other.genre and self.edition == other.edition
class Reviews:
	def __init__(self, reviews):
		self.reviews = reviews
	def __repr__(self):
		return 'Reviews({})'.format(self.reviews)
              
book1 = Book("Стівен Кінг","фантастика","Книжковий клуб","Коли впаде темрява",2020   )
reviews1 = Reviews(["непогано","цікаво","захоплююче"])
book2 = Book("Євген Чкалов","бойовик", "ДРУККНИГ","Stalker. Велика прогулянка", 2010,)
reviews2 = Reviews(["добре","відмінно","найкраще"])
print(Book.__str__(book1))
print(Reviews.__repr__(reviews1))
print(Book.__repr__(book2))
print(Reviews.__repr__(reviews2))

