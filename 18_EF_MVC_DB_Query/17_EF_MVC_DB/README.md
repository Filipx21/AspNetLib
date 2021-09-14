### Dodawanie i usuwanie rekordów: 
#### Dodawanie:
* db.Customers.Add(customer);
* db.SaveChanges();
#### Usuwanie:
* db.Customers.Remove(customer);
* db.SaveChanges();

### Edycja/Zmiana stanu - Entry()
* dbContext.Entry(customer).State = 
  * Modified
  * Added
  * Deleted
  * Detached
  * Unchanged

### Zapytanie LINQ:
* Method syntax: 
  * var names = collection.Where(item => item.Name == "Name").Select(item => item.Name);
* Query syntax: 
  * var names = from item in collection where item.Name == "Name" select item.Name;