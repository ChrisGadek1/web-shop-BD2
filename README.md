# Fragment aplikacji przedstawiającej sklep internetowy do zakupu części samochodowych
Aplikacja będzie przechowywać klientów, producentów, zamówienia oraz wszystkie inne elementy potrzebne w prawidłowym funkcjonowaniu aplikacji. Aplikacja realizuje podstawowe czynności dostępne w sklepie internetowym:
- logowanie oraz rejestracja nowych użytkowników (konsumentów i dostawców)
- sprawdzanie dostępności wystawionych przedmiotów oraz mechanizm filtrów
- wybór przedmiotów i zakup ich (bez realizacji systemu płatności)

# Technologie:
  - Entity Framework
  - C#
  - SQLite3
  - .NET

# Schemat:
![image](https://user-images.githubusercontent.com/58474974/121442113-4af2df00-c98b-11eb-9c85-a0e477cb01d4.png)

W schemacie można wyszczególnić trzy integralne części:
- Users, Customers i Distributors - tabele odpowiedzialne za system uwierzytelniania użytkowników w systemie 
- Products, StoragePlaces - tabele odpowiedzialne za stany magazynowego sklepu internetowego 
- Invoices, Cart - tabele odpowiedzialne za realizacje zamówień i koszyk
Ponadto:
- DistributorsProducts, OrderUnits, CartElements - tabele pomocnicze dodane w celu realizacji relacji wiele do wiele

# Tabele

Users - użytkownicy:
- UsersID - identyfikator użytkownika w systemie
- City, Street, Number, PostCode, Country - dane odpowiedzialne za lokalizacje podmiotu
- Phone, Email - dane kontaktowe użytkownika
- NIP - numer identyfikacji podatkowej podatników w Polsce
- Password - hasło do konta użytkownika w formie zaszyfrowanej

Customers - klienci (Users):
- UsersID - identyfikator użytkownika w systemie
- CustomersID - identyfikator klienta w systemie
- FirstName - imie
- LastName = nazwisko
- CardNumber - numer rachunku bankowego klienta

Distributors - dostawcy (Users):
- UsersID - identyfikator użytkownika w systemie
- DistributorsID - identyfikator dostawcy w systemie
- CompanyName - nazwa firmy dostarczającej
- BankAccountNumber - numer konta bankowego dostawcy

Products - produkty:
- ProductID - identyfikator konkretnego przedmiotu (typ, model) w systemie
- ProductName - nazwa przedmiotu
- ShortDescription - krótki opis produktu zawierający najważniejsze informacje
- Description - pełny opis produkty zawierający wszystkie informacje techniczne
- Quantity - ilość przedmiotów dostępnych na stanach magazynowych
- Price - cena jednostkowa
- MeasureUnit - jednostka miary
- StoragePlacesID - identyfikator przestrzeni magazynowej

StoragePlaces - przestrzenie magazynowe:
- StoragePlacesID - identyfikator przestrzeni magazynowej
- Section, Row, Place - wartości konkretnie definiujące położenie konkretnych przedmiotów na magazynie

Invoices - faktury:
- InvoicesID - identyfikator faktury w systemie
- CustomerUsersID - identyfikator użytkownika będącego stroną w zawieraniu umowy kupna
- InvoiceDate - data realizacji zamówienia
- ProductsID - identyfikator zbioru produktów zakupionych w ramach danej faktury

OrderUnits - zbiór produktów dla danej faktury:
- OrderUnitID - identyfikator zbioru produktów
- ProductsID - identyfikator zakupionego przedmiotu
- NumberOfProducts - ilość produktów danego typu
- unitPrice - cena jednostkowa produktu
- InvoicesID - identyfikator faktury w systemie

Cart - koszyk:
- CartID - identyfikator koszyka
- UsersID - użytkownik, do którego jest przypisany dany koszyk

CartElements - przedmioty w koszyku:
- CartElementsID - identifikator zbioru produktów zawartych w koszyku
- ProductsID - identyfikator przedmiotu w systemie
- NumberOfElements - ilość produktów danego typu
- CartID - identyfikator koszyka









# Skład grupy:
  - Krzysztof Gądek
  - Mateusz Asimowicz
